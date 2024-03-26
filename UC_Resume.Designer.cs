namespace Job_Application_Management
{
    partial class UC_Resume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Resume));
            this.flpInfos = new System.Windows.Forms.TableLayoutPanel();
            this.label_CandidateName = new System.Windows.Forms.Label();
            this.label_Nominee = new System.Windows.Forms.Label();
            this.flpInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Phone = new System.Windows.Forms.Label();
            this.textBox_Phone = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_Email = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.textBox_Address = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.flpGoal = new System.Windows.Forms.FlowLayoutPanel();
            this.label_CareerObjective = new System.Windows.Forms.Label();
            this.richTextBox_CareerObjective = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.flowLayoutPanel_Education = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Education = new System.Windows.Forms.Label();
            this.button_AddEducation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.uC_Resume_Education1 = new Job_Application_Management.UC_Resume_Education();
            this.flowLayoutPanel_Experience = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_JobExperience = new System.Windows.Forms.Label();
            this.button_AddExperience = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.uC_Resume_Experience1 = new Job_Application_Management.UC_Resume_Experience();
            this.flowLayoutPanel_Certificate = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Certificate = new System.Windows.Forms.Label();
            this.button_AddCertification = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.uC_Resume_Certificate1 = new Job_Application_Management.UC_Resume_Certificate();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel_Education.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel_Experience.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel_Certificate.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpInfos
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label_CandidateName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Nominee, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.6722F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.13278F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1674, 198);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label_CandidateName
            // 
            this.label_CandidateName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_CandidateName.AutoSize = true;
            this.label_CandidateName.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.label_CandidateName.Location = new System.Drawing.Point(688, 11);
            this.label_CandidateName.Name = "label_CandidateName";
            this.label_CandidateName.Size = new System.Drawing.Size(239, 36);
            this.label_CandidateName.TabIndex = 0;
            this.label_CandidateName.Text = "Candidate Name";
            // 
            // label_Nominee
            // 
            this.label_Nominee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Nominee.AutoSize = true;
            this.label_Nominee.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nominee.Location = new System.Drawing.Point(727, 69);
            this.label_Nominee.Name = "label_Nominee";
            this.label_Nominee.Size = new System.Drawing.Size(186, 23);
            this.label_Nominee.TabIndex = 1;
            this.label_Nominee.Text = "Vi tri ung tuyen";
            // 
            // flpInfo
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.label_Phone);
            this.flowLayoutPanel1.Controls.Add(this.textBox_Phone);
            this.flowLayoutPanel1.Controls.Add(this.label_Email);
            this.flowLayoutPanel1.Controls.Add(this.textBox_Email);
            this.flowLayoutPanel1.Controls.Add(this.label_Address);
            this.flowLayoutPanel1.Controls.Add(this.textBox_Address);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(157, 113);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1359, 73);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label_Phone
            // 
            this.label_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Consolas", 16F);
            this.label_Phone.Image = global::Job_Application_Management.Properties.Resources.icons8_phone_30;
            this.label_Phone.Location = new System.Drawing.Point(3, 9);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(29, 32);
            this.label_Phone.TabIndex = 1;
            this.label_Phone.Text = " ";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Phone.Location = new System.Drawing.Point(38, 2);
            this.textBox_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(235, 47);
            this.textBox_Phone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_Phone.StateCommon.Border.Rounding = 20;
            this.textBox_Phone.StateCommon.Border.Width = 1;
            this.textBox_Phone.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Phone.TabIndex = 0;
            this.textBox_Phone.Text = "0705488458";
            // 
            // label_Email
            // 
            this.label_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Consolas", 16F);
            this.label_Email.Image = global::Job_Application_Management.Properties.Resources.icons8_email_301;
            this.label_Email.Location = new System.Drawing.Point(279, 9);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(29, 32);
            this.label_Email.TabIndex = 2;
            this.label_Email.Text = " ";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Email.Location = new System.Drawing.Point(314, 2);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(428, 47);
            this.textBox_Email.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_Email.StateCommon.Border.Rounding = 20;
            this.textBox_Email.StateCommon.Border.Width = 1;
            this.textBox_Email.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.TabIndex = 3;
            this.textBox_Email.Text = "22110260@student.hcmute.edu.vn";
            // 
            // label_Address
            // 
            this.label_Address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Consolas", 16F);
            this.label_Address.Image = global::Job_Application_Management.Properties.Resources.icons8_address_30;
            this.label_Address.Location = new System.Drawing.Point(748, 9);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(29, 32);
            this.label_Address.TabIndex = 4;
            this.label_Address.Text = " ";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Address.Location = new System.Drawing.Point(783, 2);
            this.textBox_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(415, 47);
            this.textBox_Address.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_Address.StateCommon.Border.Rounding = 20;
            this.textBox_Address.StateCommon.Border.Width = 1;
            this.textBox_Address.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Address.TabIndex = 5;
            this.textBox_Address.Text = "Thuan An, Binh Duong";
            // 
            // flpGoal
            // 
            this.flowLayoutPanel2.Controls.Add(this.label_CareerObjective);
            this.flowLayoutPanel2.Controls.Add(this.richTextBox_CareerObjective);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 198);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1674, 223);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label_CareerObjective
            // 
            this.label_CareerObjective.AutoSize = true;
            this.label_CareerObjective.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CareerObjective.Location = new System.Drawing.Point(12, 8);
            this.label_CareerObjective.Name = "label_CareerObjective";
            this.label_CareerObjective.Size = new System.Drawing.Size(314, 32);
            this.label_CareerObjective.TabIndex = 0;
            this.label_CareerObjective.Text = "Muc tieu nghe nghiep";
            // 
            // richTextBox_CareerObjective
            // 
            this.richTextBox_CareerObjective.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBox_CareerObjective.Location = new System.Drawing.Point(332, 10);
            this.richTextBox_CareerObjective.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox_CareerObjective.Name = "richTextBox_CareerObjective";
            this.richTextBox_CareerObjective.Size = new System.Drawing.Size(1191, 127);
            this.richTextBox_CareerObjective.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.richTextBox_CareerObjective.StateCommon.Border.Rounding = 20;
            this.richTextBox_CareerObjective.StateCommon.Border.Width = 1;
            this.richTextBox_CareerObjective.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_CareerObjective.TabIndex = 1;
            this.richTextBox_CareerObjective.Text = resources.GetString("richTextBox_CareerObjective.Text");
            // 
            // flowLayoutPanel_Education
            // 
            this.flowLayoutPanel_Education.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel_Education.Controls.Add(this.uC_Resume_Education1);
            this.flowLayoutPanel_Education.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel_Education.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Education.Location = new System.Drawing.Point(0, 421);
            this.flowLayoutPanel_Education.Name = "flowLayoutPanel_Education";
            this.flowLayoutPanel_Education.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel_Education.Size = new System.Drawing.Size(1674, 396);
            this.flowLayoutPanel_Education.TabIndex = 3;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label_Education);
            this.flowLayoutPanel4.Controls.Add(this.button_AddEducation);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(507, 50);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // label_Education
            // 
            this.label_Education.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Education.AutoSize = true;
            this.label_Education.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Education.Location = new System.Drawing.Point(3, 4);
            this.label_Education.Name = "label_Education";
            this.label_Education.Size = new System.Drawing.Size(119, 32);
            this.label_Education.TabIndex = 0;
            this.label_Education.Text = "Hoc van";
            // 
            // button_AddEducation
            // 
            this.button_AddEducation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_AddEducation.Location = new System.Drawing.Point(152, 3);
            this.button_AddEducation.Name = "button_AddEducation";
            this.button_AddEducation.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddEducation.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_AddEducation.OverrideDefault.Back.ColorAngle = 45F;
            this.button_AddEducation.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddEducation.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_AddEducation.OverrideDefault.Border.ColorAngle = 45F;
            this.button_AddEducation.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_AddEducation.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_AddEducation.OverrideDefault.Border.Rounding = 20;
            this.button_AddEducation.OverrideDefault.Border.Width = 1;
            this.button_AddEducation.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button_AddEducation.Size = new System.Drawing.Size(57, 45);
            this.button_AddEducation.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddEducation.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_AddEducation.StateCommon.Back.ColorAngle = 45F;
            this.button_AddEducation.StateCommon.Back.Image = global::Job_Application_Management.Properties.Resources.icons8_add_30;
            this.button_AddEducation.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.button_AddEducation.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddEducation.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_AddEducation.StateCommon.Border.ColorAngle = 45F;
            this.button_AddEducation.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_AddEducation.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_AddEducation.StateCommon.Border.Rounding = 20;
            this.button_AddEducation.StateCommon.Border.Width = 1;
            this.button_AddEducation.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button_AddEducation.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button_AddEducation.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddEducation.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_AddEducation.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_AddEducation.StatePressed.Back.ColorAngle = 135F;
            this.button_AddEducation.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_AddEducation.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_AddEducation.StatePressed.Border.ColorAngle = 135F;
            this.button_AddEducation.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_AddEducation.StatePressed.Border.Rounding = 20;
            this.button_AddEducation.StatePressed.Border.Width = 1;
            this.button_AddEducation.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_AddEducation.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddEducation.StateTracking.Back.ColorAngle = 45F;
            this.button_AddEducation.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddEducation.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_AddEducation.StateTracking.Border.ColorAngle = 45F;
            this.button_AddEducation.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_AddEducation.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_AddEducation.StateTracking.Border.Rounding = 20;
            this.button_AddEducation.StateTracking.Border.Width = 1;
            this.button_AddEducation.TabIndex = 18;
            this.button_AddEducation.Values.Text = "";
            this.button_AddEducation.Click += new System.EventHandler(this.button_AddEducation_Click);
            // 
            // uC_Resume_Education1
            // 
            this.uC_Resume_Education1.Location = new System.Drawing.Point(12, 64);
            this.uC_Resume_Education1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Resume_Education1.Name = "uC_Resume_Education1";
            this.uC_Resume_Education1.Padding = new System.Windows.Forms.Padding(10);
            this.uC_Resume_Education1.Size = new System.Drawing.Size(1288, 300);
            this.uC_Resume_Education1.TabIndex = 2;
            // 
            // flowLayoutPanel_Experience
            // 
            this.flowLayoutPanel_Experience.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel_Experience.Controls.Add(this.uC_Resume_Experience1);
            this.flowLayoutPanel_Experience.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel_Experience.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Experience.Location = new System.Drawing.Point(0, 817);
            this.flowLayoutPanel_Experience.Name = "flowLayoutPanel_Experience";
            this.flowLayoutPanel_Experience.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel_Experience.Size = new System.Drawing.Size(1674, 381);
            this.flowLayoutPanel_Experience.TabIndex = 4;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label_JobExperience);
            this.flowLayoutPanel6.Controls.Add(this.button_AddExperience);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(507, 50);
            this.flowLayoutPanel6.TabIndex = 1;
            // 
            // label_JobExperience
            // 
            this.label_JobExperience.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_JobExperience.AutoSize = true;
            this.label_JobExperience.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_JobExperience.Location = new System.Drawing.Point(3, 4);
            this.label_JobExperience.Name = "label_JobExperience";
            this.label_JobExperience.Size = new System.Drawing.Size(314, 32);
            this.label_JobExperience.TabIndex = 0;
            this.label_JobExperience.Text = "Kinh nghiem lam viec";
            // 
            // button_AddExperience
            // 
            this.button_AddExperience.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_AddExperience.Location = new System.Drawing.Point(386, 3);
            this.button_AddExperience.Name = "button_AddExperience";
            this.button_AddExperience.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddExperience.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_AddExperience.OverrideDefault.Back.ColorAngle = 45F;
            this.button_AddExperience.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddExperience.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_AddExperience.OverrideDefault.Border.ColorAngle = 45F;
            this.button_AddExperience.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_AddExperience.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_AddExperience.OverrideDefault.Border.Rounding = 20;
            this.button_AddExperience.OverrideDefault.Border.Width = 1;
            this.button_AddExperience.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button_AddExperience.Size = new System.Drawing.Size(57, 45);
            this.button_AddExperience.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddExperience.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_AddExperience.StateCommon.Back.ColorAngle = 45F;
            this.button_AddExperience.StateCommon.Back.Image = global::Job_Application_Management.Properties.Resources.icons8_add_30;
            this.button_AddExperience.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.button_AddExperience.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddExperience.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_AddExperience.StateCommon.Border.ColorAngle = 45F;
            this.button_AddExperience.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_AddExperience.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_AddExperience.StateCommon.Border.Rounding = 20;
            this.button_AddExperience.StateCommon.Border.Width = 1;
            this.button_AddExperience.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button_AddExperience.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button_AddExperience.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddExperience.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_AddExperience.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_AddExperience.StatePressed.Back.ColorAngle = 135F;
            this.button_AddExperience.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_AddExperience.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_AddExperience.StatePressed.Border.ColorAngle = 135F;
            this.button_AddExperience.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_AddExperience.StatePressed.Border.Rounding = 20;
            this.button_AddExperience.StatePressed.Border.Width = 1;
            this.button_AddExperience.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_AddExperience.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddExperience.StateTracking.Back.ColorAngle = 45F;
            this.button_AddExperience.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddExperience.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_AddExperience.StateTracking.Border.ColorAngle = 45F;
            this.button_AddExperience.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_AddExperience.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_AddExperience.StateTracking.Border.Rounding = 20;
            this.button_AddExperience.StateTracking.Border.Width = 1;
            this.button_AddExperience.TabIndex = 18;
            this.button_AddExperience.Values.Text = "";
            this.button_AddExperience.Click += new System.EventHandler(this.button_AddExperience_Click);
            // 
            // uC_Resume_Experience1
            // 
            this.uC_Resume_Experience1.Location = new System.Drawing.Point(12, 64);
            this.uC_Resume_Experience1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Resume_Experience1.Name = "uC_Resume_Experience1";
            this.uC_Resume_Experience1.Padding = new System.Windows.Forms.Padding(10);
            this.uC_Resume_Experience1.Size = new System.Drawing.Size(1293, 284);
            this.uC_Resume_Experience1.TabIndex = 2;
            // 
            // flowLayoutPanel_Certificate
            // 
            this.flowLayoutPanel_Certificate.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel_Certificate.Controls.Add(this.uC_Resume_Certificate1);
            this.flowLayoutPanel_Certificate.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel_Certificate.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Certificate.Location = new System.Drawing.Point(0, 1198);
            this.flowLayoutPanel_Certificate.Name = "flowLayoutPanel_Certificate";
            this.flowLayoutPanel_Certificate.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel_Certificate.Size = new System.Drawing.Size(1674, 197);
            this.flowLayoutPanel_Certificate.TabIndex = 5;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.label_Certificate);
            this.flowLayoutPanel8.Controls.Add(this.button_AddCertification);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(507, 50);
            this.flowLayoutPanel8.TabIndex = 1;
            // 
            // label_Certificate
            // 
            this.label_Certificate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Certificate.AutoSize = true;
            this.label_Certificate.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Certificate.Location = new System.Drawing.Point(3, 4);
            this.label_Certificate.Name = "label_Certificate";
            this.label_Certificate.Size = new System.Drawing.Size(149, 32);
            this.label_Certificate.TabIndex = 0;
            this.label_Certificate.Text = "Chung chi";
            // 
            // button_AddCertification
            // 
            this.button_AddCertification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_AddCertification.Location = new System.Drawing.Point(188, 3);
            this.button_AddCertification.Name = "button_AddCertification";
            this.button_AddCertification.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddCertification.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_AddCertification.OverrideDefault.Back.ColorAngle = 45F;
            this.button_AddCertification.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddCertification.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_AddCertification.OverrideDefault.Border.ColorAngle = 45F;
            this.button_AddCertification.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_AddCertification.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_AddCertification.OverrideDefault.Border.Rounding = 20;
            this.button_AddCertification.OverrideDefault.Border.Width = 1;
            this.button_AddCertification.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button_AddCertification.Size = new System.Drawing.Size(57, 45);
            this.button_AddCertification.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddCertification.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_AddCertification.StateCommon.Back.ColorAngle = 45F;
            this.button_AddCertification.StateCommon.Back.Image = global::Job_Application_Management.Properties.Resources.icons8_add_30;
            this.button_AddCertification.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.button_AddCertification.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddCertification.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_AddCertification.StateCommon.Border.ColorAngle = 45F;
            this.button_AddCertification.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_AddCertification.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_AddCertification.StateCommon.Border.Rounding = 20;
            this.button_AddCertification.StateCommon.Border.Width = 1;
            this.button_AddCertification.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button_AddCertification.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button_AddCertification.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddCertification.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_AddCertification.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_AddCertification.StatePressed.Back.ColorAngle = 135F;
            this.button_AddCertification.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button_AddCertification.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button_AddCertification.StatePressed.Border.ColorAngle = 135F;
            this.button_AddCertification.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_AddCertification.StatePressed.Border.Rounding = 20;
            this.button_AddCertification.StatePressed.Border.Width = 1;
            this.button_AddCertification.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_AddCertification.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddCertification.StateTracking.Back.ColorAngle = 45F;
            this.button_AddCertification.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_AddCertification.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            this.button_AddCertification.StateTracking.Border.ColorAngle = 45F;
            this.button_AddCertification.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_AddCertification.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_AddCertification.StateTracking.Border.Rounding = 20;
            this.button_AddCertification.StateTracking.Border.Width = 1;
            this.button_AddCertification.TabIndex = 18;
            this.button_AddCertification.Values.Text = "";
            this.button_AddCertification.Click += new System.EventHandler(this.button_AddCertification_Click);
            // 
            // uC_Resume_Certificate1
            // 
            this.uC_Resume_Certificate1.Location = new System.Drawing.Point(12, 64);
            this.uC_Resume_Certificate1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Resume_Certificate1.Name = "uC_Resume_Certificate1";
            this.uC_Resume_Certificate1.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.uC_Resume_Certificate1.Size = new System.Drawing.Size(1146, 70);
            this.uC_Resume_Certificate1.TabIndex = 2;
            // 
            // UC_Resume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flowLayoutPanel_Certificate);
            this.Controls.Add(this.flowLayoutPanel_Experience);
            this.Controls.Add(this.flowLayoutPanel_Education);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_Resume";
            this.Size = new System.Drawing.Size(1674, 1447);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel_Education.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel_Experience.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel_Certificate.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel flpInfos;
        private System.Windows.Forms.Label label_CandidateName;
        private System.Windows.Forms.Label label_Nominee;
        private System.Windows.Forms.FlowLayoutPanel flpInfo;
        private System.Windows.Forms.Label label_Phone;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_Phone;
        private System.Windows.Forms.Label label_Email;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_Email;
        private System.Windows.Forms.Label label_Address;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_Address;
        private System.Windows.Forms.FlowLayoutPanel flpGoal;
        private System.Windows.Forms.Label label_CareerObjective;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox richTextBox_CareerObjective;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Education;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label_Education;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_AddEducation;
        private UC_Resume_Education uC_Resume_Education1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Experience;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label_JobExperience;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_AddExperience;
        private UC_Resume_Experience uC_Resume_Experience1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Certificate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label_Certificate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_AddCertification;
        private UC_Resume_Certificate uC_Resume_Certificate1;

        /*private System.Windows.Forms.TableLayoutPanel FlpInfos;
        private System.Windows.Forms.Label Label_CandidateName;
        private System.Windows.Forms.Label Label_Nominee;
        private System.Windows.Forms.FlowLayoutPanel FlpInfo;
        private System.Windows.Forms.Label Label_Phone;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_Phone;
        private System.Windows.Forms.Label Label_Email;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_Email;
        private System.Windows.Forms.Label Label_Address;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_Address;
        private System.Windows.Forms.FlowLayoutPanel FlpGoal;
        private System.Windows.Forms.Label Label_CareerObjective;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox RichTextBox_CareerObjective;
        private System.Windows.Forms.FlowLayoutPanel FlpEducation;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel4;
        private System.Windows.Forms.Label Label_Education;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Button_Save;
        private UC_Resume_Education UC_Resume_Education1;
        private System.Windows.Forms.FlowLayoutPanel FlpExperience;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel6;
        private System.Windows.Forms.Label Label_JobExperience;
        private ComponentFactory.Krypton.Toolkit.KryptonButton KryptonButton1;
        private UC_Resume_Experience UC_Resume_Experience1;
        private System.Windows.Forms.FlowLayoutPanel FlpCC;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel8;
        private System.Windows.Forms.Label Label_Certificate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton KryptonButton2;
        private UC_Resume_Certificate UC_Resume_Certificate1;*/
    }
}
