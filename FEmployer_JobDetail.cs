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
using ComponentFactory.Krypton.Toolkit;

namespace Job_Application_Management
{
    public partial class FEmployer_JobDetail : KryptonForm
    {
        private Form currentFormChild;
        private string connStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Jobs_Management;Integrated Security=True";
        private string sqlQuery;
        private string jobID;
        private EmployerDAO employerDAO;

        public string JobID { get => jobID; set => jobID = value; }

        public FEmployer_JobDetail(string ID)
        {
            this.JobID = ID;
            employerDAO = new EmployerDAO();
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_SeeCandidate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_SeeCandidate(JobID));
        }

        private void button_ApprovedCandidate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_ApprovedCandidate());
        }

        private void FEmployer_JobDetail_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {
            if (JobID != null)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    sqlQuery = $"SELECT JobID, JobName, Salary, JobDecription, Workduration, Experience, ExpirationDate, Benefit, RequestCdd " +
                        $"FROM Jobs WHERE JobID = '{JobID}'";
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
            if (JobID == null)
            {
                employerDAO.AddJob(CreateJob());
                this.Close();
            }
            else
            {
                employerDAO.UpdateJob(GetCurrentJob());
                this.Close();
            }
        }

        private Job GetCurrentJob()
        {
            Job job = new Job(JobID, textBox_JobName.Text, Int32.Parse(textBox_Salary.Text), "null", "null", richTextBox_JobDescripton.Text,
                    Int32.Parse(textBox_WorkingTime.Text), textBox_Experience.Text, dateTimePicker_Deadline.Value, richTextBox_JobBenefit.Text,
                    richTextBox_Requirement.Text, "Emp001");
            return job;
        }

        private Job CreateJob()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                // get job number
                int number = 0;
                string query = "SELECT * FROM Jobs";
                SqlCommand com = new SqlCommand(query, conn);
                SqlDataReader r = com.ExecuteReader();
                if (r.HasRows)
                {
                    while (r.Read())
                        number++;
                }
                else
                    MessageBox.Show("No rows found");
                r.Close();
                number++;
                //
                Job job = new Job("JOB" + number, textBox_JobName.Text, Int32.Parse(textBox_Salary.Text), "null", "null", richTextBox_JobDescripton.Text,
                    Int32.Parse(textBox_WorkingTime.Text), textBox_Experience.Text, dateTimePicker_Deadline.Value, richTextBox_JobBenefit.Text,
                    richTextBox_Requirement.Text, "Emp001");
                return job;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (JobID != null)
            {
                employerDAO.DeleteJob(GetCurrentJob());
                this.Close();
            }
        }
    }
}
