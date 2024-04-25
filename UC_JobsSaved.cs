using System;
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
        public Button BtnAdd
        {
            get { return btnAdd; }
        }
        public Button BtnRusbish
        {
            get { return btnRusbish; }
        }
        private SavedJobs savedJob;
        public SavedJobs SavedJob
        {
            get { return savedJob; }
            set { savedJob = value; }
        }
        public UC_JobsSaved(SavedJobs savedJob)
        {
            InitializeComponent();
            InitializeToolTip();
            this.savedJob = savedJob;
        }
        private void UC_Candidate_Load(object sender, EventArgs e)
        {
            lblDescrption.Text = savedJob.JobDescription;
            lblComName.Text = $"     savedJob.CompanyName";
            lblTimeSaved.Text = $"Đã đăng: {savedJob.TimeSaved.ToShortDateString()}";
            lbl_TimePost.Text = $"Đã đăng: {savedJob.PostTime}";
            lblAddress.Text = $"      {savedJob.Address}";
            lblSalary.Text = savedJob.Salary.ToString();
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

        public event EventHandler<ButtonClickEventArgs> ButtonAddClick;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ButtonAddClick?.Invoke(this, new ButtonClickEventArgs(null,savedJob.Id));
        }
        public event EventHandler<ButtonClickEventArgs> ButtonRusbishClick;
        private void btnRusbish_Click(object sender, EventArgs e)
        {
            ButtonRusbishClick?.Invoke(this, new ButtonClickEventArgs(savedJob.SavedJobID.ToString(),0));
        }
    }
}
