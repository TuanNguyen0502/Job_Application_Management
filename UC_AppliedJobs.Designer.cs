﻿namespace Job_Application_Management
{
    partial class UC_AppliedJobs
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
            this.lblDescrption = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblTimeSaved = new System.Windows.Forms.Label();
            this.lblTimeUpdate = new System.Windows.Forms.Label();
            this.pictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnRusbish = new System.Windows.Forms.Button();
            this.lblComName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescrption
            // 
            this.lblDescrption.AutoSize = true;
            this.lblDescrption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDescrption.Location = new System.Drawing.Point(159, 11);
            this.lblDescrption.Name = "lblDescrption";
            this.lblDescrption.Size = new System.Drawing.Size(132, 23);
            this.lblDescrption.TabIndex = 5;
            this.lblDescrption.Text = "Mô tả công việc";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSalary.Location = new System.Drawing.Point(585, 20);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(108, 28);
            this.lblSalary.TabIndex = 6;
            this.lblSalary.Text = "Mức lương";
            // 
            // lblTimeSaved
            // 
            this.lblTimeSaved.AutoSize = true;
            this.lblTimeSaved.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSaved.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTimeSaved.Location = new System.Drawing.Point(158, 81);
            this.lblTimeSaved.Name = "lblTimeSaved";
            this.lblTimeSaved.Size = new System.Drawing.Size(88, 17);
            this.lblTimeSaved.TabIndex = 3;
            this.lblTimeSaved.Text = "Thời điểm lưu";
            // 
            // lblTimeUpdate
            // 
            this.lblTimeUpdate.AutoSize = true;
            this.lblTimeUpdate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTimeUpdate.Location = new System.Drawing.Point(334, 81);
            this.lblTimeUpdate.Name = "lblTimeUpdate";
            this.lblTimeUpdate.Size = new System.Drawing.Size(116, 17);
            this.lblTimeUpdate.TabIndex = 10;
            this.lblTimeUpdate.Text = "Thời gian cập nhật";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Job_Application_Management.Properties.Resources.icons8_company_96;
            this.pictureBox1.ImageRotate = 0F;
            this.pictureBox1.Location = new System.Drawing.Point(15, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox1.Size = new System.Drawing.Size(114, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Image = global::Job_Application_Management.Properties.Resources.icons8_address_16;
            this.lblAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddress.Location = new System.Drawing.Point(159, 111);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(88, 17);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "       Địa điểm";
            // 
            // btnRusbish
            // 
            this.btnRusbish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.btnRusbish.FlatAppearance.BorderSize = 0;
            this.btnRusbish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRusbish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRusbish.Image = global::Job_Application_Management.Properties.Resources.icons8_trash_can_16;
            this.btnRusbish.Location = new System.Drawing.Point(587, 100);
            this.btnRusbish.Name = "btnRusbish";
            this.btnRusbish.Size = new System.Drawing.Size(106, 29);
            this.btnRusbish.TabIndex = 7;
            this.btnRusbish.Text = "   Bỏ lưu";
            this.btnRusbish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRusbish.UseVisualStyleBackColor = false;
            this.btnRusbish.Click += new System.EventHandler(this.btnRusbish_Click);
            // 
            // lblComName
            // 
            this.lblComName.AutoSize = true;
            this.lblComName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComName.Image = global::Job_Application_Management.Properties.Resources.icons8_company_16;
            this.lblComName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblComName.Location = new System.Drawing.Point(158, 50);
            this.lblComName.Name = "lblComName";
            this.lblComName.Size = new System.Drawing.Size(85, 17);
            this.lblComName.TabIndex = 4;
            this.lblComName.Text = "        Công ty";
            // 
            // UC_AppliedJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTimeUpdate);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnRusbish);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblDescrption);
            this.Controls.Add(this.lblComName);
            this.Controls.Add(this.lblTimeSaved);
            this.Name = "UC_AppliedJobs";
            this.Size = new System.Drawing.Size(723, 147);
            this.Load += new System.EventHandler(this.UC_AppliedJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTimeSaved;
        private System.Windows.Forms.Label lblComName;
        private System.Windows.Forms.Label lblDescrption;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnRusbish;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTimeUpdate;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox1;
    }
}