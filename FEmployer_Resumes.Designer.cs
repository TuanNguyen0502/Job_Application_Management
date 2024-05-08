namespace Job_Application_Management
{
    partial class FEmployer_Resumes
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
            this.button_Search = new Guna.UI2.WinForms.Guna2Button();
            this.textBox_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Favourite = new Guna.UI2.WinForms.Guna2Button();
            this.uC_Employer_Resume1 = new Job_Application_Management.UC_Employer_Resume();
            this.uC_Employer_Resume2 = new Job_Application_Management.UC_Employer_Resume();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Search
            // 
            this.button_Search.AutoRoundedCorners = true;
            this.button_Search.BorderRadius = 22;
            this.button_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Location = new System.Drawing.Point(909, 27);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(133, 46);
            this.button_Search.TabIndex = 8;
            this.button_Search.Text = "Search";
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.AutoRoundedCorners = true;
            this.textBox_Search.BorderRadius = 22;
            this.textBox_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Search.DefaultText = "";
            this.textBox_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Search.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBox_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Search.Location = new System.Drawing.Point(27, 27);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.PasswordChar = '\0';
            this.textBox_Search.PlaceholderText = "Type your keyword here";
            this.textBox_Search.SelectedText = "";
            this.textBox_Search.Size = new System.Drawing.Size(872, 46);
            this.textBox_Search.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.uC_Employer_Resume1);
            this.flowLayoutPanel1.Controls.Add(this.uC_Employer_Resume2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1110, 560);
            this.flowLayoutPanel1.TabIndex = 10;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // button_Favourite
            // 
            this.button_Favourite.AutoRoundedCorners = true;
            this.button_Favourite.BackColor = System.Drawing.Color.Transparent;
            this.button_Favourite.BorderRadius = 24;
            this.button_Favourite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Favourite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Favourite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Favourite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Favourite.FillColor = System.Drawing.Color.Transparent;
            this.button_Favourite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Favourite.ForeColor = System.Drawing.Color.White;
            this.button_Favourite.Image = global::Job_Application_Management.Properties.Resources.icons8_heart_50;
            this.button_Favourite.ImageSize = new System.Drawing.Size(50, 50);
            this.button_Favourite.Location = new System.Drawing.Point(1073, 27);
            this.button_Favourite.Name = "button_Favourite";
            this.button_Favourite.Size = new System.Drawing.Size(50, 50);
            this.button_Favourite.TabIndex = 11;
            this.button_Favourite.UseTransparentBackground = true;
            // 
            // uC_Employer_Resume1
            // 
            this.uC_Employer_Resume1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.uC_Employer_Resume1.Location = new System.Drawing.Point(3, 3);
            this.uC_Employer_Resume1.Name = "uC_Employer_Resume1";
            this.uC_Employer_Resume1.Size = new System.Drawing.Size(1100, 191);
            this.uC_Employer_Resume1.TabIndex = 0;
            // 
            // uC_Employer_Resume2
            // 
            this.uC_Employer_Resume2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.uC_Employer_Resume2.Location = new System.Drawing.Point(3, 200);
            this.uC_Employer_Resume2.Name = "uC_Employer_Resume2";
            this.uC_Employer_Resume2.Size = new System.Drawing.Size(1100, 191);
            this.uC_Employer_Resume2.TabIndex = 1;
            // 
            // FEmployer_Resumes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 663);
            this.Controls.Add(this.button_Favourite);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FEmployer_Resumes";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "FEmployer_Resumes";
            this.Load += new System.EventHandler(this.FEmployer_Resumes_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button button_Search;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button button_Favourite;
        private UC_Employer_Resume uC_Employer_Resume1;
        private UC_Employer_Resume uC_Employer_Resume2;
    }
}