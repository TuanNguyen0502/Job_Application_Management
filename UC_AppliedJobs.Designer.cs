namespace Job_Application_Management
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
            this.lbl_PostTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblComName = new System.Windows.Forms.Label();
            this.btn_Status = new Guna.UI2.WinForms.Guna2Button();
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
            // lbl_PostTime
            // 
            this.lbl_PostTime.AutoSize = true;
            this.lbl_PostTime.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PostTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_PostTime.Location = new System.Drawing.Point(343, 111);
            this.lbl_PostTime.Name = "lbl_PostTime";
            this.lbl_PostTime.Size = new System.Drawing.Size(96, 17);
            this.lbl_PostTime.TabIndex = 10;
            this.lbl_PostTime.Text = "Thời gian đăng";
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
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btn_Status
            // 
            this.btn_Status.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_Status.BorderRadius = 20;
            this.btn_Status.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Status.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Status.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Status.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Status.FillColor = System.Drawing.Color.Silver;
            this.btn_Status.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Status.ForeColor = System.Drawing.Color.White;
            this.btn_Status.Location = new System.Drawing.Point(579, 88);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(158, 40);
            this.btn_Status.TabIndex = 13;
            this.btn_Status.Text = "Tình trạng";
            // 
            // UC_AppliedJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_Status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_PostTime);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblDescrption);
            this.Controls.Add(this.lblComName);
            this.Controls.Add(this.lblTimeSaved);
            this.Name = "UC_AppliedJobs";
            this.Size = new System.Drawing.Size(772, 147);
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
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lbl_PostTime;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_Status;
    }
}
