namespace Job_Application_Management
{
    partial class FEmployer_Interview
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dateTimePicker_Time = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePicker_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.textBox_Note = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_Invite = new Guna.UI2.WinForms.Guna2Button();
            this.button_Update = new Guna.UI2.WinForms.Guna2Button();
            this.button_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Job = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(29)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20);
            this.label1.Size = new System.Drawing.Size(709, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employers must schedule interview for candidate";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.07614F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.92386F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Note, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 98);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1471, 316);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Image = global::Job_Application_Management.Properties.Resources.icons8_interview_64;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 120);
            this.label2.TabIndex = 0;
            this.label2.Text = "Interview Time     ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Image = global::Job_Application_Management.Properties.Resources.icons8_note_64;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(23, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 120);
            this.label3.TabIndex = 1;
            this.label3.Text = "Note     ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel1.Controls.Add(this.dateTimePicker_Time);
            this.guna2Panel1.Controls.Add(this.dateTimePicker_Date);
            this.guna2Panel1.Location = new System.Drawing.Point(421, 29);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Size = new System.Drawing.Size(1042, 100);
            this.guna2Panel1.TabIndex = 2;
            // 
            // dateTimePicker_Time
            // 
            this.dateTimePicker_Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_Time.AutoRoundedCorners = true;
            this.dateTimePicker_Time.BorderRadius = 36;
            this.dateTimePicker_Time.Checked = true;
            this.dateTimePicker_Time.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dateTimePicker_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_Time.Location = new System.Drawing.Point(385, 13);
            this.dateTimePicker_Time.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_Time.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_Time.Name = "dateTimePicker_Time";
            this.dateTimePicker_Time.Padding = new System.Windows.Forms.Padding(5);
            this.dateTimePicker_Time.ShowUpDown = true;
            this.dateTimePicker_Time.Size = new System.Drawing.Size(235, 74);
            this.dateTimePicker_Time.TabIndex = 2;
            this.dateTimePicker_Time.Value = new System.DateTime(2024, 4, 21, 10, 48, 41, 0);
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_Date.AutoRoundedCorners = true;
            this.dateTimePicker_Date.BorderRadius = 36;
            this.dateTimePicker_Date.Checked = true;
            this.dateTimePicker_Date.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dateTimePicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Date.Location = new System.Drawing.Point(139, 13);
            this.dateTimePicker_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Padding = new System.Windows.Forms.Padding(5);
            this.dateTimePicker_Date.Size = new System.Drawing.Size(201, 74);
            this.dateTimePicker_Date.TabIndex = 2;
            this.dateTimePicker_Date.Value = new System.DateTime(2024, 4, 21, 10, 49, 47, 567);
            // 
            // textBox_Note
            // 
            this.textBox_Note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Note.AutoScroll = true;
            this.textBox_Note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Note.DefaultText = "";
            this.textBox_Note.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Note.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Note.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Note.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Note.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Note.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBox_Note.ForeColor = System.Drawing.Color.Black;
            this.textBox_Note.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Note.Location = new System.Drawing.Point(420, 165);
            this.textBox_Note.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_Note.Multiline = true;
            this.textBox_Note.Name = "textBox_Note";
            this.textBox_Note.Padding = new System.Windows.Forms.Padding(5);
            this.textBox_Note.PasswordChar = '\0';
            this.textBox_Note.PlaceholderText = "Write your note to candidate here";
            this.textBox_Note.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Note.SelectedText = "";
            this.textBox_Note.Size = new System.Drawing.Size(1044, 144);
            this.textBox_Note.TabIndex = 3;
            // 
            // button_Invite
            // 
            this.button_Invite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Invite.BorderRadius = 20;
            this.button_Invite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Invite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Invite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Invite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Invite.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Invite.ForeColor = System.Drawing.Color.White;
            this.button_Invite.Image = global::Job_Application_Management.Properties.Resources.icons8_invite_64;
            this.button_Invite.ImageSize = new System.Drawing.Size(64, 64);
            this.button_Invite.Location = new System.Drawing.Point(8, 7);
            this.button_Invite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Invite.Name = "button_Invite";
            this.button_Invite.Size = new System.Drawing.Size(227, 84);
            this.button_Invite.TabIndex = 2;
            this.button_Invite.Text = "    Invite ";
            this.button_Invite.Click += new System.EventHandler(this.button_Invite_Click);
            // 
            // button_Update
            // 
            this.button_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Update.BorderRadius = 20;
            this.button_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Update.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ForeColor = System.Drawing.Color.White;
            this.button_Update.Image = global::Job_Application_Management.Properties.Resources.icons8_invite_64;
            this.button_Update.ImageSize = new System.Drawing.Size(64, 64);
            this.button_Update.Location = new System.Drawing.Point(241, 7);
            this.button_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(227, 84);
            this.button_Update.TabIndex = 3;
            this.button_Update.Text = "    Update";
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BorderRadius = 20;
            this.button_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Image = global::Job_Application_Management.Properties.Resources.icons8_delete_64;
            this.button_Delete.ImageSize = new System.Drawing.Size(64, 64);
            this.button_Delete.Location = new System.Drawing.Point(474, 7);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(227, 84);
            this.button_Delete.TabIndex = 4;
            this.button_Delete.Text = "    Delete";
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label_Job);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 414);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1471, 100);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label_Job
            // 
            this.label_Job.AutoSize = true;
            this.label_Job.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Job.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(29)))));
            this.label_Job.Location = new System.Drawing.Point(8, 5);
            this.label_Job.Name = "label_Job";
            this.label_Job.Padding = new System.Windows.Forms.Padding(20);
            this.label_Job.Size = new System.Drawing.Size(102, 78);
            this.label_Job.TabIndex = 0;
            this.label_Job.Text = "Job";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button_Invite);
            this.flowLayoutPanel2.Controls.Add(this.button_Update);
            this.flowLayoutPanel2.Controls.Add(this.button_Delete);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(20, 514);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1471, 100);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // FEmployer_Interview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1511, 727);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FEmployer_Interview";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FEmployer_Interview_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker_Time;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker_Date;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Note;
        private Guna.UI2.WinForms.Guna2Button button_Invite;
        private Guna.UI2.WinForms.Guna2Button button_Update;
        private Guna.UI2.WinForms.Guna2Button button_Delete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_Job;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}