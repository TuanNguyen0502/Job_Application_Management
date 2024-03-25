namespace Job_Application_Management
{
    partial class UC_Resume_Certificate
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
            this.textBox_CertificateName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.SuspendLayout();
            // 
            // textBox_CertificateName
            // 
            this.textBox_CertificateName.Location = new System.Drawing.Point(13, 13);
            this.textBox_CertificateName.Name = "textBox_CertificateName";
            this.textBox_CertificateName.Size = new System.Drawing.Size(930, 52);
            this.textBox_CertificateName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_CertificateName.StateCommon.Border.Rounding = 20;
            this.textBox_CertificateName.StateCommon.Border.Width = 1;
            this.textBox_CertificateName.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CertificateName.TabIndex = 1;
            this.textBox_CertificateName.Text = "Ten chung chi";
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(1037, 13);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(239, 50);
            this.kryptonDateTimePicker1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDateTimePicker1.StateCommon.Border.Rounding = 20;
            this.kryptonDateTimePicker1.StateCommon.Border.Width = 1;
            this.kryptonDateTimePicker1.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonDateTimePicker1.TabIndex = 2;
            // 
            // UC_Resume_Certificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonDateTimePicker1);
            this.Controls.Add(this.textBox_CertificateName);
            this.Name = "UC_Resume_Certificate";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1289, 88);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_CertificateName;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
    }
}
