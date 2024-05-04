using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public partial class FEmployer_JobDetail : Form
    {
        private int jobID;
        private string empID;
        private int numberAppliedCandidates;
        private int numberApproveCandidates;
        private EmployerDAO employerDAO = new EmployerDAO();

        public int JobID { get => jobID; set => jobID = value; }

        public FEmployer_JobDetail(int ID, string empID, int numberAppliedCandidates, int numberApproveCandidates)
        {
            InitializeComponent();
            this.jobID = ID;
            this.empID = empID;
            this.numberAppliedCandidates = numberAppliedCandidates;
            this.numberApproveCandidates = numberApproveCandidates;
        }

        private void LoadButton()
        {
            if (this.numberAppliedCandidates > 0)
            {
                button_SeeCandidate.Visible = true;
                button_SeeCandidate.Text += numberAppliedCandidates;
            }
            if (this.numberApproveCandidates > 0)
            {
                button_ApprovedCandidate.Visible = true;
                button_ApprovedCandidate.Text += numberApproveCandidates;
            }
        }

        private void button_SeeCandidate_Click(object sender, EventArgs e)
        {
            FEmployer_SeeCandidate fEmployer_SeeCandidate = new FEmployer_SeeCandidate(empID, JobID);
            fEmployer_SeeCandidate.ShowDialog();
            if (fEmployer_SeeCandidate.DialogResult == DialogResult.OK)
            {
                LoadButton();
            }
        }

        private void button_ApprovedCandidate_Click(object sender, EventArgs e)
        {
            FEmployer_ApprovedCandidate fEmployer_ApprovedCandidate = new FEmployer_ApprovedCandidate(empID, JobID);
            fEmployer_ApprovedCandidate.ShowDialog();
            if (fEmployer_ApprovedCandidate.DialogResult == DialogResult.OK)
            {
                LoadButton();
            }
        }

        private void FEmployer_JobDetail_Load(object sender, EventArgs e)
        {
            LoadInfor();
            LoadButton();
        }

        private void LoadInfor()
        {
            if (JobID != 0)
            {
                Job job = employerDAO.GetJobFromDB(JobID);
                textBox_JobName.Text = job.Name;
                textBox_Salary.Text = job.Salary.ToString();
                richTextBox_JobDescripton.Text = job.JobDescription;
                textBox_WorkingTime.Text = job.WorkDuration;
                textBox_Experience.Text = job.Experience;
                dateTimePicker_Deadline.Value = job.Deadline;
                richTextBox_JobBenefit.Text = job.Benefit;
                richTextBox_Requirement.Text = job.Request;
            }
            else
            {
                button_Delete.Visible = false;
            }
        }

        private void button_Post_Click(object sender, EventArgs e)
        {
            if (JobID == 0)
            {
                Job job = CreateJob();
                if (job.CheckAllCondition())
                {
                    employerDAO.AddJob(CreateJob());
                    this.Close();
                }
            }
            else
            {
                Job job = GetCurrentJob();
                if (job.CheckAllCondition())
                {
                    employerDAO.UpdateJob(GetCurrentJob());
                    this.Close();
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private Job GetCurrentJob()
        {
            Job job = new Job(JobID, textBox_JobName.Text, Convert.ToInt32(textBox_Salary.Text), richTextBox_JobDescripton.Text,
                   textBox_WorkingTime.Text, textBox_Experience.Text, dateTimePicker_Deadline.Value, richTextBox_JobBenefit.Text,
                    richTextBox_Requirement.Text, empID);
            return job;
        }

        private Job CreateJob()
        {
            Job job = new Job(textBox_JobName.Text, Convert.ToInt32(textBox_Salary.Text), richTextBox_JobDescripton.Text,
                textBox_WorkingTime.Text, textBox_Experience.Text, dateTimePicker_Deadline.Value, richTextBox_JobBenefit.Text,
                richTextBox_Requirement.Text, empID);
            return job;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (JobID != 0)
            {
                employerDAO.DeleteJob(GetCurrentJob().Id.ToString());
                this.Close();
            }
        }
    }
}
