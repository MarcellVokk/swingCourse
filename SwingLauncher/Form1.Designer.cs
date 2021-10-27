
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
			this.launchButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.updatePanel = new System.Windows.Forms.Panel();
			this.status = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.updatePanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// launchButton
			// 
			this.launchButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.launchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
			this.launchButton.FlatAppearance.BorderSize = 0;
			this.launchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.launchButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.launchButton.ForeColor = System.Drawing.Color.White;
			this.launchButton.Location = new System.Drawing.Point(315, 12);
			this.launchButton.Name = "launchButton";
			this.launchButton.Size = new System.Drawing.Size(170, 50);
			this.launchButton.TabIndex = 2;
			this.launchButton.Text = "...";
			this.launchButton.UseVisualStyleBackColor = false;
			this.launchButton.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(184, 86);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(432, 278);
			this.panel1.TabIndex = 4;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(121, 226);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(92, 34);
			this.button3.TabIndex = 2;
			this.button3.Text = "Not now";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(219, 226);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(92, 34);
			this.button2.TabIndex = 2;
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
			this.status.Location = new System.Drawing.Point(620, 24);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(170, 27);
			this.status.TabIndex = 6;
			this.status.UseVisualStyleBackColor = false;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackgroundImage = global::SwingLauncher.Properties.Resources.Screenshot__6_;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel2.Controls.Add(this.button1);
			this.panel2.Location = new System.Drawing.Point(-50, -38);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(900, 526);
			this.panel2.TabIndex = 7;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.panel3.Controls.Add(this.status);
			this.panel3.Controls.Add(this.launchButton);
			this.panel3.Location = new System.Drawing.Point(0, 375);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(800, 75);
			this.panel3.TabIndex = 8;
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
			this.button1.Location = new System.Drawing.Point(0, 217);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(900, 89);
			this.button1.TabIndex = 0;
			this.button1.Text = "Swing Course";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.updatePanel);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.updatePanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
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
	}
}

