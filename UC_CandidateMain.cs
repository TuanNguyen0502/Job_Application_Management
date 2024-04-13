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
using Guna.UI2.Designer;

namespace Job_Application_Management
{
    public partial class UC_CandidateMain : UserControl
    {
        CandidateDAO canDAO = new CandidateDAO();
        #region Properties
        private string jobName;
        private string companyName;
        private double salary;
        private string address;
        private Image icon;
        private int jobid;
        private string cddid;
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
            set { icon = value; cptb_company.Image = value; }
        }
        [Category("Custom Props")]
        public int JobID
        {
            get { return jobid; }
            set { jobid = value; }
        }
        public string CddID
        {
            get { return cddid; }
            set { cddid = value; }
        }
        #endregion
        public Button BtnApply { get { return btnApply; } }
       
        public UC_CandidateMain()
        {
            InitializeComponent();
        }
        public event EventHandler<ButtonClickEventArgs> ClickToJob;
        private void UC_CandidateMain_Click(object sender, EventArgs e)
        {
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Enabled = false;
            b.BackColor = Color.LightGreen;
            canDAO.AddSavedJob(jobid);
        }
        private void gunaLinePanel1_Click(object sender, EventArgs e)
        {
            ClickToJob?.Invoke(this, new ButtonClickEventArgs(CddID, JobID));
        }
    }
}
