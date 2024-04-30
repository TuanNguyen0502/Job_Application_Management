namespace Job_Application_Management
{
    partial class UC_Employer_Interview
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_JobName = new System.Windows.Forms.Label();
            this.button_Show = new Guna.UI2.WinForms.Guna2Button();
            this.label_CandidateName = new System.Windows.Forms.Label();
            this.label_InterviewTime = new System.Windows.Forms.Label();
            this.label_Note = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.Controls.Add(this.label_JobName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Show, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_CandidateName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_InterviewTime, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Note, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1014, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_JobName
            // 
            this.label_JobName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_JobName.AutoSize = true;
            this.label_JobName.ForeColor = System.Drawing.Color.Black;
            this.label_JobName.Location = new System.Drawing.Point(33, 13);
            this.label_JobName.Name = "label_JobName";
            this.label_JobName.Size = new System.Drawing.Size(157, 34);
            this.label_JobName.TabIndex = 1;
            this.label_JobName.Text = "Job Name";
            this.label_JobName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Show
            // 
            this.button_Show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Show.AutoRoundedCorners = true;
            this.button_Show.BorderRadius = 17;
            this.button_Show.DefaultAutoSize = true;
            this.button_Show.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Show.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Show.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Show.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Show.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Show.ForeColor = System.Drawing.Color.White;
            this.button_Show.Location = new System.Drawing.Point(915, 12);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(76, 36);
            this.button_Show.TabIndex = 0;
            this.button_Show.Text = "Show";
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // label_CandidateName
            // 
            this.label_CandidateName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_CandidateName.AutoSize = true;
            this.label_CandidateName.ForeColor = System.Drawing.Color.Black;
            this.label_CandidateName.Location = new System.Drawing.Point(254, 0);
            this.label_CandidateName.Name = "label_CandidateName";
            this.label_CandidateName.Size = new System.Drawing.Size(161, 60);
            this.label_CandidateName.TabIndex = 1;
            this.label_CandidateName.Text = "candidate name";
            this.label_CandidateName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_InterviewTime
            // 
            this.label_InterviewTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_InterviewTime.AutoSize = true;
            this.label_InterviewTime.ForeColor = System.Drawing.Color.Black;
            this.label_InterviewTime.Location = new System.Drawing.Point(453, 13);
            this.label_InterviewTime.Name = "label_InterviewTime";
            this.label_InterviewTime.Size = new System.Drawing.Size(209, 34);
            this.label_InterviewTime.TabIndex = 1;
            this.label_InterviewTime.Text = "Interview time";
            this.label_InterviewTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Note
            // 
            this.label_Note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Note.AutoSize = true;
            this.label_Note.ForeColor = System.Drawing.Color.Black;
            this.label_Note.Location = new System.Drawing.Point(739, 13);
            this.label_Note.Name = "label_Note";
            this.label_Note.Size = new System.Drawing.Size(82, 34);
            this.label_Note.TabIndex = 1;
            this.label_Note.Text = "Note";
            this.label_Note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Employer_Interview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UC_Employer_Interview";
            this.Size = new System.Drawing.Size(1014, 60);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button button_Show;
        private System.Windows.Forms.Label label_JobName;
        private System.Windows.Forms.Label label_CandidateName;
        private System.Windows.Forms.Label label_InterviewTime;
        private System.Windows.Forms.Label label_Note;
    }
}
