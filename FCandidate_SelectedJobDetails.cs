using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Job_Application_Management
{
    public partial class FCandidate_SelectedJobDetails : Form
    {
        private string connStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Jobs_Management;Integrated Security=True";
        private string sqlQuery;
        private string jobid;
        public FCandidate_SelectedJobDetails()
        {
            InitializeComponent();
            GetDataFromDB();
        }
        public FCandidate_SelectedJobDetails(string jobid)
        {
            this.jobid = jobid;
            InitializeComponent();
            GetDataFromDB();
        }
        public void GetDataFromDB()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                sqlQuery = "SELECT JobName, WorkAddress, Salary, Experience, CompanyName FROM Jobs WHERE JobID = @jobId";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@jobId", jobid);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblJobName_Address.Text = reader.GetString(0) + $" [{reader.GetString(1)}]";
                        lblSalary.Text = reader.GetInt32(2).ToString();
                        lblAddress.Text = reader.GetString(1);
                        lblExp.Text = reader.GetString(3);
                        lblComName.Text = reader.GetString(4);
                    }
                }
                else
                {
                    MessageBox.Show("Has not rows");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
