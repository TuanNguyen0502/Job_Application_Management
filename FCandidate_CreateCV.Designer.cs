namespace Job_Application_Management
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
            this.SuspendLayout();
            // 
            // uc_AtFormCreateCV
            // 
            this.uc_AtFormCreateCV.AutoScroll = true;
            this.uc_AtFormCreateCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_AtFormCreateCV.Location = new System.Drawing.Point(0, 0);
            this.uc_AtFormCreateCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uc_AtFormCreateCV.Name = "uc_AtFormCreateCV";
            this.uc_AtFormCreateCV.Size = new System.Drawing.Size(1271, 840);
            this.uc_AtFormCreateCV.TabIndex = 0;
            // 
            // FCandidate_CreateCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1271, 840);
            this.Controls.Add(this.uc_AtFormCreateCV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCandidate_CreateCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo CV";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Resume uc_AtFormCreateCV;
    }
}