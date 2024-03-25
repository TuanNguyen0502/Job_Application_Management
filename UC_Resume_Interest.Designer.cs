namespace Job_Application_Management
{
    partial class UC_Resume_Interest
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
            this.textBox_InterestDetail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBox_InterestName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // textBox_InterestDetail
            // 
            this.textBox_InterestDetail.Location = new System.Drawing.Point(13, 80);
            this.textBox_InterestDetail.Name = "textBox_InterestDetail";
            this.textBox_InterestDetail.Size = new System.Drawing.Size(1258, 52);
            this.textBox_InterestDetail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_InterestDetail.StateCommon.Border.Rounding = 20;
            this.textBox_InterestDetail.StateCommon.Border.Width = 1;
            this.textBox_InterestDetail.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InterestDetail.TabIndex = 6;
            this.textBox_InterestDetail.Text = "Chi tiet";
            // 
            // textBox_InterestName
            // 
            this.textBox_InterestName.Location = new System.Drawing.Point(13, 13);
            this.textBox_InterestName.Name = "textBox_InterestName";
            this.textBox_InterestName.Size = new System.Drawing.Size(1258, 52);
            this.textBox_InterestName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_InterestName.StateCommon.Border.Rounding = 20;
            this.textBox_InterestName.StateCommon.Border.Width = 1;
            this.textBox_InterestName.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InterestName.TabIndex = 5;
            this.textBox_InterestName.Text = "Ten ky nang";
            // 
            // UC_Resume_Interest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_InterestDetail);
            this.Controls.Add(this.textBox_InterestName);
            this.Name = "UC_Resume_Interest";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1281, 145);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_InterestDetail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_InterestName;
    }
}
