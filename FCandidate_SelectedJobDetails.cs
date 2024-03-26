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
    public partial class FEmployer_SeeCVDetailOfCandidate : Form
    {
        private string jobid;
        CandidateDAO canDAO = new CandidateDAO();
        public FEmployer_SeeCVDetailOfCandidate()
        {
            InitializeComponent();
            GetDataFromDB();
        }
        public FEmployer_SeeCVDetailOfCandidate(string jobid)
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
                lblJobName_Address.Text = (string)item["JobName"] + $" [{(string)item["Address"]}]";
                lblSalary.Text = item["Salary"].ToString();
                lblAddress.Text = (string)item["Address"];
                lblExp.Text = (string)item["Experience"];
                lblComName.Text = (string)item["CompanyName"];
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
