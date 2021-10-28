using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwingLauncherInstaller
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog fbd = new FolderBrowserDialog())
			{
				if (fbd.ShowDialog() == DialogResult.OK)
				{
					textBox1.Text = fbd.SelectedPath;
				}
			}
		}

		public void Unzip(string path, string to)
		{
			ZipFile.ExtractToDirectory(path, to);
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
				System.IO.File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
			}
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			if(textBox1.Text == "")
			{
				MessageBox.Show("Please enter a valid path!");
				return;
			}

			string appPath = textBox1.Text;
			string version = "launcher-0.20";

			if(appPath.Last() != '/' && appPath.Last() != '\\')
			{
				appPath += @"\";
			}

			var githubToken = "0";

			var url = "https://github.com/Vadkarika2/swingCourse/archive/" + version + ".zip";

			if (Directory.Exists(textBox1.Text + @"\SwingLauncher"))
			{
				return;
			}
			else
			{
				Directory.CreateDirectory(textBox1.Text + @"\SwingLauncher");
			}

			var path = textBox1.Text + @"\SwingLauncher\launcher-latest.zip";

			try
			{
				using (var client = new System.Net.Http.HttpClient())
				{
					var credentials = string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}:", githubToken);
					credentials = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(credentials));
					client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);
					var contents = await client.GetByteArrayAsync(url);
					System.IO.File.WriteAllBytes(path, contents);
				}
			}
			catch (Exception)
			{
				return;
			}

			if (!Directory.Exists(textBox1.Text + @"\SwingLauncher\Launcher"))
			{
				Directory.CreateDirectory(textBox1.Text + @"\SwingLauncher\Launcher");
			}

			if (!Directory.Exists(textBox1.Text + @"\SwingLauncher\Launcher"))
			{
				Directory.CreateDirectory(textBox1.Text + @"\SwingLauncher\Data\Downloads\LauncherUpdate");
			}

			await Task.Factory.StartNew(() =>
			{
				Unzip(path, textBox1.Text + @"\SwingLauncher\Data\Downloads\LauncherUpdate");

				try
				{
					CopyFilesRecursively(textBox1.Text + @"\SwingLauncher\Data\Downloads\LauncherUpdate\swingCourse-" + version, textBox1.Text + @"\SwingLauncher\Launcher");
				}
				catch (Exception)
				{

				}
			});

			string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

			CreateShortcut("Swing Launcher", appPath + @"\SwingLauncher\Launcher\SwingLauncher.exe", appPath + "SwingLauncher");

			if (checkBox1.Checked)
			{
				CreateShortcut("Swing Launcher", appPath + @"\SwingLauncher\Launcher\SwingLauncher.exe", desktop);
			}

			Process.Start(textBox1.Text + @"\SwingLauncher\Launcher\SwingLauncher.exe");
			Application.Exit();
		}

		public void CreateShortcut(string name, string executable, string shortcutPath)
		{
			//using (StreamWriter w = new StreamWriter(shortcutPath + "/" + name + ".url"))
			//{
			//	w.WriteLine("[InternetShortcut]");
			//	w.WriteLine("URL=file:///" + link);
			//	w.WriteLine("IconIndex=0");
			//	w.Write("IconFile=" + link);
			//	MessageBox.Show(link);
			//}

			WshShell shell = new WshShell();

			IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath + @"\" + name + ".lnk");
			shortcut.TargetPath = executable;

			//shortcut.IconLocation = 'Location of  iCon you want to set";

			// add Description of Short cut
			shortcut.Description = "Swing Launcher";

			// save it / create
			shortcut.Save();
		}
	}
}
