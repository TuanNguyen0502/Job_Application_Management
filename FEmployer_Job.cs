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
    public partial class FEmployer_Job : KryptonForm
    {
        private Form currentFormChild;
        private string connStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Jobs_Management;Integrated Security=True";
        private string sqlQuery;
        private UC_EmployerJob[] uC_EmployerJobs;

        public FEmployer_Job()
        {
            InitializeComponent();
            uC_EmployerJobs = new UC_EmployerJob[] { };
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Size = new Size(1300, 600);
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_Post_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_JobDetail(null));
        }

        private void button_Change_Click(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            
        }

        private void FEmployer_Job_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
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
                        //lstItems[i].Icon = 
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
            }
        }
    }
}
