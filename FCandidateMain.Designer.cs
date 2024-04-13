﻿namespace Job_Application_Management
{
    partial class FCandidateMain
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Posting = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Register = new Guna.UI2.WinForms.Guna2Button();
            this.btn_JobsApplied = new Guna.UI2.WinForms.Guna2Button();
            this.btn_JobsSaved = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.lblCddID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgSlide = new System.Windows.Forms.PictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_ContainDetailsJob = new System.Windows.Forms.Panel();
            this.flp_ContainsJobs = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cbb_Address = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearchFor = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_SearchFor = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            this.pnl_Main.SuspendLayout();
            this.panel3.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Posting);
            this.panel1.Controls.Add(this.btn_Register);
            this.panel1.Controls.Add(this.btn_JobsApplied);
            this.panel1.Controls.Add(this.btn_JobsSaved);
            this.panel1.Controls.Add(this.btn_Dashboard);
            this.panel1.Controls.Add(this.lblCddID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.imgSlide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 759);
            this.panel1.TabIndex = 0;
            // 
            // btn_Posting
            // 
            this.btn_Posting.BackColor = System.Drawing.Color.Transparent;
            this.btn_Posting.BorderRadius = 22;
            this.btn_Posting.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Posting.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_Posting.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_Posting.CheckedState.Image = global::Job_Application_Management.Properties.Resources.icons8_job_seeker_32__1_;
            this.btn_Posting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Posting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Posting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Posting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Posting.FillColor = System.Drawing.Color.Transparent;
            this.btn_Posting.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Posting.ForeColor = System.Drawing.Color.White;
            this.btn_Posting.Image = global::Job_Application_Management.Properties.Resources.icons8_job_seeker_32;
            this.btn_Posting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Posting.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Posting.Location = new System.Drawing.Point(14, 527);
            this.btn_Posting.Name = "btn_Posting";
            this.btn_Posting.Size = new System.Drawing.Size(191, 62);
            this.btn_Posting.TabIndex = 6;
            this.btn_Posting.Text = "Job Posting";
            this.btn_Posting.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_Posting.UseTransparentBackground = true;
            this.btn_Posting.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.btn_Posting.Click += new System.EventHandler(this.btn_Posting_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.Transparent;
            this.btn_Register.BorderRadius = 22;
            this.btn_Register.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Register.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_Register.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_Register.CheckedState.Image = global::Job_Application_Management.Properties.Resources.icons8_register_32__1_;
            this.btn_Register.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Register.FillColor = System.Drawing.Color.Transparent;
            this.btn_Register.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.Image = global::Job_Application_Management.Properties.Resources.icons8_register_32;
            this.btn_Register.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Register.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Register.Location = new System.Drawing.Point(14, 437);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(191, 62);
            this.btn_Register.TabIndex = 5;
            this.btn_Register.Text = "Register CV";
            this.btn_Register.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_Register.UseTransparentBackground = true;
            this.btn_Register.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_JobsApplied
            // 
            this.btn_JobsApplied.BackColor = System.Drawing.Color.Transparent;
            this.btn_JobsApplied.BorderRadius = 22;
            this.btn_JobsApplied.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_JobsApplied.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_JobsApplied.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_JobsApplied.CheckedState.Image = global::Job_Application_Management.Properties.Resources.icons8_job_application_32;
            this.btn_JobsApplied.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_JobsApplied.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_JobsApplied.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_JobsApplied.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_JobsApplied.FillColor = System.Drawing.Color.Transparent;
            this.btn_JobsApplied.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JobsApplied.ForeColor = System.Drawing.Color.White;
            this.btn_JobsApplied.Image = global::Job_Application_Management.Properties.Resources.icons8_job_application_323;
            this.btn_JobsApplied.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_JobsApplied.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_JobsApplied.Location = new System.Drawing.Point(14, 347);
            this.btn_JobsApplied.Name = "btn_JobsApplied";
            this.btn_JobsApplied.Size = new System.Drawing.Size(191, 62);
            this.btn_JobsApplied.TabIndex = 4;
            this.btn_JobsApplied.Text = "Jobs Applied";
            this.btn_JobsApplied.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_JobsApplied.UseTransparentBackground = true;
            this.btn_JobsApplied.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.btn_JobsApplied.Click += new System.EventHandler(this.btn_JobsApplied_Click);
            // 
            // btn_JobsSaved
            // 
            this.btn_JobsSaved.BackColor = System.Drawing.Color.Transparent;
            this.btn_JobsSaved.BorderRadius = 22;
            this.btn_JobsSaved.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_JobsSaved.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_JobsSaved.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_JobsSaved.CheckedState.Image = global::Job_Application_Management.Properties.Resources.icons8_check_file_321;
            this.btn_JobsSaved.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_JobsSaved.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_JobsSaved.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_JobsSaved.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_JobsSaved.FillColor = System.Drawing.Color.Transparent;
            this.btn_JobsSaved.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_JobsSaved.ForeColor = System.Drawing.Color.White;
            this.btn_JobsSaved.Image = global::Job_Application_Management.Properties.Resources.icons8_check_file_32;
            this.btn_JobsSaved.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_JobsSaved.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_JobsSaved.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_JobsSaved.Location = new System.Drawing.Point(14, 257);
            this.btn_JobsSaved.Name = "btn_JobsSaved";
            this.btn_JobsSaved.Size = new System.Drawing.Size(191, 62);
            this.btn_JobsSaved.TabIndex = 3;
            this.btn_JobsSaved.Text = "Jobs Saved";
            this.btn_JobsSaved.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_JobsSaved.UseTransparentBackground = true;
            this.btn_JobsSaved.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.btn_JobsSaved.Click += new System.EventHandler(this.btn_JobsSaved_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_Dashboard.BorderRadius = 22;
            this.btn_Dashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Dashboard.Checked = true;
            this.btn_Dashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_Dashboard.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_Dashboard.CheckedState.Image = global::Job_Application_Management.Properties.Resources.icons8_home_30;
            this.btn_Dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Dashboard.FillColor = System.Drawing.Color.Transparent;
            this.btn_Dashboard.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_Dashboard.Image = global::Job_Application_Management.Properties.Resources.icons8_home_302;
            this.btn_Dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Dashboard.ImageOffset = new System.Drawing.Point(7, 0);
            this.btn_Dashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Dashboard.Location = new System.Drawing.Point(14, 167);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(191, 62);
            this.btn_Dashboard.TabIndex = 1;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.TextOffset = new System.Drawing.Point(12, 0);
            this.btn_Dashboard.UseTransparentBackground = true;
            this.btn_Dashboard.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // lblCddID
            // 
            this.lblCddID.AutoSize = true;
            this.lblCddID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCddID.ForeColor = System.Drawing.Color.Transparent;
            this.lblCddID.Location = new System.Drawing.Point(82, 48);
            this.lblCddID.Name = "lblCddID";
            this.lblCddID.Size = new System.Drawing.Size(76, 19);
            this.lblCddID.TabIndex = 2;
            this.lblCddID.Text = "CDD001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(82, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên ứng viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Job_Application_Management.Properties.Resources.icons8_employee_80;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imgSlide
            // 
            this.imgSlide.BackColor = System.Drawing.Color.Transparent;
            this.imgSlide.Image = global::Job_Application_Management.Properties.Resources.New_Project__3_;
            this.imgSlide.Location = new System.Drawing.Point(163, 123);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(101, 146);
            this.imgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlide.TabIndex = 1;
            this.imgSlide.TabStop = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 0;
            this.gunaElipse1.TargetControl = this;
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.Controls.Add(this.pnl_ContainDetailsJob);
            this.pnl_Main.Controls.Add(this.flp_ContainsJobs);
            this.pnl_Main.Controls.Add(this.panel3);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(235, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1296, 759);
            this.pnl_Main.TabIndex = 2;
            // 
            // pnl_ContainDetailsJob
            // 
            this.pnl_ContainDetailsJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ContainDetailsJob.Location = new System.Drawing.Point(464, 120);
            this.pnl_ContainDetailsJob.Name = "pnl_ContainDetailsJob";
            this.pnl_ContainDetailsJob.Size = new System.Drawing.Size(832, 639);
            this.pnl_ContainDetailsJob.TabIndex = 3;
            // 
            // flp_ContainsJobs
            // 
            this.flp_ContainsJobs.AutoScroll = true;
            this.flp_ContainsJobs.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp_ContainsJobs.Location = new System.Drawing.Point(0, 120);
            this.flp_ContainsJobs.Name = "flp_ContainsJobs";
            this.flp_ContainsJobs.Size = new System.Drawing.Size(464, 639);
            this.flp_ContainsJobs.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2ShadowPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1296, 120);
            this.panel3.TabIndex = 1;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.pictureBox2);
            this.guna2ShadowPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2ShadowPanel1.Controls.Add(this.pictureBox3);
            this.guna2ShadowPanel1.Controls.Add(this.cbb_Address);
            this.guna2ShadowPanel1.Controls.Add(this.btnSearchFor);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.guna2ComboBox2);
            this.guna2ShadowPanel1.Controls.Add(this.txt_SearchFor);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(3, 2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1290, 118);
            this.guna2ShadowPanel1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.Image = global::Job_Application_Management.Properties.Resources.icons8_instagram_24;
            this.pictureBox2.Location = new System.Drawing.Point(1016, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.Gray;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.Silver;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Silver;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1236, 10);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox3.Image = global::Job_Application_Management.Properties.Resources.icons8_facebook_16;
            this.pictureBox3.Location = new System.Drawing.Point(1050, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // cbb_Address
            // 
            this.cbb_Address.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Address.BorderRadius = 4;
            this.cbb_Address.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbb_Address.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Address.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Address.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Address.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Address.ItemHeight = 30;
            this.cbb_Address.Items.AddRange(new object[] {
            "Tất cả tỉnh/thành phố",
            "Hồ Chí Minh",
            "Hà Nội",
            "Đà Nẵng",
            "Bình Dương",
            "Bắc Ninh",
            "Đồng Nai",
            "Hưng Yên",
            "Hải Dương",
            "Hải Phòng",
            "An Giang",
            "Bà Rịa-Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bến Tre",
            "Bình Định",
            "Bình Thuận",
            "Bình Phước",
            "Cà Mau ",
            "Cần Thơ",
            "Quảng Bình",
            "Nước Ngoài"});
            this.cbb_Address.Location = new System.Drawing.Point(405, 20);
            this.cbb_Address.Name = "cbb_Address";
            this.cbb_Address.Size = new System.Drawing.Size(246, 36);
            this.cbb_Address.TabIndex = 7;
            this.cbb_Address.SelectedIndexChanged += new System.EventHandler(this.cbb_Address_SelectedIndexChanged);
            // 
            // btnSearchFor
            // 
            this.btnSearchFor.BorderRadius = 20;
            this.btnSearchFor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchFor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchFor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchFor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchFor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchFor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchFor.ForeColor = System.Drawing.Color.White;
            this.btnSearchFor.Location = new System.Drawing.Point(237, 65);
            this.btnSearchFor.Name = "btnSearchFor";
            this.btnSearchFor.Size = new System.Drawing.Size(180, 42);
            this.btnSearchFor.TabIndex = 6;
            this.btnSearchFor.Text = "Tìm kiếm";
            this.btnSearchFor.Click += new System.EventHandler(this.btnSearchFor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tìm kiếm việc làm tại đây";
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderRadius = 4;
            this.guna2ComboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Location = new System.Drawing.Point(673, 20);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(246, 36);
            this.guna2ComboBox2.TabIndex = 8;
            // 
            // txt_SearchFor
            // 
            this.txt_SearchFor.BorderRadius = 20;
            this.txt_SearchFor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchFor.DefaultText = "";
            this.txt_SearchFor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SearchFor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SearchFor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchFor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchFor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchFor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SearchFor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchFor.IconLeft = global::Job_Application_Management.Properties.Resources.icons8_search_50;
            this.txt_SearchFor.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txt_SearchFor.IconLeftSize = new System.Drawing.Size(22, 22);
            this.txt_SearchFor.Location = new System.Drawing.Point(14, 14);
            this.txt_SearchFor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SearchFor.Name = "txt_SearchFor";
            this.txt_SearchFor.PasswordChar = '\0';
            this.txt_SearchFor.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txt_SearchFor.PlaceholderText = "Search a keyword";
            this.txt_SearchFor.SelectedText = "";
            this.txt_SearchFor.Size = new System.Drawing.Size(367, 45);
            this.txt_SearchFor.TabIndex = 3;
            // 
            // FCandidateMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1531, 759);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FCandidateMain";
            this.Text = "FCandidateMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FCandidateMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            this.pnl_Main.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label lblCddID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_Dashboard;
        private System.Windows.Forms.PictureBox imgSlide;
        private Guna.UI2.WinForms.Guna2Button btn_Posting;
        private Guna.UI2.WinForms.Guna2Button btn_Register;
        private Guna.UI2.WinForms.Guna2Button btn_JobsApplied;
        private Guna.UI2.WinForms.Guna2Button btn_JobsSaved;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2Button btnSearchFor;
        private Guna.UI2.WinForms.Guna2TextBox txt_SearchFor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flp_ContainsJobs;
        private System.Windows.Forms.Panel pnl_ContainDetailsJob;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Address;
    }
}