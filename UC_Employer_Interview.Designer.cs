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
            this.label_CandidateName = new System.Windows.Forms.Label();
            this.label_InterviewTime = new System.Windows.Forms.Label();
            this.label_Note = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.Controls.Add(this.label_JobName, 0, 0);
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
            this.tableLayoutPanel1.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // label_JobName
            // 
            this.label_JobName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_JobName.AutoSize = true;
            this.label_JobName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_JobName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(29)))));
            this.label_JobName.Location = new System.Drawing.Point(64, 14);
            this.label_JobName.Name = "label_JobName";
            this.label_JobName.Size = new System.Drawing.Size(124, 32);
            this.label_JobName.TabIndex = 1;
            this.label_JobName.Text = "Job Name";
            this.label_JobName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_JobName.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // label_CandidateName
            // 
            this.label_CandidateName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_CandidateName.AutoSize = true;
            this.label_CandidateName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_CandidateName.ForeColor = System.Drawing.Color.Black;
            this.label_CandidateName.Location = new System.Drawing.Point(340, 14);
            this.label_CandidateName.Name = "label_CandidateName";
            this.label_CandidateName.Size = new System.Drawing.Size(78, 32);
            this.label_CandidateName.TabIndex = 1;
            this.label_CandidateName.Text = "Name";
            this.label_CandidateName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_CandidateName.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // label_InterviewTime
            // 
            this.label_InterviewTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_InterviewTime.AutoSize = true;
            this.label_InterviewTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_InterviewTime.ForeColor = System.Drawing.Color.Black;
            this.label_InterviewTime.Location = new System.Drawing.Point(549, 14);
            this.label_InterviewTime.Name = "label_InterviewTime";
            this.label_InterviewTime.Size = new System.Drawing.Size(166, 32);
            this.label_InterviewTime.TabIndex = 1;
            this.label_InterviewTime.Text = "Interview time";
            this.label_InterviewTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_InterviewTime.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // label_Note
            // 
            this.label_Note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Note.AutoSize = true;
            this.label_Note.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_Note.ForeColor = System.Drawing.Color.Black;
            this.label_Note.Location = new System.Drawing.Point(853, 14);
            this.label_Note.Name = "label_Note";
            this.label_Note.Size = new System.Drawing.Size(67, 32);
            this.label_Note.TabIndex = 1;
            this.label_Note.Text = "Note";
            this.label_Note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Note.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // UC_Employer_Interview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightCyan;
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
        private System.Windows.Forms.Label label_JobName;
        private System.Windows.Forms.Label label_CandidateName;
        private System.Windows.Forms.Label label_InterviewTime;
        private System.Windows.Forms.Label label_Note;
    }
}
