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

        private void button_Invite_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime(dateTimePicker_Date.Value.Year, dateTimePicker_Date.Value.Month, dateTimePicker_Date.Value.Day,
                dateTimePicker_Time.Value.Hour, dateTimePicker_Time.Value.Minute, dateTimePicker_Time.Value.Second);
            Interview interview = new Interview(empID, cddID, jobID, dateTime, textBox_Note.Text);

            if (employerDAO.CheckInterviewTimeExists(interview.InterviewTime, empID))
            {
                MessageBox.Show("Interview Time already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            employerDAO.AddInterview(interview);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FEmployer_Interview_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (interview.Id != 0)
            {
                dateTimePicker_Date.Value = interview.InterviewTime;
                dateTimePicker_Time.Value = interview.InterviewTime;
                textBox_Note.Text = interview.Note;
                button_Invite.Visible = false;
            }
            else
            {
                button_Update.Visible = false;
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime(dateTimePicker_Date.Value.Year, dateTimePicker_Date.Value.Month, dateTimePicker_Date.Value.Day, 
                dateTimePicker_Time.Value.Hour, dateTimePicker_Time.Value.Minute, dateTimePicker_Time.Value.Second);
            interview.InterviewTime = dateTime;
            interview.Note = textBox_Note.Text;
            employerDAO.UpdateInterview(interview);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (interview.Id != 0)
            {
                employerDAO.DeleteInterview(interview);
                this.Close();
            }
        }
    }
}
