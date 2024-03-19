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
    public partial class UC_CandidateMain : UserControl
    {
        #region Properties
        private string jobName;
        private string companyName;
        private double salary;
        private string address;
        private Image icon;
        private string jobid;
        [Category("Custom Props")]
        public string JobName
        {
            get { return jobName; }
            set { jobName = value; lblJobName.Text = value; }
        }
        [Category("Custom Props")]
        public string CompanyName1
        {
            get { return companyName; }
            set { companyName = value; lblCompanyName.Text = value; }
        }
        [Category("Custom Props")]
        public double Salary
        {
            get { return salary; }
            set {salary = value; lblSalary.Text = value.ToString()+"VNĐ"; }
        }
        [Category("Custom Props")]
        public string Address
        {
            get { return address; }
            set { address = value; lblAdress.Text = value; }
        }
        [Category("Custom Props")]
        public Image Icon
        {
            get { return icon; }
            set { icon = value; ptbMain.Image = value; }
        }
        [Category("Custom Props")]
        public string JobID
        {
            get { return jobid; }
            set { jobid = value; }
        }
        #endregion
        public UC_CandidateMain()
        {
            InitializeComponent();
        }

        private void UC_CandidateMain_Load(object sender, EventArgs e)
        {
            
        }

        private void UC_CandidateMain_Click(object sender, EventArgs e)
        {
            FCandidate_SelectedJobDetails selected = new FCandidate_SelectedJobDetails(JobID);
            selected.ShowDialog();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }
    }
}
