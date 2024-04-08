namespace Job_Application_Management
{
    partial class UC_JobsSaved
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRusbish = new System.Windows.Forms.Button();
            this.lblComName = new System.Windows.Forms.Label();
            this.lblTimeSaved = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTimeUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescrption
            // 
            this.lblDescrption.AutoSize = true;
            this.lblDescrption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDescrption.Location = new System.Drawing.Point(178, 22);
            this.lblDescrption.Name = "lblDescrption";
            this.lblDescrption.Size = new System.Drawing.Size(101, 16);
            this.lblDescrption.TabIndex = 5;
            this.lblDescrption.Text = "Mô tả công việc";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSalary.Location = new System.Drawing.Point(651, 22);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(68, 16);
            this.lblSalary.TabIndex = 6;
            this.lblSalary.Text = "Mức lương";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(79)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(542, 159);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 29);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Ứng tuyển";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRusbish
            // 
            this.btnRusbish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.btnRusbish.FlatAppearance.BorderSize = 0;
            this.btnRusbish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRusbish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRusbish.Image = global::Job_Application_Management.Properties.Resources.icons8_trash_can_16;
            this.btnRusbish.Location = new System.Drawing.Point(654, 158);
            this.btnRusbish.Name = "btnRusbish";
            this.btnRusbish.Size = new System.Drawing.Size(106, 29);
            this.btnRusbish.TabIndex = 7;
            this.btnRusbish.Text = "   Bỏ lưu";
            this.btnRusbish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRusbish.UseVisualStyleBackColor = false;
            this.btnRusbish.Click += new System.EventHandler(this.btnRusbish_Click);
            // 
            // lblComName
            // 
            this.lblComName.AutoSize = true;
            this.lblComName.Image = global::Job_Application_Management.Properties.Resources.icons8_company_16;
            this.lblComName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblComName.Location = new System.Drawing.Point(178, 78);
            this.lblComName.Name = "lblComName";
            this.lblComName.Size = new System.Drawing.Size(76, 16);
            this.lblComName.TabIndex = 4;
            this.lblComName.Text = "        Công ty";
            // 
            // lblTimeSaved
            // 
            this.lblTimeSaved.AutoSize = true;
            this.lblTimeSaved.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTimeSaved.Location = new System.Drawing.Point(174, 125);
            this.lblTimeSaved.Name = "lblTimeSaved";
            this.lblTimeSaved.Size = new System.Drawing.Size(87, 16);
            this.lblTimeSaved.TabIndex = 3;
            this.lblTimeSaved.Text = "Thời điểm lưu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Job_Application_Management.Properties.Resources.icons8_company_100;
            this.pictureBox1.Location = new System.Drawing.Point(18, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 205);
            this.panel1.TabIndex = 0;
            // 
            // lblAddress
            // 
            this.lblAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddress.Location = new System.Drawing.Point(163, 158);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(116, 48);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "       Địa điểm";
            // 
            // lblTimeUpdate
            // 
            this.lblTimeUpdate.AutoSize = true;
            this.lblTimeUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTimeUpdate.Location = new System.Drawing.Point(285, 158);
            this.lblTimeUpdate.Name = "lblTimeUpdate";
            this.lblTimeUpdate.Size = new System.Drawing.Size(117, 16);
            this.lblTimeUpdate.TabIndex = 10;
            this.lblTimeUpdate.Text = "Thời gian cập nhật";
            // 
            // UC_JobsSaved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTimeUpdate);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRusbish);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblDescrption);
            this.Controls.Add(this.lblComName);
            this.Controls.Add(this.lblTimeSaved);
            this.Controls.Add(this.panel1);
            this.Name = "UC_JobsSaved";
            this.Size = new System.Drawing.Size(780, 205);
            this.Load += new System.EventHandler(this.UC_Candidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTimeSaved;
        private System.Windows.Forms.Label lblComName;
        private System.Windows.Forms.Label lblDescrption;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnRusbish;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTimeUpdate;
    }
}
