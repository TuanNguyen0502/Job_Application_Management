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
        private string companyName;
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
                lblJobId.Text = jobid;
                lblJobName_Address.Text = (string)item["JobName"] + $" [{(string)item["Address"]}]";
                lblSalary.Text = item["Salary"].ToString();
                lblAddress.Text = (string)item["Address"];
                lblAdress2.Text = (string)item["Address"];
                lblExp.Text = (string)item["Experience"];
                lblExp2.Text = (string)item["Experience"];
                lblComName.Text = (string)item["CompanyName"];
                DateTime postTime = (DateTime)item["PostTime"];
                TimeSpan diff = postTime.Subtract(DateTime.Now);
                if (diff.TotalDays > 15)
                {
                    lblStatus.Text = "Đã hết hạn. Ứng tuyển lại?";
                }
                else lblStatus.Text = "Đang ứng tuyển";

                companyName = (string)item["CompanyName"];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FCandidate_CompanyDetails com = new FCandidate_CompanyDetails(companyName);
            com.ShowDialog();
        }
        private void FEmployer_SeeCVDetailOfCandidate_Load(object sender, EventArgs e)
        {
            //flpnRecruitment.Controls.Add()
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            canDAO.SaveAppliedJob(jobid);
        }
    }
}
