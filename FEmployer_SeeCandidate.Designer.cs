namespace Job_Application_Management
{
    partial class FEmployer_SeeCandidate
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
            this.panel_Top = new System.Windows.Forms.Panel();
            this.button_Back = new System.Windows.Forms.Button();
            this.panel_Center = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Detail = new System.Windows.Forms.Button();
            this.button_Approve = new System.Windows.Forms.Button();
            this.button_Refuse = new System.Windows.Forms.Button();
            this.panel_Top.SuspendLayout();
            this.panel_Center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.button_Refuse);
            this.panel_Top.Controls.Add(this.button_Approve);
            this.panel_Top.Controls.Add(this.button_Detail);
            this.panel_Top.Controls.Add(this.button_Back);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1395, 91);
            this.panel_Top.TabIndex = 0;
            // 
            // button_Back
            // 
            this.button_Back.Font = new System.Drawing.Font("Consolas", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Back.Location = new System.Drawing.Point(12, 12);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(170, 65);
            this.button_Back.TabIndex = 1;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            // 
            // panel_Center
            // 
            this.panel_Center.Controls.Add(this.dataGridView1);
            this.panel_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Center.Location = new System.Drawing.Point(0, 91);
            this.panel_Center.Name = "panel_Center";
            this.panel_Center.Size = new System.Drawing.Size(1395, 785);
            this.panel_Center.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1371, 777);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_Detail
            // 
            this.button_Detail.Font = new System.Drawing.Font("Consolas", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Detail.Location = new System.Drawing.Point(215, 12);
            this.button_Detail.Name = "button_Detail";
            this.button_Detail.Size = new System.Drawing.Size(170, 65);
            this.button_Detail.TabIndex = 2;
            this.button_Detail.Text = "Detail";
            this.button_Detail.UseVisualStyleBackColor = true;
            // 
            // button_Approve
            // 
            this.button_Approve.Font = new System.Drawing.Font("Consolas", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Approve.Location = new System.Drawing.Point(425, 12);
            this.button_Approve.Name = "button_Approve";
            this.button_Approve.Size = new System.Drawing.Size(170, 65);
            this.button_Approve.TabIndex = 3;
            this.button_Approve.Text = "Approve";
            this.button_Approve.UseVisualStyleBackColor = true;
            // 
            // button_Refuse
            // 
            this.button_Refuse.Font = new System.Drawing.Font("Consolas", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refuse.Location = new System.Drawing.Point(639, 12);
            this.button_Refuse.Name = "button_Refuse";
            this.button_Refuse.Size = new System.Drawing.Size(170, 65);
            this.button_Refuse.TabIndex = 4;
            this.button_Refuse.Text = "Refuse";
            this.button_Refuse.UseVisualStyleBackColor = true;
            // 
            // FEmployer_SeeCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 876);
            this.Controls.Add(this.panel_Center);
            this.Controls.Add(this.panel_Top);
            this.Name = "FEmployer_SeeCandidate";
            this.Text = "Candidates";
            this.panel_Top.ResumeLayout(false);
            this.panel_Center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Panel panel_Center;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Approve;
        private System.Windows.Forms.Button button_Detail;
        private System.Windows.Forms.Button button_Refuse;
    }
}