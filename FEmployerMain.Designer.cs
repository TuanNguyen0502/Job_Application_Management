﻿namespace Job_Application_Management
{
    partial class FEmployerMain
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
            this.panel_Left = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.imgSlide = new System.Windows.Forms.PictureBox();
            this.button_Logout = new Guna.UI2.WinForms.Guna2Button();
            this.button_FindCandidate = new Guna.UI2.WinForms.Guna2Button();
            this.button_Job = new Guna.UI2.WinForms.Guna2Button();
            this.button_Information = new Guna.UI2.WinForms.Guna2Button();
            this.button_Home = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_Center = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Left
            // 
            this.panel_Left.Controls.Add(this.imgSlide);
            this.panel_Left.Controls.Add(this.button_Logout);
            this.panel_Left.Controls.Add(this.button_FindCandidate);
            this.panel_Left.Controls.Add(this.button_Job);
            this.panel_Left.Controls.Add(this.button_Information);
            this.panel_Left.Controls.Add(this.button_Home);
            this.panel_Left.Controls.Add(this.gunaLabel1);
            this.panel_Left.Controls.Add(this.guna2PictureBox1);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(206, 660);
            this.panel_Left.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(82, 12);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(122, 32);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Employer";
            // 
            // imgSlide
            // 
            this.imgSlide.BackColor = System.Drawing.Color.Transparent;
            this.imgSlide.Image = global::Job_Application_Management.Properties.Resources.New_Project__3_;
            this.imgSlide.Location = new System.Drawing.Point(151, 74);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(57, 146);
            this.imgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlide.TabIndex = 2;
            this.imgSlide.TabStop = false;
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.Color.Transparent;
            this.button_Logout.BorderRadius = 22;
            this.button_Logout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.button_Logout.CheckedState.FillColor = System.Drawing.Color.White;
            this.button_Logout.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.button_Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Logout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.button_Logout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button_Logout.ForeColor = System.Drawing.Color.White;
            this.button_Logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button_Logout.ImageOffset = new System.Drawing.Point(10, 0);
            this.button_Logout.Location = new System.Drawing.Point(10, 550);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(194, 62);
            this.button_Logout.TabIndex = 1;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseTransparentBackground = true;
            this.button_Logout.CheckedChanged += new System.EventHandler(this.button_Home_CheckedChanged);
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // button_FindCandidate
            // 
            this.button_FindCandidate.BackColor = System.Drawing.Color.Transparent;
            this.button_FindCandidate.BorderRadius = 22;
            this.button_FindCandidate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.button_FindCandidate.CheckedState.FillColor = System.Drawing.Color.White;
            this.button_FindCandidate.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.button_FindCandidate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_FindCandidate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_FindCandidate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_FindCandidate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_FindCandidate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.button_FindCandidate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button_FindCandidate.ForeColor = System.Drawing.Color.White;
            this.button_FindCandidate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button_FindCandidate.ImageOffset = new System.Drawing.Point(10, 0);
            this.button_FindCandidate.Location = new System.Drawing.Point(10, 442);
            this.button_FindCandidate.Name = "button_FindCandidate";
            this.button_FindCandidate.Size = new System.Drawing.Size(194, 62);
            this.button_FindCandidate.TabIndex = 1;
            this.button_FindCandidate.Text = "Find";
            this.button_FindCandidate.UseTransparentBackground = true;
            this.button_FindCandidate.CheckedChanged += new System.EventHandler(this.button_Home_CheckedChanged);
            this.button_FindCandidate.Click += new System.EventHandler(this.button_FindCandidate_Click);
            // 
            // button_Job
            // 
            this.button_Job.BackColor = System.Drawing.Color.Transparent;
            this.button_Job.BorderRadius = 22;
            this.button_Job.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.button_Job.CheckedState.FillColor = System.Drawing.Color.White;
            this.button_Job.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.button_Job.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Job.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Job.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Job.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Job.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.button_Job.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button_Job.ForeColor = System.Drawing.Color.White;
            this.button_Job.Image = global::Job_Application_Management.Properties.Resources.icons8_job_30;
            this.button_Job.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button_Job.ImageOffset = new System.Drawing.Point(10, 0);
            this.button_Job.Location = new System.Drawing.Point(10, 334);
            this.button_Job.Name = "button_Job";
            this.button_Job.Size = new System.Drawing.Size(194, 62);
            this.button_Job.TabIndex = 1;
            this.button_Job.Text = "Job";
            this.button_Job.UseTransparentBackground = true;
            this.button_Job.CheckedChanged += new System.EventHandler(this.button_Home_CheckedChanged);
            this.button_Job.Click += new System.EventHandler(this.button_Job_Click);
            // 
            // button_Information
            // 
            this.button_Information.BackColor = System.Drawing.Color.Transparent;
            this.button_Information.BorderRadius = 22;
            this.button_Information.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.button_Information.CheckedState.FillColor = System.Drawing.Color.White;
            this.button_Information.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.button_Information.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Information.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Information.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Information.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Information.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.button_Information.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button_Information.ForeColor = System.Drawing.Color.White;
            this.button_Information.Image = global::Job_Application_Management.Properties.Resources.icons8_information_30;
            this.button_Information.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button_Information.ImageOffset = new System.Drawing.Point(10, 0);
            this.button_Information.Location = new System.Drawing.Point(10, 226);
            this.button_Information.Name = "button_Information";
            this.button_Information.Size = new System.Drawing.Size(194, 62);
            this.button_Information.TabIndex = 1;
            this.button_Information.Text = "Information";
            this.button_Information.UseTransparentBackground = true;
            this.button_Information.CheckedChanged += new System.EventHandler(this.button_Home_CheckedChanged);
            this.button_Information.Click += new System.EventHandler(this.button_Information_Click);
            // 
            // button_Home
            // 
            this.button_Home.BackColor = System.Drawing.Color.Transparent;
            this.button_Home.BorderRadius = 22;
            this.button_Home.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.button_Home.Checked = true;
            this.button_Home.CheckedState.FillColor = System.Drawing.Color.White;
            this.button_Home.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.button_Home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.button_Home.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button_Home.ForeColor = System.Drawing.Color.White;
            this.button_Home.Image = global::Job_Application_Management.Properties.Resources.icons8_home_303;
            this.button_Home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button_Home.ImageOffset = new System.Drawing.Point(10, 0);
            this.button_Home.Location = new System.Drawing.Point(10, 118);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(194, 62);
            this.button_Home.TabIndex = 1;
            this.button_Home.Text = "Home";
            this.button_Home.UseTransparentBackground = true;
            this.button_Home.CheckedChanged += new System.EventHandler(this.button_Home_CheckedChanged);
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Job_Application_Management.Properties.Resources.icons8_employer_64;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // panel_Center
            // 
            this.panel_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Center.FillColor = System.Drawing.Color.White;
            this.panel_Center.Location = new System.Drawing.Point(206, 0);
            this.panel_Center.Name = "panel_Center";
            this.panel_Center.Size = new System.Drawing.Size(1060, 660);
            this.panel_Center.TabIndex = 1;
            // 
            // FEmployerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1266, 660);
            this.Controls.Add(this.panel_Center);
            this.Controls.Add(this.panel_Left);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FEmployerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployerMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_Left.ResumeLayout(false);
            this.panel_Left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_Left;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button button_Home;
        private System.Windows.Forms.PictureBox imgSlide;
        private Guna.UI2.WinForms.Guna2Button button_Information;
        private Guna.UI2.WinForms.Guna2Button button_Job;
        private Guna.UI2.WinForms.Guna2Button button_FindCandidate;
        private Guna.UI2.WinForms.Guna2Button button_Logout;
        private Guna.UI2.WinForms.Guna2Panel panel_Center;
    }
}