﻿namespace Job_Application_Management
{
    partial class FCandidate_CreateCV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCandidate_CreateCV));
            this.uc_AtFormCreateCV = new Job_Application_Management.UC_Resume();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // uc_AtFormCreateCV
            // 
            this.uc_AtFormCreateCV.AutoScroll = true;
            this.uc_AtFormCreateCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_AtFormCreateCV.Location = new System.Drawing.Point(0, 0);
            this.uc_AtFormCreateCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uc_AtFormCreateCV.Name = "uc_AtFormCreateCV";
            this.uc_AtFormCreateCV.Size = new System.Drawing.Size(1282, 1055);
            this.uc_AtFormCreateCV.TabIndex = 0;
            this.uc_AtFormCreateCV.Load += new System.EventHandler(this.uc_AtFormCreateCV_Load);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(979, 12);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(151, 63);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 15;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Lime;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.Text = "Lưu hồ sơ";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // FCandidate_CreateCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1282, 1055);
            this.Controls.Add(this.uc_AtFormCreateCV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCandidate_CreateCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo CV";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Resume uc_AtFormCreateCV;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}