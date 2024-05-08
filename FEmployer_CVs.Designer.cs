namespace Job_Application_Management
{
    partial class FEmployer_CVs
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
            this.button_Favorite = new Guna.UI2.WinForms.Guna2Button();
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
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1136, 630);
            this.flowLayoutPanel1.TabIndex = 10;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // button_Favorite
            // 
            this.button_Favorite.AutoRoundedCorners = true;
            this.button_Favorite.BackColor = System.Drawing.Color.Transparent;
            this.button_Favorite.BorderRadius = 24;
            this.button_Favorite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Favorite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Favorite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Favorite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Favorite.FillColor = System.Drawing.Color.Transparent;
            this.button_Favorite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Favorite.ForeColor = System.Drawing.Color.White;
            this.button_Favorite.Image = global::Job_Application_Management.Properties.Resources.icons8_heart_50;
            this.button_Favorite.ImageSize = new System.Drawing.Size(50, 50);
            this.button_Favorite.Location = new System.Drawing.Point(1073, 27);
            this.button_Favorite.Name = "button_Favorite";
            this.button_Favorite.Size = new System.Drawing.Size(50, 50);
            this.button_Favorite.TabIndex = 11;
            this.button_Favorite.UseTransparentBackground = true;
            // 
            // FEmployer_CVs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 852);
            this.Controls.Add(this.button_Favorite);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FEmployer_CVs";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "FEmployer_Resumes";
            this.Load += new System.EventHandler(this.FEmployer_Resumes_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button button_Search;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button button_Favorite;
    }
}