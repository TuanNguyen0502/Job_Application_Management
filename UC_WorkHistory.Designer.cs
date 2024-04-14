namespace Job_Application_Management
{
    partial class UC_WorkHistory
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
            this.txt_CddName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_CompanyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtp_Start = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_End = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CddName
            // 
            this.txt_CddName.BorderRadius = 20;
            this.txt_CddName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CddName.DefaultText = "";
            this.txt_CddName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CddName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CddName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CddName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CddName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CddName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CddName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CddName.Location = new System.Drawing.Point(129, 13);
            this.txt_CddName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CddName.Name = "txt_CddName";
            this.txt_CddName.PasswordChar = '\0';
            this.txt_CddName.PlaceholderText = "Tên ứng viên";
            this.txt_CddName.SelectedText = "";
            this.txt_CddName.Size = new System.Drawing.Size(267, 48);
            this.txt_CddName.TabIndex = 1;
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.BorderRadius = 20;
            this.txt_CompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CompanyName.DefaultText = "";
            this.txt_CompanyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CompanyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CompanyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CompanyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CompanyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CompanyName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CompanyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CompanyName.Location = new System.Drawing.Point(406, 13);
            this.txt_CompanyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.PasswordChar = '\0';
            this.txt_CompanyName.PlaceholderText = "Tên công ty đã làm";
            this.txt_CompanyName.SelectedText = "";
            this.txt_CompanyName.Size = new System.Drawing.Size(333, 48);
            this.txt_CompanyName.TabIndex = 2;
            // 
            // dtp_Start
            // 
            this.dtp_Start.Checked = true;
            this.dtp_Start.FillColor = System.Drawing.Color.White;
            this.dtp_Start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_Start.Location = new System.Drawing.Point(196, 68);
            this.dtp_Start.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Start.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(200, 36);
            this.dtp_Start.TabIndex = 3;
            this.dtp_Start.Value = new System.DateTime(2024, 4, 14, 9, 10, 17, 324);
            // 
            // dtp_End
            // 
            this.dtp_End.Checked = true;
            this.dtp_End.FillColor = System.Drawing.Color.White;
            this.dtp_End.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_End.Location = new System.Drawing.Point(539, 68);
            this.dtp_End.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_End.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(200, 36);
            this.dtp_End.TabIndex = 4;
            this.dtp_End.Value = new System.DateTime(2024, 4, 14, 9, 10, 17, 324);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày kết thúc";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Job_Application_Management.Properties.Resources.icons8_work_50__1_;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(20, 13);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(84, 70);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_WorkHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_End);
            this.Controls.Add(this.dtp_Start);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.txt_CddName);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Name = "UC_WorkHistory";
            this.Size = new System.Drawing.Size(750, 120);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_CddName;
        private Guna.UI2.WinForms.Guna2TextBox txt_CompanyName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Start;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
