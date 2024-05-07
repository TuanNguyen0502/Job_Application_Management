namespace Job_Application_Management
{
    partial class UC_Employer_Resume
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_University = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_detail = new Guna.UI2.WinForms.Guna2Button();
            this.label_GPA = new System.Windows.Forms.Label();
            this.label_Major = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 191);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Job_Application_Management.Properties.Resources.icons8_profile_64;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(17, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 152);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_University
            // 
            this.label_University.AutoSize = true;
            this.label_University.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_University.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(146)))));
            this.label_University.Location = new System.Drawing.Point(184, 50);
            this.label_University.Name = "label_University";
            this.label_University.Size = new System.Drawing.Size(139, 38);
            this.label_University.TabIndex = 9;
            this.label_University.Text = "University";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(29)))));
            this.label_Name.Location = new System.Drawing.Point(183, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(264, 45);
            this.label_Name.TabIndex = 8;
            this.label_Name.Text = "Candidate Name";
            // 
            // button_detail
            // 
            this.button_detail.BorderRadius = 20;
            this.button_detail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_detail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_detail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_detail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_detail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.button_detail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_detail.ForeColor = System.Drawing.Color.White;
            this.button_detail.Image = global::Job_Application_Management.Properties.Resources.icons8_detail_100;
            this.button_detail.ImageSize = new System.Drawing.Size(100, 100);
            this.button_detail.Location = new System.Drawing.Point(959, 67);
            this.button_detail.Name = "button_detail";
            this.button_detail.Size = new System.Drawing.Size(118, 109);
            this.button_detail.TabIndex = 13;
            // 
            // label_GPA
            // 
            this.label_GPA.AutoSize = true;
            this.label_GPA.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GPA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(146)))));
            this.label_GPA.Location = new System.Drawing.Point(184, 138);
            this.label_GPA.Name = "label_GPA";
            this.label_GPA.Size = new System.Drawing.Size(82, 38);
            this.label_GPA.TabIndex = 12;
            this.label_GPA.Text = "GPA: ";
            // 
            // label_Major
            // 
            this.label_Major.AutoSize = true;
            this.label_Major.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Major.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(146)))));
            this.label_Major.Location = new System.Drawing.Point(184, 94);
            this.label_Major.Name = "label_Major";
            this.label_Major.Size = new System.Drawing.Size(103, 38);
            this.label_Major.TabIndex = 11;
            this.label_Major.Text = "Major: ";
            // 
            // UC_Employer_Resume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_University);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.button_detail);
            this.Controls.Add(this.label_GPA);
            this.Controls.Add(this.label_Major);
            this.Name = "UC_Employer_Resume";
            this.Size = new System.Drawing.Size(1100, 191);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_University;
        private System.Windows.Forms.Label label_Name;
        private Guna.UI2.WinForms.Guna2Button button_detail;
        private System.Windows.Forms.Label label_GPA;
        private System.Windows.Forms.Label label_Major;
    }
}
