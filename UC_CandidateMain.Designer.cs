﻿namespace Job_Application_Management
{
    partial class UC_CandidateMain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblJobName = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cptb_company = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaLinePanel_Selected = new Guna.UI.WinForms.GunaLinePanel();
            ((System.ComponentModel.ISupportInitialize)(this.cptb_company)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName.Location = new System.Drawing.Point(167, 19);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(99, 20);
            this.lblJobName.TabIndex = 1;
            this.lblJobName.Text = "Tên công việc";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(167, 57);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(85, 20);
            this.lblCompanyName.TabIndex = 2;
            this.lblCompanyName.Text = "Tên công ty";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(166, 97);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(81, 20);
            this.lblSalary.TabIndex = 3;
            this.lblSalary.Text = "Mức lương";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblAdress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(322, 99);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(70, 20);
            this.lblAdress.TabIndex = 4;
            this.lblAdress.Text = "Địa điểm";
            // 
            // btnApply
            // 
            this.btnApply.Image = global::Job_Application_Management.Properties.Resources.icons8_heart_16;
            this.btnApply.Location = new System.Drawing.Point(492, 93);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(60, 30);
            this.btnApply.TabIndex = 5;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // cptb_company
            // 
            this.cptb_company.BaseColor = System.Drawing.Color.White;
            this.cptb_company.Image = global::Job_Application_Management.Properties.Resources.icons8_company_100;
            this.cptb_company.Location = new System.Drawing.Point(20, 19);
            this.cptb_company.Name = "cptb_company";
            this.cptb_company.Size = new System.Drawing.Size(100, 100);
            this.cptb_company.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cptb_company.TabIndex = 8;
            this.cptb_company.TabStop = false;
            this.cptb_company.UseTransfarantBackground = false;
            // 
            // gunaLinePanel_Selected
            // 
            this.gunaLinePanel_Selected.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinePanel_Selected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel_Selected.ForeColor = System.Drawing.Color.PaleGreen;
            this.gunaLinePanel_Selected.LineBottom = 4;
            this.gunaLinePanel_Selected.LineColor = System.Drawing.Color.LightSeaGreen;
            this.gunaLinePanel_Selected.LineLeft = 4;
            this.gunaLinePanel_Selected.LineRight = 4;
            this.gunaLinePanel_Selected.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel_Selected.LineTop = 4;
            this.gunaLinePanel_Selected.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel_Selected.Name = "gunaLinePanel_Selected";
            this.gunaLinePanel_Selected.Padding = new System.Windows.Forms.Padding(3);
            this.gunaLinePanel_Selected.Size = new System.Drawing.Size(572, 142);
            this.gunaLinePanel_Selected.TabIndex = 9;
            // 
            // UC_CandidateMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cptb_company);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.gunaLinePanel_Selected);
            this.Name = "UC_CandidateMain";
            this.Size = new System.Drawing.Size(572, 142);
            this.Click += new System.EventHandler(this.UC_CandidateMain_Click);
            ((System.ComponentModel.ISupportInitialize)(this.cptb_company)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Button btnApply;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI.WinForms.GunaCirclePictureBox cptb_company;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel_Selected;
    }
}
