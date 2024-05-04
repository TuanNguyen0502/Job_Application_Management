namespace Job_Application_Management
{
    partial class FCandidate_AppliedJobs
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdb_TallestSalary = new System.Windows.Forms.RadioButton();
            this.rdb_Lately = new System.Windows.Forms.RadioButton();
            this.rdb_Nearly = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.flpStoreUC = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(738, 48);
            this.label4.TabIndex = 4;
            this.label4.Text = "Xem lại danh sách những việc làm mà bạn đã ứng tuyển trước đó. Xem xét trạng thái" +
    " các công việc để nhận lấy cơ hội phỏng vấn\r\n.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Việc làm đã ứng tuyển";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(843, 49);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách các công việc đã ứng tuyển";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Azure;
            this.panel5.Controls.Add(this.rdb_TallestSalary);
            this.panel5.Controls.Add(this.rdb_Lately);
            this.panel5.Controls.Add(this.rdb_Nearly);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(0, 164);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(846, 47);
            this.panel5.TabIndex = 6;
            // 
            // rdb_TallestSalary
            // 
            this.rdb_TallestSalary.AutoSize = true;
            this.rdb_TallestSalary.Location = new System.Drawing.Point(519, 13);
            this.rdb_TallestSalary.Name = "rdb_TallestSalary";
            this.rdb_TallestSalary.Size = new System.Drawing.Size(119, 20);
            this.rdb_TallestSalary.TabIndex = 4;
            this.rdb_TallestSalary.TabStop = true;
            this.rdb_TallestSalary.Text = "Lương cao nhất";
            this.rdb_TallestSalary.UseVisualStyleBackColor = true;
            this.rdb_TallestSalary.CheckedChanged += new System.EventHandler(this.rbd_TallestSalary_CheckedChanged);
            // 
            // rdb_Lately
            // 
            this.rdb_Lately.AutoSize = true;
            this.rdb_Lately.Location = new System.Drawing.Point(353, 14);
            this.rdb_Lately.Name = "rdb_Lately";
            this.rdb_Lately.Size = new System.Drawing.Size(114, 20);
            this.rdb_Lately.TabIndex = 3;
            this.rdb_Lately.TabStop = true;
            this.rdb_Lately.Text = "Cần tuyển gấp";
            this.rdb_Lately.UseVisualStyleBackColor = true;
            this.rdb_Lately.CheckedChanged += new System.EventHandler(this.rdb_Lately_CheckedChanged);
            // 
            // rdb_Nearly
            // 
            this.rdb_Nearly.AutoSize = true;
            this.rdb_Nearly.Location = new System.Drawing.Point(185, 14);
            this.rdb_Nearly.Name = "rdb_Nearly";
            this.rdb_Nearly.Size = new System.Drawing.Size(135, 20);
            this.rdb_Nearly.TabIndex = 2;
            this.rdb_Nearly.TabStop = true;
            this.rdb_Nearly.Text = "Cập nhật gần nhất";
            this.rdb_Nearly.UseVisualStyleBackColor = true;
            this.rdb_Nearly.CheckedChanged += new System.EventHandler(this.rdb_Nearly_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ưu tiên hiển thị theo:";
            // 
            // flpStoreUC
            // 
            this.flpStoreUC.AutoScroll = true;
            this.flpStoreUC.Location = new System.Drawing.Point(8, 216);
            this.flpStoreUC.Name = "flpStoreUC";
            this.flpStoreUC.Size = new System.Drawing.Size(811, 489);
            this.flpStoreUC.TabIndex = 9;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label4);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 4);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.DarkCyan;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(843, 101);
            this.guna2ShadowPanel1.TabIndex = 10;
            // 
            // FCandidate_AppliedJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 708);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.flpStoreUC);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCandidate_AppliedJobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCandidate_Applied";
            this.Load += new System.EventHandler(this.FCandidate_AppliedJobs_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rdb_TallestSalary;
        private System.Windows.Forms.RadioButton rdb_Lately;
        private System.Windows.Forms.RadioButton rdb_Nearly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpStoreUC;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
    }
}