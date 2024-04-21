namespace Job_Application_Management
{
    partial class UC_CandidateCV
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_University = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Major = new System.Windows.Forms.Label();
            this.label_GPA = new System.Windows.Forms.Label();
            this.button_detail = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(29)))));
            this.label_Name.Location = new System.Drawing.Point(193, 10);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(269, 37);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Candidate Name";
            // 
            // label_University
            // 
            this.label_University.AutoSize = true;
            this.label_University.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_University.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(146)))));
            this.label_University.Location = new System.Drawing.Point(194, 60);
            this.label_University.Name = "label_University";
            this.label_University.Size = new System.Drawing.Size(165, 33);
            this.label_University.TabIndex = 1;
            this.label_University.Text = "University";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 171);
            this.panel1.TabIndex = 2;
            // 
            // label_Major
            // 
            this.label_Major.AutoSize = true;
            this.label_Major.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Major.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(146)))));
            this.label_Major.Location = new System.Drawing.Point(194, 104);
            this.label_Major.Name = "label_Major";
            this.label_Major.Size = new System.Drawing.Size(120, 33);
            this.label_Major.TabIndex = 5;
            this.label_Major.Text = "Major: ";
            // 
            // label_GPA
            // 
            this.label_GPA.AutoSize = true;
            this.label_GPA.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GPA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(146)))));
            this.label_GPA.Location = new System.Drawing.Point(194, 148);
            this.label_GPA.Name = "label_GPA";
            this.label_GPA.Size = new System.Drawing.Size(90, 33);
            this.label_GPA.TabIndex = 6;
            this.label_GPA.Text = "GPA: ";
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
            this.button_detail.Location = new System.Drawing.Point(1149, 72);
            this.button_detail.Name = "button_detail";
            this.button_detail.Size = new System.Drawing.Size(118, 109);
            this.button_detail.TabIndex = 7;
            this.button_detail.Click += new System.EventHandler(this.button_detail_Click);
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
            this.pictureBox1.Size = new System.Drawing.Size(141, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UC_CandidateCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.button_detail);
            this.Controls.Add(this.label_GPA);
            this.Controls.Add(this.label_Major);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_University);
            this.Controls.Add(this.label_Name);
            this.Name = "UC_CandidateCV";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1280, 191);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_University;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Major;
        private System.Windows.Forms.Label label_GPA;
        private Guna.UI2.WinForms.Guna2Button button_detail;
    }
}
