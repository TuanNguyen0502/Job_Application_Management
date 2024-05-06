namespace Job_Application_Management
{
    partial class UC_Employer_Candidate
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Hometown = new System.Windows.Forms.Label();
            this.label_University = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.tableLayoutPanel1.Controls.Add(this.label_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Phone, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Email, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Hometown, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_University, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1111, 80);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.label_Name_Click);
            // 
            // label_Name
            // 
            this.label_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(29)))));
            this.label_Name.Location = new System.Drawing.Point(3, 24);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(79, 32);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Name.Click += new System.EventHandler(this.label_Name_Click);
            // 
            // label_Phone
            // 
            this.label_Phone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_Phone.ForeColor = System.Drawing.Color.Black;
            this.label_Phone.Location = new System.Drawing.Point(169, 24);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(82, 32);
            this.label_Phone.TabIndex = 1;
            this.label_Phone.Text = "Phone";
            this.label_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Phone.Click += new System.EventHandler(this.label_Name_Click);
            // 
            // label_Email
            // 
            this.label_Email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_Email.ForeColor = System.Drawing.Color.Black;
            this.label_Email.Location = new System.Drawing.Point(313, 24);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(71, 32);
            this.label_Email.TabIndex = 1;
            this.label_Email.Text = "Email";
            this.label_Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Email.Click += new System.EventHandler(this.label_Name_Click);
            // 
            // label_Hometown
            // 
            this.label_Hometown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Hometown.AutoSize = true;
            this.label_Hometown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_Hometown.ForeColor = System.Drawing.Color.Black;
            this.label_Hometown.Location = new System.Drawing.Point(568, 24);
            this.label_Hometown.Name = "label_Hometown";
            this.label_Hometown.Size = new System.Drawing.Size(132, 32);
            this.label_Hometown.TabIndex = 1;
            this.label_Hometown.Text = "Hometown";
            this.label_Hometown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Hometown.Click += new System.EventHandler(this.label_Name_Click);
            // 
            // label_University
            // 
            this.label_University.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_University.AutoSize = true;
            this.label_University.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_University.ForeColor = System.Drawing.Color.Black;
            this.label_University.Location = new System.Drawing.Point(767, 24);
            this.label_University.Name = "label_University";
            this.label_University.Size = new System.Drawing.Size(119, 32);
            this.label_University.TabIndex = 1;
            this.label_University.Text = "University";
            this.label_University.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_University.Click += new System.EventHandler(this.label_Name_Click);
            // 
            // UC_Employer_Candidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UC_Employer_Candidate";
            this.Size = new System.Drawing.Size(1111, 80);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Hometown;
        private System.Windows.Forms.Label label_University;
    }
}
