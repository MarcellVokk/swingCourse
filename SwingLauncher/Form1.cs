using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwingLauncher
{
	public partial class Form1 : Form
	{
		string basePath = "";

		IFirebaseConfig config = new FirebaseConfig
		{
			AuthSecret = "UPuTlU8eTdGrm4cHFEkaK8CNceGyx8Ue0EWLpbMD",
			BasePath = "https://swinglauncher-default-rtdb.firebaseio.com/"
		};

		IFirebaseClient client;

		bool updateMode = false;

		[System.Runtime.InteropServices.DllImport("gdi32.dll")]
		private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
		private PrivateFontCollection fonts = new PrivateFontCollection();
		Font impact;
		Font roboto;


		public Form1(string[] args)
		{
			InitializeComponent();

			if (args != null && args.Length > 0 && args[0] == "updateLauncher")
			{
				updateMode = true;
			}

			//impact

			byte[] fontData = Properties.Resources.impact;
			IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
			System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
			uint dummy = 0;
			fonts.AddMemoryFont(fontPtr, Properties.Resources.impact.Length);
			AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.impact.Length, IntPtr.Zero, ref dummy);
			System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

			impact = new Font(fonts.Families[0], 8.0F);

			//roboto

			fontData = Properties.Resources.roboto_medium;
			fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
			System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
			dummy = 0;
			fonts.AddMemoryFont(fontPtr, Properties.Resources.roboto_medium.Length);
			AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.roboto_medium.Length, IntPtr.Zero, ref dummy);
			System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

			roboto = new Font(fonts.Families[1], 8.0F);
		}

		public static bool IsAdministrator()
		{
			var identity = WindowsIdentity.GetCurrent();
			var principal = new WindowsPrincipal(identity);
			return principal.IsInRole(WindowsBuiltInRole.Administrator);
		}

		private async void button1_Click_1(object sender, EventArgs e)
		{
			(sender as Button).TabStop = false;
			(sender as Button).NotifyDefault(false);
			label1.Focus();

			if (launchButton.Text == "...")
			{

			}
			else if(launchButton.Text == "Download" || launchButton.Text == "Update")
			{
				launchButton.Text = "...";
				await DownloadLatest(false);
			}
			else if(launchButton.Text == "Launch")
			{
				if(await CheckForUpdates() == false)
				{
					string curentVersion = "0";

					if (!File.Exists(basePath + @"\Game\version.txt"))
					{
						updatePanel.Visible = true;
						return;
					}
					else
					{
						using (StreamReader sr = new StreamReader(basePath + @"\Game\version.txt"))
						{
							string version = sr.ReadToEnd();

							curentVersion = version.Split(',')[0];
						}
					}

					try
					{
						Process.Start(basePath + @"\Game\swingCourse-" + curentVersion + @"\Swing Course.exe");
					}
					catch (Exception)
					{
						status.Text = "Error launching: Game not updated!";
						launchButton.Text = "Update";
					}
				}
			}
		}

		public async Task<bool> CheckForUpdates()
		{
			launchButton.Text = "...";

			FirebaseResponse fr = await client.GetAsync("versions/latest");
			Version v = fr.ResultAs<Version>();

			string curentVersion = "0";

			if(!File.Exists(basePath + @"\Game\version.txt"))
			{
				updatePanel.Visible = true;
				return true;
			}
			else
			{
				using (StreamReader sr = new StreamReader(basePath + @"\Game\version.txt"))
				{
					string version = sr.ReadToEnd();

					curentVersion = version.Split(',')[0];
				}
			}

			if(v.name != curentVersion)
			{
				updatePanel.Visible = true;
				launchButton.Text = "Update";
				return true;
			}
			else
			{
				launchButton.Text = "Launch";
				return false;
			}
		}

		public async Task DownloadLatest(bool launcher)
		{
			if (launcher)
			{
				status.Text = "Initalizing...";

				FirebaseResponse fr = await client.GetAsync("launcher/versions/latest");
				Version v = fr.ResultAs<Version>();

				var githubToken = "0";

				var url = "https://github.com/Vadkarika2/swingCourse/archive/" + v.name + ".zip";

				if (!Directory.Exists(basePath + @"\Data\Downloads"))
				{
					Directory.CreateDirectory(basePath + @"\Data\Downloads");
				}

				var path = basePath + @"\Data\Downloads\launcher-latest.zip";

				status.Text = "Downloading files...";

				try
				{
					using (var client = new System.Net.Http.HttpClient())
					{
						var credentials = string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}:", githubToken);
						credentials = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(credentials));
						client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);
						var contents = await client.GetByteArrayAsync(url);
						File.WriteAllBytes(path, contents);
					}
				}
				catch (Exception)
				{
					status.Text = "Download failed: Version not found!";
					launchButton.Text = "Update";
					return;
				}

				status.Text = "Patching...";

				status.Text = "Decompressing...";

				await Task.Factory.StartNew(() =>
				{
					Unzip(basePath + @"\Data\Downloads\launcher-latest.zip", basePath + @"\Data\Downloads\LauncherLatest");
				});

				try
				{
					CopyFilesRecursively(basePath + @"\Data\Downloads\LauncherLatest\swingCourse-" + v.name, basePath + @"\Launcher");
				}
				catch (Exception)
				{

				}

				await Task.Factory.StartNew(() =>
				{
					Process pc = new Process();
					ProcessStartInfo startInfo = new ProcessStartInfo();
					startInfo.WindowStyle = ProcessWindowStyle.Hidden;
					startInfo.FileName = "cmd.exe";
					startInfo.WorkingDirectory = basePath + @"\LauncherUpdate";
					startInfo.Arguments = "/C echo a&cd /d " + basePath + @"&rmdir /Q /S " + basePath + @"\Data\Downloads\LauncherLatest";
					pc.StartInfo = startInfo;
					pc.Start();
					pc.WaitForExit();
				});

				status.Text = "";

				using (StreamWriter sw = new StreamWriter(basePath + @"\Data\launcher-version.txt"))
				{
					sw.Write(v.name + "," + v.isSnapshot + ",");
				}

				Process.Start(basePath + @"\Launcher\SwingLauncher.exe");
				Application.Exit();
			}
			else
			{
				status.Text = "Initalizing...";

				FirebaseResponse fr = await client.GetAsync("versions/latest");

				Version v = fr.ResultAs<Version>();

				var githubToken = "0";

				var url = "https://github.com/Vadkarika2/swingCourse/archive/" + v.name + ".zip";

				if (!Directory.Exists(basePath + @"\Downloads"))
				{
					Directory.CreateDirectory(basePath + @"\Downloads");
				}

				var path = basePath + @"\Downloads\latest.zip";

				status.Text = "Downloading files...";

				try
				{
					using (var client = new System.Net.Http.HttpClient())
					{
						var credentials = string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}:", githubToken);
						credentials = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(credentials));
						client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);
						var contents = await client.GetByteArrayAsync(url);
						File.WriteAllBytes(path, contents);
					}
				}
				catch (Exception)
				{
					status.Text = "Download failed: Version not found!";
					launchButton.Text = "Update";
					return;
				}

				status.Text = "Patching...";

				if (Directory.Exists(basePath + @"\Game"))
				{
					await Task.Factory.StartNew(() =>
					{
						Directory.Delete(basePath + @"\Game", true);
						Directory.CreateDirectory(basePath + @"\Game");
					});
				}

				status.Text = "Decompressing...";

				await Task.Factory.StartNew(() =>
				{
					Unzip(basePath + @"\Downloads\latest.zip", basePath + @"\Game");
				});

				status.Text = "";

				using (StreamWriter sw = new StreamWriter(basePath + @"\Game\version.txt"))
				{
					sw.Write(v.name + "," + v.isSnapshot + ",");
				}

				launchButton.Text = "Launch";
			}
		}

		public void Unzip(string path, string to)
		{
			ZipFile.ExtractToDirectory(path, to);
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			label3.Font = new Font(roboto.FontFamily, 9.0f);
			button2.Font = new Font(roboto.FontFamily, 9.0f);
			button3.Font = new Font(roboto.FontFamily, 9.0f);
			label1.Font = new Font(roboto.FontFamily, 9.0f);
			button5.Font = new Font(roboto.FontFamily, 9.0f);
			label5.Font = new Font(roboto.FontFamily, 9.0f);
			status.Font = new Font(roboto.FontFamily, 9.0f);

			button1.Font = new Font(impact.FontFamily, 48.0f);
			button4.Font = new Font(impact.FontFamily, 21.75f);
			label2.Font = new Font(impact.FontFamily, 21.75f);
			label4.Font = new Font(impact.FontFamily, 21.75f);
			launchButton.Font = new Font(impact.FontFamily, 15.75f);

			if (updateMode)
			{
				launcherUpdatingPanel.Height = 450;
				launcherUpdatingPanel.Visible = true;

				client = new FirebaseClient(config);

				basePath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));

				if (!Directory.Exists(basePath + @"\Data"))
				{
					Directory.CreateDirectory(basePath + @"\Data");
				}

				await Task.Factory.StartNew(() =>
				{
					Process pc = new Process();
					ProcessStartInfo startInfo = new ProcessStartInfo();
					startInfo.WindowStyle = ProcessWindowStyle.Hidden;
					startInfo.FileName = "cmd.exe";
					startInfo.WorkingDirectory = basePath + @"\LauncherUpdate";
					startInfo.Arguments = "/C echo a&cd /d " + basePath + @"&rmdir /Q /S " + basePath + @"\Launcher";
					pc.StartInfo = startInfo;
					pc.Start();
					pc.WaitForExit();
					Directory.CreateDirectory(basePath + @"\Launcher");
				});

				await DownloadLatest(true);
			}
			else
			{
				basePath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\Data"));

				if (!Directory.Exists(basePath))
				{
					Directory.CreateDirectory(basePath);
				}

				if (!Directory.Exists(basePath + @"\Game"))
				{
					Directory.CreateDirectory(basePath + @"\Game");
				}

				if (!Directory.Exists(basePath + @"\Downloads"))
				{
					Directory.CreateDirectory(basePath + @"\Downloads");
				}

				//if (!IsAdministrator())
				//{
				//	Process process = new Process
				//	{
				//		StartInfo = new ProcessStartInfo
				//		{
				//			FileName = Application.ExecutablePath,
				//			Arguments = "-e",
				//			Verb = "runas",//-Admin.
				//		}
				//	};
				//	Application.Exit();
				//	process.Start();
				//}

				client = new FirebaseClient(config);

				updatePanel.Height = 450;
				launcherUpdatePanel.Height = 450;

				FirebaseResponse fr = await client.GetAsync("launcher/versions/latest");
				Version v = fr.ResultAs<Version>();

				string curentLauncherVersion = "0";

				if (!File.Exists(basePath + @"\launcher-version.txt"))
				{
					UpdateLauncher();

					return;
				}
				else
				{
					using (StreamReader sr = new StreamReader(basePath + @"\launcher-version.txt"))
					{
						string version = sr.ReadToEnd();

						curentLauncherVersion = version.Split(',')[0];
					}

					if (v.name != curentLauncherVersion)
					{
						launcherUpdatePanel.Visible = true;
					}
				}

				fr = await client.GetAsync("versions/latest");
				v = fr.ResultAs<Version>();

				string curentVersion = "0";

				if (!File.Exists(basePath + @"\Game\version.txt"))
				{
					launchButton.Text = "Download";
				}
				else
				{
					using (StreamReader sr = new StreamReader(basePath + @"\Game\version.txt"))
					{
						string version = sr.ReadToEnd();

						curentVersion = version.Split(',')[0];
					}

					if (v.name != curentVersion)
					{
						launchButton.Text = "Update";
					}
					else
					{
						launchButton.Text = "Launch";
					}
				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			(sender as Button).TabStop = false;
			(sender as Button).TabIndex = 0;

			updatePanel.Visible = false;
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			(sender as Button).TabStop = false;
			(sender as Button).TabIndex = 0;

			updatePanel.Visible = false;
			launchButton.Text = "...";
			await DownloadLatest(false);
		}

		private async void button5_Click(object sender, EventArgs e)
		{
			(sender as Button).TabStop = false;
			(sender as Button).TabIndex = 0;

			UpdateLauncher();
		}

		public async void UpdateLauncher()
		{
			await Task.Factory.StartNew(() =>
			{
				try
				{
					Process pc = new Process();
					ProcessStartInfo startInfo = new ProcessStartInfo();
					startInfo.WindowStyle = ProcessWindowStyle.Hidden;
					startInfo.FileName = "cmd.exe";
					startInfo.WorkingDirectory = basePath + @"\LauncherUpdate";
					startInfo.Arguments = "/C echo a&cd /d " + basePath + @"&rmdir /Q /S " + basePath + @"\LauncherUpdate&rmdir /Q /S " + basePath + @"\Downloads\LauncherLatest";
					pc.StartInfo = startInfo;
					pc.Start();
					pc.WaitForExit();
					Directory.CreateDirectory(basePath + @"\LauncherUpdate");
					CopyFilesRecursively(Application.StartupPath, basePath + @"\LauncherUpdate");
				}
				catch (Exception)
				{
					Application.Exit();
				}
			});

			Process.Start(basePath + @"\LauncherUpdate\SwingLauncher.exe", "updateLauncher");
			Application.Exit();
		}

		private static void CopyFilesRecursively(string sourcePath, string targetPath)
		{
			//Now Create all of the directories
			foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
			{
				Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
			}

			//Copy all the files & Replaces any files with the same name
			foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
			{
				File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
			}
		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
