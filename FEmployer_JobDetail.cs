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
        private string connStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Jobs_Management;Integrated Security=True";
        private string sqlQuery;
        private int jobID;
        private string empID;
        private EmployerDAO employerDAO;

        public int JobID { get => jobID; set => jobID = value; }

        public FEmployer_JobDetail(int ID, string empID)
        {
            this.JobID = ID;
            this.empID = empID;
            employerDAO = new EmployerDAO();
            InitializeComponent();
        }

        private void button_SeeCandidate_Click(object sender, EventArgs e)
        {
            FEmployer_SeeCandidate fEmployer_SeeCandidate = new FEmployer_SeeCandidate(JobID);
            fEmployer_SeeCandidate.ShowDialog();
        }

        private void button_ApprovedCandidate_Click(object sender, EventArgs e)
        {
            FEmployer_ApprovedCandidate fEmployer_ApprovedCandidate = new FEmployer_ApprovedCandidate(JobID);
            fEmployer_ApprovedCandidate.ShowDialog();
        }

        private void FEmployer_JobDetail_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {
            if (JobID != 0)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    sqlQuery = $"SELECT ID, Name, Salary, JobDecription, Workduration, Experience, ExpirationDate, Benefit, RequestCdd, " +
                        $"PostTime FROM Jobs WHERE ID = '{JobID}'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            textBox_JobName.Text = reader.GetString(1);
                            textBox_Salary.Text = reader.GetInt32(2).ToString();
                            richTextBox_JobDescripton.Text = reader.GetString(3);
                            textBox_WorkingTime.Text = reader.GetInt32(4).ToString();
                            textBox_Experience.Text = reader.GetString(5);
                            dateTimePicker_Deadline.Value = reader.GetDateTime(6);
                            richTextBox_JobBenefit.Text = reader.GetString(7);
                            richTextBox_Requirement.Text = reader.GetString(8);
                        }
                    }
                    else
                        MessageBox.Show("No rows found");
                }
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
