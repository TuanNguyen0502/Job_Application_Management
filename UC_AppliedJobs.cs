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
    public partial class UC_AppliedJobs : UserControl
    {
        public Button BtnRusbish
        {
            get { return btnRusbish; }
        }
        private AppliedJobs appliedJob;
        public AppliedJobs AppliedJobs
        {
            get { return appliedJob; }
            set { appliedJob = value; }
        }
        public UC_AppliedJobs(AppliedJobs appliedJob)
        {
            InitializeComponent();
            this.appliedJob = appliedJob;
        }
        private void UC_AppliedJobs_Load(object sender, EventArgs e)
        {
            lblDescrption.Text = appliedJob.JobDescription;
            lblComName.Text = $"      {appliedJob.CompanyName}";
            lblTimeSaved.Text = $"Đã ứng tuyển: {appliedJob.TimeApplied}";
            lbl_PostTime.Text = $"Đã đăng: {appliedJob.PostTime}";
            lblAddress.Text = $"      {appliedJob.Address}";
            lblSalary.Text = $"       {appliedJob.Salary.ToString()}";
        }

        public event EventHandler ButtonAddClick;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ButtonAddClick?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler<ButtonClickEventArgs> ButtonRusbishClick;
        private void btnRusbish_Click(object sender, EventArgs e)
        {
            ButtonRusbishClick?.Invoke(this, new ButtonClickEventArgs(appliedJob.AppliedJobID.ToString(),0));
        }
        
    }
}
