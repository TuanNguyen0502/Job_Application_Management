﻿namespace Job_Application_Management
{
    partial class FEmployer
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
            this.button_Infomation = new System.Windows.Forms.Button();
            this.flowLayoutPanel_Left = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_PostJob = new System.Windows.Forms.Button();
            this.button_FindCandidate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel_Center = new System.Windows.Forms.Panel();
            this.button_Home = new System.Windows.Forms.Button();
            this.button_Setting = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Infomation
            // 
            this.button_Infomation.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Infomation.Location = new System.Drawing.Point(3, 215);
            this.button_Infomation.Name = "button_Infomation";
            this.button_Infomation.Size = new System.Drawing.Size(232, 56);
            this.button_Infomation.TabIndex = 1;
            this.button_Infomation.Text = "Information";
            this.button_Infomation.UseVisualStyleBackColor = true;
            this.button_Infomation.Click += new System.EventHandler(this.button_Infomation_Click);
            // 
            // flowLayoutPanel_Left
            // 
            this.flowLayoutPanel_Left.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel_Left.Controls.Add(this.button_Home);
            this.flowLayoutPanel_Left.Controls.Add(this.button_Infomation);
            this.flowLayoutPanel_Left.Controls.Add(this.button_PostJob);
            this.flowLayoutPanel_Left.Controls.Add(this.button_FindCandidate);
            this.flowLayoutPanel_Left.Controls.Add(this.button_Setting);
            this.flowLayoutPanel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel_Left.Location = new System.Drawing.Point(0, 33);
            this.flowLayoutPanel_Left.Name = "flowLayoutPanel_Left";
            this.flowLayoutPanel_Left.Size = new System.Drawing.Size(237, 811);
            this.flowLayoutPanel_Left.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Job_Application_Management.Properties.Resources.ShakeHand;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_PostJob
            // 
            this.button_PostJob.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PostJob.Location = new System.Drawing.Point(3, 277);
            this.button_PostJob.Name = "button_PostJob";
            this.button_PostJob.Size = new System.Drawing.Size(232, 56);
            this.button_PostJob.TabIndex = 1;
            this.button_PostJob.Text = "Post Job";
            this.button_PostJob.UseVisualStyleBackColor = true;
            this.button_PostJob.Click += new System.EventHandler(this.button_PostJob_Click);
            // 
            // button_FindCandidate
            // 
            this.button_FindCandidate.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FindCandidate.Location = new System.Drawing.Point(3, 339);
            this.button_FindCandidate.Name = "button_FindCandidate";
            this.button_FindCandidate.Size = new System.Drawing.Size(232, 56);
            this.button_FindCandidate.TabIndex = 4;
            this.button_FindCandidate.Text = "Find Candidate";
            this.button_FindCandidate.UseVisualStyleBackColor = true;
            this.button_FindCandidate.Click += new System.EventHandler(this.button_FindCandidate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1032, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Employer to Job Application Management";
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.label1);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(237, 33);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1241, 100);
            this.panel_Top.TabIndex = 3;
            // 
            // panel_Center
            // 
            this.panel_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Center.Location = new System.Drawing.Point(237, 133);
            this.panel_Center.Name = "panel_Center";
            this.panel_Center.Size = new System.Drawing.Size(1241, 711);
            this.panel_Center.TabIndex = 4;
            // 
            // button_Home
            // 
            this.button_Home.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Home.Location = new System.Drawing.Point(3, 153);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(232, 56);
            this.button_Home.TabIndex = 5;
            this.button_Home.Text = "Home";
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // button_Setting
            // 
            this.button_Setting.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Setting.Location = new System.Drawing.Point(3, 401);
            this.button_Setting.Name = "button_Setting";
            this.button_Setting.Size = new System.Drawing.Size(232, 56);
            this.button_Setting.TabIndex = 6;
            this.button_Setting.Text = "Setting";
            this.button_Setting.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1478, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exiToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactInformationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contactInformationToolStripMenuItem
            // 
            this.contactInformationToolStripMenuItem.Name = "contactInformationToolStripMenuItem";
            this.contactInformationToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.contactInformationToolStripMenuItem.Text = "Contact Information";
            // 
            // exiToolStripMenuItem
            // 
            this.exiToolStripMenuItem.Name = "exiToolStripMenuItem";
            this.exiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exiToolStripMenuItem.Text = "Exit";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // FEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1478, 844);
            this.Controls.Add(this.panel_Center);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.flowLayoutPanel_Left);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FEmployer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel_Left.ResumeLayout(false);
            this.flowLayoutPanel_Left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Infomation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Left;
        private System.Windows.Forms.Button button_PostJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Center;
        private System.Windows.Forms.Button button_FindCandidate;
        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.Button button_Setting;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}