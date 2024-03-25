namespace Job_Application_Management
{
    partial class UC_Resume_Skill
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
            this.textBox_SkillName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBox_SkillDetail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // textBox_SkillName
            // 
            this.textBox_SkillName.Location = new System.Drawing.Point(13, 13);
            this.textBox_SkillName.Name = "textBox_SkillName";
            this.textBox_SkillName.Size = new System.Drawing.Size(1258, 52);
            this.textBox_SkillName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_SkillName.StateCommon.Border.Rounding = 20;
            this.textBox_SkillName.StateCommon.Border.Width = 1;
            this.textBox_SkillName.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SkillName.TabIndex = 3;
            this.textBox_SkillName.Text = "Ten ky nang";
            // 
            // textBox_SkillDetail
            // 
            this.textBox_SkillDetail.Location = new System.Drawing.Point(13, 85);
            this.textBox_SkillDetail.Name = "textBox_SkillDetail";
            this.textBox_SkillDetail.Size = new System.Drawing.Size(1258, 52);
            this.textBox_SkillDetail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_SkillDetail.StateCommon.Border.Rounding = 20;
            this.textBox_SkillDetail.StateCommon.Border.Width = 1;
            this.textBox_SkillDetail.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SkillDetail.TabIndex = 4;
            this.textBox_SkillDetail.Text = "Chi tiet";
            // 
            // UC_Resume_Skill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_SkillDetail);
            this.Controls.Add(this.textBox_SkillName);
            this.Name = "UC_Resume_Skill";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1284, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_SkillName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_SkillDetail;
    }
}
