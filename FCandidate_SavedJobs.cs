using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;

namespace Job_Application_Management
{
    public partial class FCandidate_SavedJobs : KryptonForm
    {
        private string connStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Jobs_Management;Integrated Security=True";
        private string sqlQuery;
        public FCandidate_SavedJobs()
        {
            InitializeComponent();
        }

        private void FCandidate_SavedJobs_Load(object sender, EventArgs e)
        {
            PopulateItems();
        }
        public void PopulateItems()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                sqlQuery = "SELECT JobDecription, CompanyName, WorkAddress, Salary FROM Jobs";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UC_JobsSaved item = new UC_JobsSaved();
                        item.DescriptionJob = reader.GetString(0);
                        item.ComName = reader.GetString(1);
                        item.Address = reader.GetString(2);
                        item.Salary = reader.GetInt32(3);
                        if (flpMain.Controls.Count < 0)
                        {
                            flpMain.Controls.Clear();
                        }
                        else
                        {
                            flpMain.Controls.Add(item);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Has not rows");
                }
            }
        }
    }
}
