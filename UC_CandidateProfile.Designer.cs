namespace Job_Application_Management
{
    partial class UC_CandidateProfile
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
            this.label_University = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_GPA = new System.Windows.Forms.Label();
            this.label_Major = new System.Windows.Forms.Label();
            this.button_detail = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label_Objective = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Company = new System.Windows.Forms.Label();
            this.label_Workplace = new System.Windows.Forms.Label();
            this.label_Certification = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_University
            // 
            this.label_University.AutoSize = true;
            this.label_University.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_University.Location = new System.Drawing.Point(484, 10);
            this.label_University.Name = "label_University";
            this.label_University.Padding = new System.Windows.Forms.Padding(10);
            this.label_University.Size = new System.Drawing.Size(185, 53);
            this.label_University.TabIndex = 8;
            this.label_University.Text = "University";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(13, 10);
            this.label_Name.Name = "label_Name";
            this.label_Name.Padding = new System.Windows.Forms.Padding(10);
            this.label_Name.Size = new System.Drawing.Size(289, 57);
            this.label_Name.TabIndex = 7;
            this.label_Name.Text = "Candidate Name";
            // 
            // label_GPA
            // 
            this.label_GPA.AutoSize = true;
            this.label_GPA.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GPA.Location = new System.Drawing.Point(821, 10);
            this.label_GPA.Name = "label_GPA";
            this.label_GPA.Padding = new System.Windows.Forms.Padding(10);
            this.label_GPA.Size = new System.Drawing.Size(80, 53);
            this.label_GPA.TabIndex = 12;
            this.label_GPA.Text = "GPA";
            // 
            // label_Major
            // 
            this.label_Major.AutoSize = true;
            this.label_Major.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Major.Location = new System.Drawing.Point(675, 10);
            this.label_Major.Name = "label_Major";
            this.label_Major.Padding = new System.Windows.Forms.Padding(10);
            this.label_Major.Size = new System.Drawing.Size(140, 53);
            this.label_Major.TabIndex = 11;
            this.label_Major.Text = "Major: ";
            // 
            // button_detail
            // 
            this.button_detail.Location = new System.Drawing.Point(1162, 13);
            this.button_detail.Name = "button_detail";
            this.button_detail.Size = new System.Drawing.Size(100, 50);
            this.button_detail.StateCommon.Back.Image = global::Job_Application_Management.Properties.Resources.icons8_edit_241;
            this.button_detail.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.button_detail.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.button_detail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_detail.StateCommon.Border.Rounding = 20;
            this.button_detail.StateCommon.Border.Width = 1;
            this.button_detail.TabIndex = 10;
            this.button_detail.Values.Text = "";
            // 
            // label_Objective
            // 
            this.label_Objective.AutoSize = true;
            this.label_Objective.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Objective.Location = new System.Drawing.Point(308, 10);
            this.label_Objective.Name = "label_Objective";
            this.label_Objective.Padding = new System.Windows.Forms.Padding(10);
            this.label_Objective.Size = new System.Drawing.Size(170, 53);
            this.label_Objective.TabIndex = 13;
            this.label_Objective.Text = "Objective";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label_Name);
            this.flowLayoutPanel1.Controls.Add(this.label_Objective);
            this.flowLayoutPanel1.Controls.Add(this.label_University);
            this.flowLayoutPanel1.Controls.Add(this.label_Major);
            this.flowLayoutPanel1.Controls.Add(this.label_GPA);
            this.flowLayoutPanel1.Controls.Add(this.label_Company);
            this.flowLayoutPanel1.Controls.Add(this.label_Workplace);
            this.flowLayoutPanel1.Controls.Add(this.label_Certification);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1285, 106);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // label_Company
            // 
            this.label_Company.AutoSize = true;
            this.label_Company.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Company.Location = new System.Drawing.Point(907, 10);
            this.label_Company.Name = "label_Company";
            this.label_Company.Padding = new System.Windows.Forms.Padding(10);
            this.label_Company.Size = new System.Drawing.Size(215, 53);
            this.label_Company.TabIndex = 14;
            this.label_Company.Text = "Company Name";
            // 
            // label_Workplace
            // 
            this.label_Workplace.AutoSize = true;
            this.label_Workplace.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Workplace.Location = new System.Drawing.Point(1128, 10);
            this.label_Workplace.Name = "label_Workplace";
            this.label_Workplace.Padding = new System.Windows.Forms.Padding(10);
            this.label_Workplace.Size = new System.Drawing.Size(140, 86);
            this.label_Workplace.TabIndex = 15;
            this.label_Workplace.Text = "Workplace";
            // 
            // label_Certification
            // 
            this.label_Certification.AutoSize = true;
            this.label_Certification.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Certification.Location = new System.Drawing.Point(1274, 10);
            this.label_Certification.Name = "label_Certification";
            this.label_Certification.Padding = new System.Windows.Forms.Padding(10);
            this.label_Certification.Size = new System.Drawing.Size(230, 53);
            this.label_Certification.TabIndex = 16;
            this.label_Certification.Text = "Certification";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button_detail);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 510);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1285, 80);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // UC_CandidateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UC_CandidateProfile";
            this.Size = new System.Drawing.Size(1285, 590);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_University;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_GPA;
        private System.Windows.Forms.Label label_Major;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_detail;
        private System.Windows.Forms.Label label_Objective;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_Company;
        private System.Windows.Forms.Label label_Workplace;
        private System.Windows.Forms.Label label_Certification;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}