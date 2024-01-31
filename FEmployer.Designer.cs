namespace Job_Application_Management
{
    partial class FEmployer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel_Left = new System.Windows.Forms.FlowLayoutPanel();
            this.button_PostedJob = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel_Left.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Job_Application_Management.Properties.Resources.ShakeHand;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "See Information";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_Left
            // 
            this.flowLayoutPanel_Left.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel_Left.Controls.Add(this.button1);
            this.flowLayoutPanel_Left.Controls.Add(this.button_PostedJob);
            this.flowLayoutPanel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel_Left.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_Left.Name = "flowLayoutPanel_Left";
            this.flowLayoutPanel_Left.Size = new System.Drawing.Size(237, 670);
            this.flowLayoutPanel_Left.TabIndex = 2;
            // 
            // button_PostedJob
            // 
            this.button_PostedJob.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PostedJob.Location = new System.Drawing.Point(3, 215);
            this.button_PostedJob.Name = "button_PostedJob";
            this.button_PostedJob.Size = new System.Drawing.Size(232, 56);
            this.button_PostedJob.TabIndex = 1;
            this.button_PostedJob.Text = "Posted Jobs";
            this.button_PostedJob.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1032, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Employer to Job Application Management";
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.label1);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(237, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1051, 100);
            this.panel_Top.TabIndex = 3;
            // 
            // FEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 670);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.flowLayoutPanel_Left);
            this.Name = "FEmployer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel_Left.ResumeLayout(false);
            this.flowLayoutPanel_Left.PerformLayout();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Left;
        private System.Windows.Forms.Button button_PostedJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Top;
    }
}