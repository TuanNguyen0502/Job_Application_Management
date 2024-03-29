﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public partial class UC_JobsSaved : UserControl
    {
        #region Properties
        private string descriptionJob;
        private string comName;
        private DateTime timeSaved;
        private string address;
        private string timeUpdate;
        private int salary;
        private Image icon;
        private string jobId;
        public string DescriptionJob 
        { 
            get => descriptionJob;
            set { descriptionJob = value; lblDescrption.Text = value; }
        }
        public string ComName 
        { 
            get => comName; 
            set { comName = value; lblComName.Text = value; } 
        }
        public DateTime TimeSaved 
        {   
            get => timeSaved;
            set { timeSaved = value; lblTimeSaved.Text = $"Đã lưu: {value}"; }
        }
        public string Address 
        { 
            get => address;
            set { address = value; lblAddress.Text = $"{     value}"; }
        }
        public int Salary 
        { 
            get => salary;
            set { salary = value; lblComName.Text = $"       { value.ToString()}"; }
        }
        public Image Icon 
        { 
            get => icon;
            set { icon = value; pictureBox1.Image = value; }
        }
        public string JobID
        {
            get { return jobId; }
            set { jobId = value; }
        }
        #endregion
        public UC_JobsSaved()
        {
            InitializeComponent();
            InitializeToolTip();
        }
        private void UC_Candidate_Load(object sender, EventArgs e)
        {

        }

        private void InitializeToolTip()
        {
            ToolTip toolTipMain = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTipMain.AutoPopDelay = 5000;
            toolTipMain.InitialDelay = 1000;
            toolTipMain.ReshowDelay = 500;

            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTipMain.ShowAlways = true;

            // Set up the ToolTip text for the Button and TextBox.
            toolTipMain.SetToolTip(this.btnRusbish, "Bỏ qua");
            toolTipMain.SetToolTip(this.btnAdd, "Lưu");
        }

    }
}
