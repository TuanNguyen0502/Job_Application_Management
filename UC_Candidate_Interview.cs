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
    public partial class UC_Candidate_Interview : UserControl
    {
        private Job job;
        private Interview interview;
        private Candidate can;
        private string role;
        public UC_Candidate_Interview(Job job, Interview interview, Candidate can, string role)
        {
            InitializeComponent();
            this.job = job;
            this.interview = interview;
            this.can=can;
            this.role=role;
            if (role == "Interview")
            {
                SetValueForControls();
            }
            else
            {
                SetValueForControlsOfCV();
            }
        }
        public void SetValueForControls()
        {
            lbl_CompanyName.Text = job.CompanyName;
            label_JobName.Text = job.Name;
            label_InterviewTime.Text = interview.InterviewTime.ToLongDateString();
            label_Note.Text = interview.Note;
        }
        public void SetValueForControlsOfCV()
        {
            lbl_CompanyName.Text = job.CompanyName;
            label_JobName.Text = can.Nominee;
            label_InterviewTime.Text = interview.InterviewTime.ToLongDateString();
            label_Note.Text = interview.Note;
        }
        public event EventHandler<ClickInterviews> SeeInterview_Click;
        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            SeeInterview_Click?.Invoke(this, new ClickInterviews(can.Name,job.CompanyName,job.Name,interview.InterviewTime,interview.Note));
        }
    }
}
