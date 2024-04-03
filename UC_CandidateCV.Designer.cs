namespace Job_Application_Management
{
    partial class UC_CandidateCV
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_University = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_detail = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button_delete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label_Major = new System.Windows.Forms.Label();
            this.label_GPA = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(193, 10);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(269, 37);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Candidate Name";
            // 
            // label_University
            // 
            this.label_University.AutoSize = true;
            this.label_University.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_University.Location = new System.Drawing.Point(194, 60);
            this.label_University.Name = "label_University";
            this.label_University.Size = new System.Drawing.Size(165, 33);
            this.label_University.TabIndex = 1;
            this.label_University.Text = "University";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 171);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(17, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_detail
            // 
            this.button_detail.Location = new System.Drawing.Point(1061, 128);
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
            this.button_detail.TabIndex = 3;
            this.button_detail.Values.Text = "";
            this.button_detail.Click += new System.EventHandler(this.button_detail_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(1167, 128);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 50);
            this.button_delete.StateCommon.Back.Image = global::Job_Application_Management.Properties.Resources.icons8_delete_24;
            this.button_delete.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.button_delete.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.button_delete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_delete.StateCommon.Border.Rounding = 20;
            this.button_delete.StateCommon.Border.Width = 1;
            this.button_delete.TabIndex = 4;
            this.button_delete.Values.Text = "";
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label_Major
            // 
            this.label_Major.AutoSize = true;
            this.label_Major.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Major.Location = new System.Drawing.Point(194, 104);
            this.label_Major.Name = "label_Major";
            this.label_Major.Size = new System.Drawing.Size(90, 33);
            this.label_Major.TabIndex = 5;
            this.label_Major.Text = "Major";
            // 
            // label_GPA
            // 
            this.label_GPA.AutoSize = true;
            this.label_GPA.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GPA.Location = new System.Drawing.Point(194, 148);
            this.label_GPA.Name = "label_GPA";
            this.label_GPA.Size = new System.Drawing.Size(60, 33);
            this.label_GPA.TabIndex = 6;
            this.label_GPA.Text = "GPA";
            // 
            // UC_CandidateCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.label_GPA);
            this.Controls.Add(this.label_Major);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_detail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_University);
            this.Controls.Add(this.label_Name);
            this.Name = "UC_CandidateCV";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1280, 191);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_University;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_detail;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_delete;
        private System.Windows.Forms.Label label_Major;
        private System.Windows.Forms.Label label_GPA;
    }
}
