namespace Job_Application_Management
{
    partial class UC_Employer_Job
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_PostedTime = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Salary = new System.Windows.Forms.Label();
            this.label_Deadline = new System.Windows.Forms.Label();
            this.label_NumberAppliedCandidates = new System.Windows.Forms.Label();
            this.label_NumberApprovedCandidates = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Edit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button_delete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.textBox_JobName = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label_PostedTime);
            this.flowLayoutPanel1.Controls.Add(this.textBox_JobName);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(381, 207);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label_PostedTime
            // 
            this.label_PostedTime.AutoSize = true;
            this.label_PostedTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PostedTime.ForeColor = System.Drawing.Color.Gray;
            this.label_PostedTime.Location = new System.Drawing.Point(13, 10);
            this.label_PostedTime.Name = "label_PostedTime";
            this.label_PostedTime.Size = new System.Drawing.Size(71, 28);
            this.label_PostedTime.TabIndex = 0;
            this.label_PostedTime.Text = "Posted";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label_Salary);
            this.flowLayoutPanel2.Controls.Add(this.label_Deadline);
            this.flowLayoutPanel2.Controls.Add(this.label_NumberAppliedCandidates);
            this.flowLayoutPanel2.Controls.Add(this.label_NumberApprovedCandidates);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 207);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(381, 269);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label_Salary
            // 
            this.label_Salary.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_Salary.Image = global::Job_Application_Management.Properties.Resources.icons8_salary_32;
            this.label_Salary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Salary.Location = new System.Drawing.Point(13, 10);
            this.label_Salary.Name = "label_Salary";
            this.label_Salary.Size = new System.Drawing.Size(365, 60);
            this.label_Salary.TabIndex = 2;
            this.label_Salary.Text = "Salary: ";
            this.label_Salary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Deadline
            // 
            this.label_Deadline.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_Deadline.Image = global::Job_Application_Management.Properties.Resources.icons8_deadline_32;
            this.label_Deadline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Deadline.Location = new System.Drawing.Point(13, 70);
            this.label_Deadline.Name = "label_Deadline";
            this.label_Deadline.Size = new System.Drawing.Size(365, 60);
            this.label_Deadline.TabIndex = 3;
            this.label_Deadline.Text = "Deadline: ";
            this.label_Deadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_NumberAppliedCandidates
            // 
            this.label_NumberAppliedCandidates.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_NumberAppliedCandidates.Image = global::Job_Application_Management.Properties.Resources.icons8_candidate_32;
            this.label_NumberAppliedCandidates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_NumberAppliedCandidates.Location = new System.Drawing.Point(13, 130);
            this.label_NumberAppliedCandidates.Name = "label_NumberAppliedCandidates";
            this.label_NumberAppliedCandidates.Size = new System.Drawing.Size(365, 60);
            this.label_NumberAppliedCandidates.TabIndex = 3;
            this.label_NumberAppliedCandidates.Text = "Applied: ";
            this.label_NumberAppliedCandidates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_NumberApprovedCandidates
            // 
            this.label_NumberApprovedCandidates.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_NumberApprovedCandidates.Image = global::Job_Application_Management.Properties.Resources.icons8_candidate_32;
            this.label_NumberApprovedCandidates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_NumberApprovedCandidates.Location = new System.Drawing.Point(13, 190);
            this.label_NumberApprovedCandidates.Name = "label_NumberApprovedCandidates";
            this.label_NumberApprovedCandidates.Size = new System.Drawing.Size(365, 60);
            this.label_NumberApprovedCandidates.TabIndex = 4;
            this.label_NumberApprovedCandidates.Text = "Approved: ";
            this.label_NumberApprovedCandidates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button_Edit);
            this.flowLayoutPanel3.Controls.Add(this.button_delete);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 483);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(381, 100);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // button_Edit
            // 
            this.button_Edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Edit.Location = new System.Drawing.Point(13, 13);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_Edit.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_Edit.OverrideDefault.Back.ColorAngle = 45F;
            this.button_Edit.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_Edit.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_Edit.OverrideDefault.Border.ColorAngle = 45F;
            this.button_Edit.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_Edit.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_Edit.OverrideDefault.Border.Rounding = 20;
            this.button_Edit.OverrideDefault.Border.Width = 1;
            this.button_Edit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button_Edit.Size = new System.Drawing.Size(100, 60);
            this.button_Edit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_Edit.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_Edit.StateCommon.Back.ColorAngle = 45F;
            this.button_Edit.StateCommon.Back.Image = global::Job_Application_Management.Properties.Resources.icons8_edit_24;
            this.button_Edit.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.button_Edit.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.button_Edit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_Edit.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_Edit.StateCommon.Border.ColorAngle = 45F;
            this.button_Edit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_Edit.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_Edit.StateCommon.Border.Rounding = 20;
            this.button_Edit.StateCommon.Border.Width = 1;
            this.button_Edit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button_Edit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button_Edit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Edit.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_Edit.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_Edit.StatePressed.Back.ColorAngle = 135F;
            this.button_Edit.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_Edit.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_Edit.StatePressed.Border.ColorAngle = 135F;
            this.button_Edit.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_Edit.StatePressed.Border.Rounding = 20;
            this.button_Edit.StatePressed.Border.Width = 1;
            this.button_Edit.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_Edit.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_Edit.StateTracking.Back.ColorAngle = 45F;
            this.button_Edit.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_Edit.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_Edit.StateTracking.Border.ColorAngle = 45F;
            this.button_Edit.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_Edit.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_Edit.StateTracking.Border.Rounding = 20;
            this.button_Edit.StateTracking.Border.Width = 1;
            this.button_Edit.TabIndex = 17;
            this.button_Edit.Values.Text = "";
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_delete.Location = new System.Drawing.Point(119, 13);
            this.button_delete.Name = "button_delete";
            this.button_delete.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_delete.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_delete.OverrideDefault.Back.ColorAngle = 45F;
            this.button_delete.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_delete.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_delete.OverrideDefault.Border.ColorAngle = 45F;
            this.button_delete.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_delete.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_delete.OverrideDefault.Border.Rounding = 20;
            this.button_delete.OverrideDefault.Border.Width = 1;
            this.button_delete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button_delete.Size = new System.Drawing.Size(100, 60);
            this.button_delete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_delete.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_delete.StateCommon.Back.ColorAngle = 45F;
            this.button_delete.StateCommon.Back.Image = global::Job_Application_Management.Properties.Resources.icons8_delete_24;
            this.button_delete.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.button_delete.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.button_delete.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_delete.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_delete.StateCommon.Border.ColorAngle = 45F;
            this.button_delete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_delete.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_delete.StateCommon.Border.Rounding = 20;
            this.button_delete.StateCommon.Border.Width = 1;
            this.button_delete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button_delete.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button_delete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_delete.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_delete.StatePressed.Back.ColorAngle = 135F;
            this.button_delete.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_delete.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_delete.StatePressed.Border.ColorAngle = 135F;
            this.button_delete.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_delete.StatePressed.Border.Rounding = 20;
            this.button_delete.StatePressed.Border.Width = 1;
            this.button_delete.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_delete.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_delete.StateTracking.Back.ColorAngle = 45F;
            this.button_delete.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_delete.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_delete.StateTracking.Border.ColorAngle = 45F;
            this.button_delete.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_delete.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_delete.StateTracking.Border.Rounding = 20;
            this.button_delete.StateTracking.Border.Width = 1;
            this.button_delete.TabIndex = 18;
            this.button_delete.Values.Text = "";
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_JobName
            // 
            this.textBox_JobName.BorderThickness = 0;
            this.textBox_JobName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_JobName.DefaultText = "";
            this.textBox_JobName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_JobName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_JobName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_JobName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_JobName.FillColor = System.Drawing.Color.LightCyan;
            this.textBox_JobName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_JobName.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_JobName.ForeColor = System.Drawing.Color.DarkOrange;
            this.textBox_JobName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_JobName.Location = new System.Drawing.Point(16, 46);
            this.textBox_JobName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox_JobName.Multiline = true;
            this.textBox_JobName.Name = "textBox_JobName";
            this.textBox_JobName.PasswordChar = '\0';
            this.textBox_JobName.PlaceholderText = "";
            this.textBox_JobName.ReadOnly = true;
            this.textBox_JobName.SelectedText = "";
            this.textBox_JobName.Size = new System.Drawing.Size(356, 136);
            this.textBox_JobName.TabIndex = 1;
            // 
            // UC_Employer_Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UC_Employer_Job";
            this.Size = new System.Drawing.Size(381, 583);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_PostedTime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_Edit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_delete;
        private System.Windows.Forms.Label label_Salary;
        private System.Windows.Forms.Label label_Deadline;
        private System.Windows.Forms.Label label_NumberAppliedCandidates;
        private System.Windows.Forms.Label label_NumberApprovedCandidates;
        private Guna.UI2.WinForms.Guna2TextBox textBox_JobName;
    }
}
