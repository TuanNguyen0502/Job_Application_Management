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
            this.uC_AppliedList = new Job_Application_Management.UC_Jobs();
            this.SuspendLayout();
            // 
            // uC_AppliedList
            // 
            this.uC_AppliedList.Location = new System.Drawing.Point(12, 12);
            this.uC_AppliedList.Name = "uC_AppliedList";
            this.uC_AppliedList.Size = new System.Drawing.Size(650, 450);
            this.uC_AppliedList.TabIndex = 0;
            // 
            // FCandidate_AppliedJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 471);
            this.Controls.Add(this.uC_AppliedList);
            this.Name = "FCandidate_AppliedJobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCandidate_Applied";
            this.Load += new System.EventHandler(this.FCandidate_AppliedJobs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Jobs uC_AppliedList;
    }
}