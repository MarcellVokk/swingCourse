using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwingCourseUploadUpdate
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		IFirebaseConfig config = new FirebaseConfig
		{
			AuthSecret = "UPuTlU8eTdGrm4cHFEkaK8CNceGyx8Ue0EWLpbMD",
			BasePath = "https://swinglauncher-default-rtdb.firebaseio.com/"
		};

		IFirebaseClient client;

		private void button1_Click(object sender, EventArgs e)
		{
			using(FolderBrowserDialog fbd = new FolderBrowserDialog())
			{
				if(fbd.ShowDialog() == DialogResult.OK)
				{
					label1.Text = fbd.SelectedPath;
				}
			}
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			label3.Text = "Uploading update...";

			bool isLauncherUpdate = checkBox2.Checked;

			await Task.Factory.StartNew(() =>
			{
				if (checkBox2.Checked)
				{
					Process pc = new Process();
					ProcessStartInfo startInfo = new ProcessStartInfo();
					startInfo.WindowStyle = ProcessWindowStyle.Hidden;
					startInfo.Verb = "runas";
					startInfo.FileName = "cmd.exe";
					startInfo.WorkingDirectory = label1.Text + @"\";
					startInfo.Arguments = "/C echo a&cd /d " + label1.Text + "&rmdir /Q /S " + label1.Text + @"\.git&git init&git add .&git branch launcher-" + textBox1.Text + "&git commit -m 'a'&git remote add origin https://github.com/Vadkarika2/swingCourse.git&git push -u origin launcher-" + textBox1.Text + " --force&git init&git add .&git branch launcher-" + textBox1.Text + "&git commit -m 'a'&git remote add origin https://github.com/Vadkarika2/swingCourse.git&git push -u origin launcher-" + textBox1.Text + " --force";
					pc.StartInfo = startInfo;
					pc.Start();
					pc.WaitForExit();
				}
				else
				{
					Process pc = new Process();
					ProcessStartInfo startInfo = new ProcessStartInfo();
					startInfo.WindowStyle = ProcessWindowStyle.Hidden;
					startInfo.Verb = "runas";
					startInfo.FileName = "cmd.exe";
					startInfo.WorkingDirectory = label1.Text + @"\";
					startInfo.Arguments = "/C echo a&cd /d " + label1.Text + "&rmdir /Q /S " + label1.Text + @"\.git&git init&git add .&git branch " + textBox1.Text + "&git commit -m 'a'&git remote add origin https://github.com/Vadkarika2/swingCourse.git&git push -u origin " + textBox1.Text + " --force&git init&git add .&git branch " + textBox1.Text + "&git commit -m 'a'&git remote add origin https://github.com/Vadkarika2/swingCourse.git&git push -u origin " + textBox1.Text + " --force";
					pc.StartInfo = startInfo;
					pc.Start();
					pc.WaitForExit();
				}
			});

			if (!checkBox3.Checked)
			{
				if (checkBox2.Checked)
				{
					await client.SetAsync("launcher/versions/latest", new Version("launcher-" + textBox1.Text, false));
				}
				else
				{
					await client.SetAsync("versions/latest", new Version(textBox1.Text, checkBox1.Checked));
				}
			}

			label3.Text = "Update uploaded succesfuly!";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			client = new FirebaseClient(config);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog fbd = new FolderBrowserDialog())
			{
				if (fbd.ShowDialog() == DialogResult.OK)
				{
					label1.Text = fbd.SelectedPath;
				}
			}
		}
	}
}
