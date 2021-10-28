
namespace SwingLauncher
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.launchButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.updatePanel = new System.Windows.Forms.Panel();
			this.status = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.launcherUpdatePanel = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.button5 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.launcherUpdatingPanel = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.updatePanel.SuspendLayout();
			this.panel3.SuspendLayout();
			this.launcherUpdatePanel.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.launcherUpdatingPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// launchButton
			// 
			this.launchButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.launchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
			this.launchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.launchButton.FlatAppearance.BorderSize = 5;
			this.launchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.launchButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.launchButton.ForeColor = System.Drawing.Color.White;
			this.launchButton.Location = new System.Drawing.Point(315, 383);
			this.launchButton.Name = "launchButton";
			this.launchButton.Size = new System.Drawing.Size(170, 50);
			this.launchButton.TabIndex = 0;
			this.launchButton.TabStop = false;
			this.launchButton.Text = "...";
			this.launchButton.UseVisualStyleBackColor = false;
			this.launchButton.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(184, -142);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(432, 278);
			this.panel1.TabIndex = 4;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button3.FlatAppearance.BorderSize = 4;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(121, 226);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(92, 34);
			this.button3.TabIndex = 2;
			this.button3.TabStop = false;
			this.button3.Text = "Not now";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
			this.button2.FlatAppearance.BorderSize = 4;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(219, 226);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(92, 34);
			this.button2.TabIndex = 2;
			this.button2.TabStop = false;
			this.button2.Text = "Update";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(86, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(260, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "There is a new update available for SwingCourse";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(166, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 36);
			this.label2.TabIndex = 0;
			this.label2.Text = "Update";
			// 
			// updatePanel
			// 
			this.updatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.updatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.updatePanel.Controls.Add(this.panel1);
			this.updatePanel.Location = new System.Drawing.Point(0, 0);
			this.updatePanel.Name = "updatePanel";
			this.updatePanel.Size = new System.Drawing.Size(800, 0);
			this.updatePanel.TabIndex = 5;
			this.updatePanel.Visible = false;
			// 
			// status
			// 
			this.status.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.status.BackColor = System.Drawing.Color.Transparent;
			this.status.FlatAppearance.BorderSize = 0;
			this.status.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.status.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.status.ForeColor = System.Drawing.Color.White;
			this.status.Location = new System.Drawing.Point(620, 11);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(170, 27);
			this.status.TabIndex = 0;
			this.status.TabStop = false;
			this.status.UseVisualStyleBackColor = false;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.status);
			this.panel3.Location = new System.Drawing.Point(0, 401);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(800, 49);
			this.panel3.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(3, 29);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "launcher-0.21";
			// 
			// launcherUpdatePanel
			// 
			this.launcherUpdatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.launcherUpdatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.launcherUpdatePanel.Controls.Add(this.panel5);
			this.launcherUpdatePanel.Location = new System.Drawing.Point(0, 0);
			this.launcherUpdatePanel.Name = "launcherUpdatePanel";
			this.launcherUpdatePanel.Size = new System.Drawing.Size(800, 0);
			this.launcherUpdatePanel.TabIndex = 6;
			this.launcherUpdatePanel.Visible = false;
			// 
			// panel5
			// 
			this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel5.Controls.Add(this.button5);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Location = new System.Drawing.Point(184, -139);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(432, 278);
			this.panel5.TabIndex = 4;
			this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
			this.button5.FlatAppearance.BorderSize = 4;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Location = new System.Drawing.Point(170, 226);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(92, 34);
			this.button5.TabIndex = 0;
			this.button5.TabStop = false;
			this.button5.Text = "Update";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(92, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(249, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Update to the latest version of SwingLauncher";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(166, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 36);
			this.label4.TabIndex = 0;
			this.label4.Text = "Update";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackgroundImage = global::SwingLauncher.Properties.Resources.Screenshot__6_;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel2.Controls.Add(this.button1);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(776, 390);
			this.panel2.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(0, 149);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(776, 89);
			this.button1.TabIndex = 0;
			this.button1.TabStop = false;
			this.button1.Text = "Swing Course";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(253)))));
			this.panel4.Controls.Add(this.panel2);
			this.panel4.Location = new System.Drawing.Point(12, 12);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(776, 390);
			this.panel4.TabIndex = 1;
			// 
			// launcherUpdatingPanel
			// 
			this.launcherUpdatingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.launcherUpdatingPanel.Controls.Add(this.button4);
			this.launcherUpdatingPanel.Location = new System.Drawing.Point(0, 0);
			this.launcherUpdatingPanel.Name = "launcherUpdatingPanel";
			this.launcherUpdatingPanel.Size = new System.Drawing.Size(800, 0);
			this.launcherUpdatingPanel.TabIndex = 9;
			this.launcherUpdatingPanel.Visible = false;
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.BackColor = System.Drawing.Color.Transparent;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(0, -44);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(800, 89);
			this.button4.TabIndex = 1;
			this.button4.TabStop = false;
			this.button4.Text = "Updating...";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.launcherUpdatingPanel);
			this.Controls.Add(this.updatePanel);
			this.Controls.Add(this.launcherUpdatePanel);
			this.Controls.Add(this.launchButton);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel4);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Swing Launcher";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.updatePanel.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.launcherUpdatePanel.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.launcherUpdatingPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button launchButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel updatePanel;
		private System.Windows.Forms.Button status;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel launcherUpdatePanel;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel launcherUpdatingPanel;
		private System.Windows.Forms.Button button4;
	}
}

