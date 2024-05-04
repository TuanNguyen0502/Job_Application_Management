namespace Job_Application_Management
{
    partial class FEmployer_JobDetail
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
            this.tableLayoutPanel_Information = new System.Windows.Forms.TableLayoutPanel();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Deadline = new System.Windows.Forms.Label();
            this.label_Experience = new System.Windows.Forms.Label();
            this.textBox_JobName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBox_Experience = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dateTimePicker_Deadline = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label_Salary = new System.Windows.Forms.Label();
            this.textBox_Salary = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.richTextBox_JobDescripton = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.label_Time = new System.Windows.Forms.Label();
            this.textBox_WorkingTime = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label__Benefit = new System.Windows.Forms.Label();
            this.richTextBox_JobBenefit = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.label_CompanyType = new System.Windows.Forms.Label();
            this.richTextBox_Requirement = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Post = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button_Delete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button_SeeCandidate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button_ApprovedCandidate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel_Information.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Information
            // 
            this.tableLayoutPanel_Information.ColumnCount = 4;
            this.tableLayoutPanel_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.59437F));
            this.tableLayoutPanel_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69359F));
            this.tableLayoutPanel_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.7883F));
            this.tableLayoutPanel_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.91365F));
            this.tableLayoutPanel_Information.Controls.Add(this.label_ID, 0, 0);
            this.tableLayoutPanel_Information.Controls.Add(this.label_Deadline, 2, 0);
            this.tableLayoutPanel_Information.Controls.Add(this.label_Experience, 2, 2);
            this.tableLayoutPanel_Information.Controls.Add(this.textBox_JobName, 1, 0);
            this.tableLayoutPanel_Information.Controls.Add(this.textBox_Experience, 3, 2);
            this.tableLayoutPanel_Information.Controls.Add(this.dateTimePicker_Deadline, 3, 0);
            this.tableLayoutPanel_Information.Controls.Add(this.label_Salary, 0, 1);
            this.tableLayoutPanel_Information.Controls.Add(this.textBox_Salary, 1, 1);
            this.tableLayoutPanel_Information.Controls.Add(this.label_Description, 2, 1);
            this.tableLayoutPanel_Information.Controls.Add(this.richTextBox_JobDescripton, 3, 1);
            this.tableLayoutPanel_Information.Controls.Add(this.label_Time, 0, 2);
            this.tableLayoutPanel_Information.Controls.Add(this.textBox_WorkingTime, 1, 2);
            this.tableLayoutPanel_Information.Controls.Add(this.label__Benefit, 0, 3);
            this.tableLayoutPanel_Information.Controls.Add(this.richTextBox_JobBenefit, 1, 3);
            this.tableLayoutPanel_Information.Controls.Add(this.label_CompanyType, 2, 3);
            this.tableLayoutPanel_Information.Controls.Add(this.richTextBox_Requirement, 3, 3);
            this.tableLayoutPanel_Information.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel_Information.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel_Information.Name = "tableLayoutPanel_Information";
            this.tableLayoutPanel_Information.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel_Information.RowCount = 4;
            this.tableLayoutPanel_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Information.Size = new System.Drawing.Size(1796, 611);
            this.tableLayoutPanel_Information.TabIndex = 6;
            // 
            // label_ID
            // 
            this.label_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Image = global::Job_Application_Management.Properties.Resources.icons8_job_32;
            this.label_ID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_ID.Location = new System.Drawing.Point(11, 46);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(294, 60);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "Job Name           ";
            this.label_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Deadline
            // 
            this.label_Deadline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Deadline.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_Deadline.Image = global::Job_Application_Management.Properties.Resources.icons8_deadline_32;
            this.label_Deadline.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Deadline.Location = new System.Drawing.Point(882, 48);
            this.label_Deadline.Name = "label_Deadline";
            this.label_Deadline.Size = new System.Drawing.Size(361, 56);
            this.label_Deadline.TabIndex = 5;
            this.label_Deadline.Text = "Deadline        ";
            this.label_Deadline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Experience
            // 
            this.label_Experience.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Experience.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_Experience.Image = global::Job_Application_Management.Properties.Resources.icons8_experience_32;
            this.label_Experience.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Experience.Location = new System.Drawing.Point(882, 350);
            this.label_Experience.Name = "label_Experience";
            this.label_Experience.Size = new System.Drawing.Size(361, 60);
            this.label_Experience.TabIndex = 8;
            this.label_Experience.Text = "Experience        ";
            this.label_Experience.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_JobName
            // 
            this.textBox_JobName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_JobName.Location = new System.Drawing.Point(332, 52);
            this.textBox_JobName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_JobName.Name = "textBox_JobName";
            this.textBox_JobName.Size = new System.Drawing.Size(500, 47);
            this.textBox_JobName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_JobName.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textBox_JobName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.textBox_JobName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_JobName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_JobName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_JobName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textBox_JobName.StateCommon.Border.Rounding = 20;
            this.textBox_JobName.StateCommon.Border.Width = 1;
            this.textBox_JobName.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.textBox_JobName.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_JobName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.textBox_JobName.TabIndex = 15;
            // 
            // textBox_Experience
            // 
            this.textBox_Experience.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Experience.Location = new System.Drawing.Point(1291, 356);
            this.textBox_Experience.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Experience.Name = "textBox_Experience";
            this.textBox_Experience.Size = new System.Drawing.Size(490, 47);
            this.textBox_Experience.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_Experience.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textBox_Experience.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.textBox_Experience.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_Experience.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_Experience.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_Experience.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textBox_Experience.StateCommon.Border.Rounding = 20;
            this.textBox_Experience.StateCommon.Border.Width = 1;
            this.textBox_Experience.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.textBox_Experience.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Experience.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.textBox_Experience.TabIndex = 19;
            // 
            // dateTimePicker_Deadline
            // 
            this.dateTimePicker_Deadline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_Deadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Deadline.Location = new System.Drawing.Point(1291, 53);
            this.dateTimePicker_Deadline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_Deadline.Name = "dateTimePicker_Deadline";
            this.dateTimePicker_Deadline.Size = new System.Drawing.Size(490, 46);
            this.dateTimePicker_Deadline.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dateTimePicker_Deadline.StateCommon.Border.Rounding = 20;
            this.dateTimePicker_Deadline.StateCommon.Border.Width = 1;
            this.dateTimePicker_Deadline.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.dateTimePicker_Deadline.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Deadline.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dateTimePicker_Deadline.TabIndex = 24;
            // 
            // label_Salary
            // 
            this.label_Salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Salary.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_Salary.Image = global::Job_Application_Management.Properties.Resources.icons8_salary_32;
            this.label_Salary.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Salary.Location = new System.Drawing.Point(11, 198);
            this.label_Salary.Name = "label_Salary";
            this.label_Salary.Size = new System.Drawing.Size(294, 60);
            this.label_Salary.TabIndex = 4;
            this.label_Salary.Text = "Salary        ";
            this.label_Salary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Salary
            // 
            this.textBox_Salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Salary.Location = new System.Drawing.Point(332, 204);
            this.textBox_Salary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Salary.Name = "textBox_Salary";
            this.textBox_Salary.Size = new System.Drawing.Size(500, 47);
            this.textBox_Salary.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_Salary.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textBox_Salary.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.textBox_Salary.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_Salary.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_Salary.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_Salary.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textBox_Salary.StateCommon.Border.Rounding = 20;
            this.textBox_Salary.StateCommon.Border.Width = 1;
            this.textBox_Salary.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.textBox_Salary.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Salary.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.textBox_Salary.TabIndex = 17;
            // 
            // label_Description
            // 
            this.label_Description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Description.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_Description.Image = global::Job_Application_Management.Properties.Resources.icons8_description_32;
            this.label_Description.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Description.Location = new System.Drawing.Point(882, 198);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(361, 60);
            this.label_Description.TabIndex = 4;
            this.label_Description.Text = "Description         ";
            this.label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBox_JobDescripton
            // 
            this.richTextBox_JobDescripton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox_JobDescripton.Location = new System.Drawing.Point(1291, 155);
            this.richTextBox_JobDescripton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox_JobDescripton.Name = "richTextBox_JobDescripton";
            this.richTextBox_JobDescripton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.richTextBox_JobDescripton.Size = new System.Drawing.Size(490, 146);
            this.richTextBox_JobDescripton.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.richTextBox_JobDescripton.StateActive.Content.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_JobDescripton.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.richTextBox_JobDescripton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox_JobDescripton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox_JobDescripton.StateCommon.Border.ColorAngle = 45F;
            this.richTextBox_JobDescripton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.richTextBox_JobDescripton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.richTextBox_JobDescripton.StateCommon.Border.Rounding = 20;
            this.richTextBox_JobDescripton.StateCommon.Border.Width = 1;
            this.richTextBox_JobDescripton.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.richTextBox_JobDescripton.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_JobDescripton.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.richTextBox_JobDescripton.TabIndex = 21;
            this.richTextBox_JobDescripton.Text = "";
            // 
            // label_Time
            // 
            this.label_Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Time.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_Time.Image = global::Job_Application_Management.Properties.Resources.icons8_working_time_32;
            this.label_Time.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Time.Location = new System.Drawing.Point(11, 350);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(294, 60);
            this.label_Time.TabIndex = 6;
            this.label_Time.Text = "Working Time        ";
            this.label_Time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_WorkingTime
            // 
            this.textBox_WorkingTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_WorkingTime.Location = new System.Drawing.Point(332, 356);
            this.textBox_WorkingTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_WorkingTime.Name = "textBox_WorkingTime";
            this.textBox_WorkingTime.Size = new System.Drawing.Size(500, 47);
            this.textBox_WorkingTime.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_WorkingTime.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textBox_WorkingTime.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.textBox_WorkingTime.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_WorkingTime.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_WorkingTime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_WorkingTime.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textBox_WorkingTime.StateCommon.Border.Rounding = 20;
            this.textBox_WorkingTime.StateCommon.Border.Width = 1;
            this.textBox_WorkingTime.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.textBox_WorkingTime.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_WorkingTime.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.textBox_WorkingTime.TabIndex = 18;
            // 
            // label__Benefit
            // 
            this.label__Benefit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label__Benefit.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label__Benefit.Image = global::Job_Application_Management.Properties.Resources.icons8_benefit_32;
            this.label__Benefit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label__Benefit.Location = new System.Drawing.Point(11, 503);
            this.label__Benefit.Name = "label__Benefit";
            this.label__Benefit.Size = new System.Drawing.Size(294, 60);
            this.label__Benefit.TabIndex = 4;
            this.label__Benefit.Text = "Benefits        ";
            this.label__Benefit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBox_JobBenefit
            // 
            this.richTextBox_JobBenefit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox_JobBenefit.Location = new System.Drawing.Point(337, 459);
            this.richTextBox_JobBenefit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox_JobBenefit.Name = "richTextBox_JobBenefit";
            this.richTextBox_JobBenefit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.richTextBox_JobBenefit.Size = new System.Drawing.Size(490, 149);
            this.richTextBox_JobBenefit.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.richTextBox_JobBenefit.StateActive.Content.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_JobBenefit.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.richTextBox_JobBenefit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox_JobBenefit.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox_JobBenefit.StateCommon.Border.ColorAngle = 45F;
            this.richTextBox_JobBenefit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.richTextBox_JobBenefit.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.richTextBox_JobBenefit.StateCommon.Border.Rounding = 20;
            this.richTextBox_JobBenefit.StateCommon.Border.Width = 1;
            this.richTextBox_JobBenefit.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.richTextBox_JobBenefit.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_JobBenefit.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.richTextBox_JobBenefit.TabIndex = 22;
            this.richTextBox_JobBenefit.Text = "";
            // 
            // label_CompanyType
            // 
            this.label_CompanyType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_CompanyType.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_CompanyType.Image = global::Job_Application_Management.Properties.Resources.icons8_request_32;
            this.label_CompanyType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_CompanyType.Location = new System.Drawing.Point(882, 503);
            this.label_CompanyType.Name = "label_CompanyType";
            this.label_CompanyType.Size = new System.Drawing.Size(361, 60);
            this.label_CompanyType.TabIndex = 5;
            this.label_CompanyType.Text = "Requirements        ";
            this.label_CompanyType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBox_Requirement
            // 
            this.richTextBox_Requirement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox_Requirement.Location = new System.Drawing.Point(1291, 459);
            this.richTextBox_Requirement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox_Requirement.Name = "richTextBox_Requirement";
            this.richTextBox_Requirement.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.richTextBox_Requirement.Size = new System.Drawing.Size(490, 149);
            this.richTextBox_Requirement.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.richTextBox_Requirement.StateActive.Content.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Requirement.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.richTextBox_Requirement.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox_Requirement.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox_Requirement.StateCommon.Border.ColorAngle = 45F;
            this.richTextBox_Requirement.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.richTextBox_Requirement.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.richTextBox_Requirement.StateCommon.Border.Rounding = 20;
            this.richTextBox_Requirement.StateCommon.Border.Width = 1;
            this.richTextBox_Requirement.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.richTextBox_Requirement.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Requirement.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.richTextBox_Requirement.TabIndex = 20;
            this.richTextBox_Requirement.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_Post);
            this.flowLayoutPanel1.Controls.Add(this.button_Delete);
            this.flowLayoutPanel1.Controls.Add(this.button_SeeCandidate);
            this.flowLayoutPanel1.Controls.Add(this.button_ApprovedCandidate);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 623);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1808, 106);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // button_Post
            // 
            this.button_Post.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Post.Location = new System.Drawing.Point(3, 2);
            this.button_Post.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Post.Name = "button_Post";
            this.button_Post.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_Post.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_Post.OverrideDefault.Back.ColorAngle = 45F;
            this.button_Post.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_Post.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_Post.OverrideDefault.Border.ColorAngle = 45F;
            this.button_Post.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_Post.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_Post.OverrideDefault.Border.Rounding = 20;
            this.button_Post.OverrideDefault.Border.Width = 1;
            this.button_Post.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button_Post.Size = new System.Drawing.Size(135, 100);
            this.button_Post.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.button_Post.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.button_Post.StateCommon.Back.ColorAngle = 45F;
            this.button_Post.StateCommon.Back.Image = global::Job_Application_Management.Properties.Resources.icons8_post_68;
            this.button_Post.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.button_Post.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_Post.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_Post.StateCommon.Border.ColorAngle = 45F;
            this.button_Post.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_Post.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_Post.StateCommon.Border.Rounding = 20;
            this.button_Post.StateCommon.Border.Width = 1;
            this.button_Post.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button_Post.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button_Post.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Post.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_Post.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_Post.StatePressed.Back.ColorAngle = 135F;
            this.button_Post.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_Post.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_Post.StatePressed.Border.ColorAngle = 135F;
            this.button_Post.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_Post.StatePressed.Border.Rounding = 20;
            this.button_Post.StatePressed.Border.Width = 1;
            this.button_Post.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_Post.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_Post.StateTracking.Back.ColorAngle = 45F;
            this.button_Post.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_Post.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_Post.StateTracking.Border.ColorAngle = 45F;
            this.button_Post.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_Post.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_Post.StateTracking.Border.Rounding = 20;
            this.button_Post.StateTracking.Border.Width = 1;
            this.button_Post.TabIndex = 16;
            this.button_Post.Values.Text = "";
            this.button_Post.Click += new System.EventHandler(this.button_Post_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(144, 2);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_Delete.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_Delete.OverrideDefault.Back.ColorAngle = 45F;
            this.button_Delete.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_Delete.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_Delete.OverrideDefault.Border.ColorAngle = 45F;
            this.button_Delete.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_Delete.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_Delete.OverrideDefault.Border.Rounding = 20;
            this.button_Delete.OverrideDefault.Border.Width = 1;
            this.button_Delete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button_Delete.Size = new System.Drawing.Size(111, 100);
            this.button_Delete.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.button_Delete.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.button_Delete.StateCommon.Back.ColorAngle = 45F;
            this.button_Delete.StateCommon.Back.Image = global::Job_Application_Management.Properties.Resources.icons8_delete_64;
            this.button_Delete.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.button_Delete.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.button_Delete.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_Delete.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_Delete.StateCommon.Border.ColorAngle = 45F;
            this.button_Delete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_Delete.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_Delete.StateCommon.Border.Rounding = 20;
            this.button_Delete.StateCommon.Border.Width = 1;
            this.button_Delete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button_Delete.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button_Delete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_Delete.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_Delete.StatePressed.Back.ColorAngle = 135F;
            this.button_Delete.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_Delete.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_Delete.StatePressed.Border.ColorAngle = 135F;
            this.button_Delete.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_Delete.StatePressed.Border.Rounding = 20;
            this.button_Delete.StatePressed.Border.Width = 1;
            this.button_Delete.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_Delete.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_Delete.StateTracking.Back.ColorAngle = 45F;
            this.button_Delete.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_Delete.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_Delete.StateTracking.Border.ColorAngle = 45F;
            this.button_Delete.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_Delete.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_Delete.StateTracking.Border.Rounding = 20;
            this.button_Delete.StateTracking.Border.Width = 1;
            this.button_Delete.TabIndex = 18;
            this.button_Delete.Values.Text = "";
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_SeeCandidate
            // 
            this.button_SeeCandidate.Location = new System.Drawing.Point(261, 2);
            this.button_SeeCandidate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_SeeCandidate.Name = "button_SeeCandidate";
            this.button_SeeCandidate.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_SeeCandidate.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_SeeCandidate.OverrideDefault.Back.ColorAngle = 45F;
            this.button_SeeCandidate.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_SeeCandidate.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_SeeCandidate.OverrideDefault.Border.ColorAngle = 45F;
            this.button_SeeCandidate.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_SeeCandidate.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_SeeCandidate.OverrideDefault.Border.Rounding = 20;
            this.button_SeeCandidate.OverrideDefault.Border.Width = 1;
            this.button_SeeCandidate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button_SeeCandidate.Size = new System.Drawing.Size(200, 100);
            this.button_SeeCandidate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_SeeCandidate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_SeeCandidate.StateCommon.Back.ColorAngle = 45F;
            this.button_SeeCandidate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_SeeCandidate.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_SeeCandidate.StateCommon.Border.ColorAngle = 45F;
            this.button_SeeCandidate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_SeeCandidate.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_SeeCandidate.StateCommon.Border.Rounding = 20;
            this.button_SeeCandidate.StateCommon.Border.Width = 1;
            this.button_SeeCandidate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button_SeeCandidate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button_SeeCandidate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SeeCandidate.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_SeeCandidate.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_SeeCandidate.StatePressed.Back.ColorAngle = 135F;
            this.button_SeeCandidate.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_SeeCandidate.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_SeeCandidate.StatePressed.Border.ColorAngle = 135F;
            this.button_SeeCandidate.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_SeeCandidate.StatePressed.Border.Rounding = 20;
            this.button_SeeCandidate.StatePressed.Border.Width = 1;
            this.button_SeeCandidate.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_SeeCandidate.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_SeeCandidate.StateTracking.Back.ColorAngle = 45F;
            this.button_SeeCandidate.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_SeeCandidate.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_SeeCandidate.StateTracking.Border.ColorAngle = 45F;
            this.button_SeeCandidate.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_SeeCandidate.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_SeeCandidate.StateTracking.Border.Rounding = 20;
            this.button_SeeCandidate.StateTracking.Border.Width = 1;
            this.button_SeeCandidate.TabIndex = 20;
            this.button_SeeCandidate.Values.Text = "Applied: ";
            this.button_SeeCandidate.Visible = false;
            this.button_SeeCandidate.Click += new System.EventHandler(this.button_SeeCandidate_Click);
            // 
            // button_ApprovedCandidate
            // 
            this.button_ApprovedCandidate.Location = new System.Drawing.Point(467, 2);
            this.button_ApprovedCandidate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ApprovedCandidate.Name = "button_ApprovedCandidate";
            this.button_ApprovedCandidate.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_ApprovedCandidate.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_ApprovedCandidate.OverrideDefault.Back.ColorAngle = 45F;
            this.button_ApprovedCandidate.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_ApprovedCandidate.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_ApprovedCandidate.OverrideDefault.Border.ColorAngle = 45F;
            this.button_ApprovedCandidate.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_ApprovedCandidate.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_ApprovedCandidate.OverrideDefault.Border.Rounding = 20;
            this.button_ApprovedCandidate.OverrideDefault.Border.Width = 1;
            this.button_ApprovedCandidate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button_ApprovedCandidate.Size = new System.Drawing.Size(230, 100);
            this.button_ApprovedCandidate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_ApprovedCandidate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_ApprovedCandidate.StateCommon.Back.ColorAngle = 45F;
            this.button_ApprovedCandidate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_ApprovedCandidate.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_ApprovedCandidate.StateCommon.Border.ColorAngle = 45F;
            this.button_ApprovedCandidate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_ApprovedCandidate.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_ApprovedCandidate.StateCommon.Border.Rounding = 20;
            this.button_ApprovedCandidate.StateCommon.Border.Width = 1;
            this.button_ApprovedCandidate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button_ApprovedCandidate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button_ApprovedCandidate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ApprovedCandidate.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_ApprovedCandidate.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_ApprovedCandidate.StatePressed.Back.ColorAngle = 135F;
            this.button_ApprovedCandidate.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_ApprovedCandidate.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_ApprovedCandidate.StatePressed.Border.ColorAngle = 135F;
            this.button_ApprovedCandidate.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_ApprovedCandidate.StatePressed.Border.Rounding = 20;
            this.button_ApprovedCandidate.StatePressed.Border.Width = 1;
            this.button_ApprovedCandidate.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_ApprovedCandidate.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_ApprovedCandidate.StateTracking.Back.ColorAngle = 45F;
            this.button_ApprovedCandidate.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_ApprovedCandidate.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_ApprovedCandidate.StateTracking.Border.ColorAngle = 45F;
            this.button_ApprovedCandidate.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_ApprovedCandidate.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_ApprovedCandidate.StateTracking.Border.Rounding = 20;
            this.button_ApprovedCandidate.StateTracking.Border.Width = 1;
            this.button_ApprovedCandidate.TabIndex = 19;
            this.button_ApprovedCandidate.Values.Text = "Approved: ";
            this.button_ApprovedCandidate.Visible = false;
            this.button_ApprovedCandidate.Click += new System.EventHandler(this.button_ApprovedCandidate_Click);
            // 
            // FEmployer_JobDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1807, 745);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel_Information);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FEmployer_JobDetail";
            this.ShowIcon = false;
            this.Text = "Job Detail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FEmployer_JobDetail_Load);
            this.tableLayoutPanel_Information.ResumeLayout(false);
            this.tableLayoutPanel_Information.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Information;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Deadline;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_CompanyType;
        private System.Windows.Forms.Label label__Benefit;
        private System.Windows.Forms.Label label_Experience;
        private System.Windows.Forms.Label label_Salary;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_JobName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_Salary;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_WorkingTime;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_Experience;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox richTextBox_Requirement;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox richTextBox_JobDescripton;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox richTextBox_JobBenefit;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateTimePicker_Deadline;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_Post;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_Delete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_SeeCandidate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_ApprovedCandidate;
    }
}