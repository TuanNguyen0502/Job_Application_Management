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
    public partial class FCandidate_SelectedJobDetails : Form
    {
        private string jobid;
        CandidateDAO canDAO = new CandidateDAO();
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
            List<Dictionary<string, object>> keyValueJobDetails = canDAO.GetSelectedJobDetails(jobid);
            foreach (var item in keyValueJobDetails)
            {
                lblJobName_Address.Text = (string)item["JobName"] + $" [{(string)item["WorkAddress"]}]";
                lblSalary.Text = item["Salary"].ToString();
                lblAddress.Text = (string)item["WorkAddress"];
                lblExp.Text = (string)item["Experience"];
                lblComName.Text = (string)item["CompanyName"];
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
