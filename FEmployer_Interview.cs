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
    public partial class FEmployer_Interview : Form
    {
        private string empID;
        private string cddID;
        private int jobID;
        private string jobName;
        private Interview interview;
        private EmployerDAO employerDAO = new EmployerDAO();

        public FEmployer_Interview(string empID, string cddID, int jobID)
        {
            this.empID = empID;
            this.cddID = cddID;
            this.jobID = jobID;
            interview = employerDAO.GetInterviewFormDB(empID, cddID, jobID);
            InitializeComponent();
        }
        public FEmployer_Interview(int id, string empID, string cddID, string jobName)
        {
            this.empID = empID;
            this.cddID = cddID;
            this.jobID = 0;
            this.jobName = jobName;
            interview = employerDAO.GetInterviewByCVFromDB(id, empID, cddID);
            InitializeComponent();
        }
        public FEmployer_Interview(string empID, string cddID, string jobName)
        {
            this.empID = empID;
            this.cddID = cddID;
            this.jobID = 0;
            this.jobName = jobName;
            interview = employerDAO.GetInterviewByCVFromDB(0, empID, cddID);
            InitializeComponent();
        }

        private bool CheckInterviewTime(DateTime interviewTime)
        {
            if (employerDAO.CheckEmployerInterviewTimeExists(interviewTime, empID))
            {
                MessageBox.Show("Employer has an interview at this time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (employerDAO.CheckCandidateInterviewTimeExists(interviewTime, cddID))
            {
                MessageBox.Show("Candidate has an interview at this time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (employerDAO.CheckEmployerInterviewByCVTimeExists(interviewTime, empID))
            {
                MessageBox.Show("Employer has an interview at this time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (employerDAO.CheckCandidateInterviewByCVTimeExists(interviewTime, cddID))
            {
                MessageBox.Show("Candidate has an interview at this time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button_Invite_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime(dateTimePicker_Date.Value.Year, dateTimePicker_Date.Value.Month, dateTimePicker_Date.Value.Day,
                dateTimePicker_Time.Value.Hour, dateTimePicker_Time.Value.Minute, dateTimePicker_Time.Value.Second);

            if (!CheckInterviewTime(dateTime))
            {
                return;
            }
            if (jobID == 0)
            {
                Interview interview = new Interview(empID, cddID, jobName, dateTime, textBox_Note.Text);
                employerDAO.AddInterviewByCV(interview);
            }
            else
            {
                Interview interview = new Interview(empID, cddID, jobID, dateTime, textBox_Note.Text);
                employerDAO.AddInterview(interview);
            }
        }

        private void FEmployer_Interview_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (interview.Id != 0)
            {
                label_Job.Text = interview.JobName;
                dateTimePicker_Date.Value = interview.InterviewTime;
                dateTimePicker_Time.Value = interview.InterviewTime;
                textBox_Note.Text = interview.Note;
                button_Invite.Visible = false;
            }
            else
            {
                button_Update.Visible = false;
                button_Delete.Visible = false;
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime(dateTimePicker_Date.Value.Year, dateTimePicker_Date.Value.Month, dateTimePicker_Date.Value.Day, 
                dateTimePicker_Time.Value.Hour, dateTimePicker_Time.Value.Minute, dateTimePicker_Time.Value.Second);
            
            if (interview.InterviewTime != dateTime && !CheckInterviewTime(dateTime))
            {
                return;
            }
            interview.InterviewTime = dateTime;
            interview.Note = textBox_Note.Text;
            if (jobID == 0)
            {
                employerDAO.UpdateInterviewByCV(interview);
            }
            else
            {
                employerDAO.UpdateInterview(interview);
                MessageBox.Show("ok");
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (interview.Id != 0)
            {
                if (jobID == 0)
                {

                }
                else
                {
                    employerDAO.DeleteInterview(interview);
                }
                this.Close();
            }
        }
    }
}
