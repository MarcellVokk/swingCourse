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
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwingLauncher
{
	public partial class Form1 : Form
	{
		IFirebaseConfig config = new FirebaseConfig
		{
			AuthSecret = "UPuTlU8eTdGrm4cHFEkaK8CNceGyx8Ue0EWLpbMD",
			BasePath = "https://swinglauncher-default-rtdb.firebaseio.com/"
		};

		IFirebaseClient client;

		public Form1()
		{
			InitializeComponent();
		}

		public static bool IsAdministrator()
		{
			var identity = WindowsIdentity.GetCurrent();
			var principal = new WindowsPrincipal(identity);
			return principal.IsInRole(WindowsBuiltInRole.Administrator);
		}

		private async void button1_Click_1(object sender, EventArgs e)
		{
			if(launchButton.Text == "...")
			{

			}
			else if(launchButton.Text == "Download" || launchButton.Text == "Update")
			{
				launchButton.Text = "...";
				await DownloadLatest();
			}
			else if(launchButton.Text == "Launch")
			{
				if(await CheckForUpdates() == false)
				{
					string curentVersion = "0";

					if (!File.Exists(Application.StartupPath + @"\Game\version.txt"))
					{
						updatePanel.Visible = true;
						return;
					}
					else
					{
						using (StreamReader sr = new StreamReader(Application.StartupPath + @"\Game\version.txt"))
						{
							string version = sr.ReadToEnd();

							curentVersion = version.Split(',')[0];
						}
					}

					try
					{
						Process.Start(Application.StartupPath + @"\Game\swingCourse-" + curentVersion + @"\Swing Course.exe");
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

			if(!File.Exists(Application.StartupPath + @"\Game\version.txt"))
			{
				updatePanel.Visible = true;
				return true;
			}
			else
			{
				using (StreamReader sr = new StreamReader(Application.StartupPath + @"\Game\version.txt"))
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

		public async Task DownloadLatest()
		{
			status.Text = "Initalizing...";

			FirebaseResponse fr = await client.GetAsync("versions/latest");
			Version v = fr.ResultAs<Version>();

			var githubToken = "0";
			var url = "https://github.com/Vadkarika2/swingCourse/archive/" + v.name + ".zip";

			if (!Directory.Exists(Application.StartupPath + @"\Downloads"))
			{
				Directory.CreateDirectory(Application.StartupPath + @"\Downloads");
			}

			var path = Application.StartupPath + @"\Downloads\latest.zip";

			status.Text = "Downloading update...";

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

			if (Directory.Exists(Application.StartupPath + @"\Game"))
			{
				await Task.Factory.StartNew(() =>
				{
					Directory.Delete(Application.StartupPath + @"\Game", true);
					Directory.CreateDirectory(Application.StartupPath + @"\Game");
				});
			}

			status.Text = "Decompressing...";

			await Task.Factory.StartNew(() =>
			{
				Unzip(Application.StartupPath + @"\Downloads\latest.zip", Application.StartupPath + @"\Game");
			});

			status.Text = "";

			using(StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Game\version.txt"))
			{
				sw.Write(v.name + "," + v.isSnapshot + ",");
			}

			launchButton.Text = "Launch";
		}

		public void Unzip(string path, string to)
		{
			ZipFile.ExtractToDirectory(path, to);
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			if (!IsAdministrator())
			{
				Process process = new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = Application.ExecutablePath,
						Arguments = "-e",
						Verb = "runas",//-Admin.
					}
				};
				Application.Exit();
				process.Start();
			}

			client = new FirebaseClient(config);

			updatePanel.Height = 450;

			FirebaseResponse fr = await client.GetAsync("versions/latest");
			Version v = fr.ResultAs<Version>();

			string curentVersion = "0";

			if (!File.Exists(Application.StartupPath + @"\Game\version.txt"))
			{
				launchButton.Text = "Download";
			}
			else
			{
				using (StreamReader sr = new StreamReader(Application.StartupPath + @"\Game\version.txt"))
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

		private void button3_Click(object sender, EventArgs e)
		{
			updatePanel.Visible = false;
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			updatePanel.Visible = false;
			launchButton.Text = "...";
			await DownloadLatest();
		}
	}
}
