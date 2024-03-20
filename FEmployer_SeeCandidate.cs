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
    public partial class FEmployer_SeeCandidate : KryptonForm
    {
        private Form currentFormChild;
        private string jobID;
        private string connStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Jobs_Management;Integrated Security=True";
        private UC_EmployerJob[] uC_EmployerJobs;

        public FEmployer_SeeCandidate(string jobID)
        {
            InitializeComponent();
            this.jobID = jobID;
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.FormBorderStyle = FormBorderStyle.Sizable;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FEmployer_SeeCandidate_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                /*
                conn.Open();
                sqlQuery = "SELECT JobID, JobName FROM Jobs";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {   
                    while (reader.Read())
                    {
                        UC_EmployerJob item = new UC_EmployerJob();
                        uC_EmployerJobs.Append(item);
                        item.JobID = reader.GetString(0);
                        item.Label_JobName.Text = reader.GetString(1);
                        if (flowLayoutPanel_Jobs.Controls.Count < 0)
                        {
                            flowLayoutPanel_Jobs.Controls.Clear();
                        }
                        else
                            flowLayoutPanel_Jobs.Controls.Add(item);
                    }
                }
                else
                    MessageBox.Show("No rows found");
                */
            }
        }
    }
}
