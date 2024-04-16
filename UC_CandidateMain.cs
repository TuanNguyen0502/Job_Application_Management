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
        private Candidate candidate1;
        private Job job;
        private Company company;
        public Candidate _Candidate { get { return candidate1; } set { candidate1 = value; } }
        public Job _Job { get { return job; } set { job = value; } }
        public Company _Company { get { return company; } set { company = value; } }
        public Button BtnApply { get { return btnApply; } }
        public UC_CandidateMain(Candidate candidate, Job job, Company company)
        {
            InitializeComponent();
            this.candidate1 = candidate;
            this.job = job;
            this.company = company;
        }
        private void UC_CandidateMain_Load(object sender, EventArgs e)
        {
            lblJobName.Text = job.Name;
            lblCompanyName.Text = company.Name;
            lblSalary.Text = job.Salary.ToString();
            lblAdress.Text = company.Address;

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
            canDAO.AddSavedJob(job.Id);
        }
        private void gunaLinePanel1_Click(object sender, EventArgs e)
        {
            ClickToJob?.Invoke(this, new ButtonClickEventArgs(candidate1.Id, job.Id));
        }
        public event EventHandler<ButtonClickEventArgs> Lbl_Salary;
        private void lblSalary_Click(object sender, EventArgs e)
        {
            Lbl_Salary?.Invoke(this, new ButtonClickEventArgs(candidate1.Id, job.Id));
        }
        public event EventHandler<ButtonClickEventArgs> Lbl_Address;
        private void lblAdress_Click(object sender, EventArgs e)
        {
            Lbl_Address?.Invoke(this, new ButtonClickEventArgs(candidate1.Id, job.Id));
        }
        public event EventHandler<ButtonClickEventArgs> Lbl_CompanyName;
        private void lblCompanyName_Click(object sender, EventArgs e)
        {
            Lbl_CompanyName?.Invoke(this, new ButtonClickEventArgs(candidate1.Id, job.Id));
        }
        public event EventHandler<ButtonClickEventArgs> Lbl_JobName;
        private void lblJobName_Click(object sender, EventArgs e)
        {
            Lbl_JobName?.Invoke(this, new ButtonClickEventArgs(candidate1.Id, job.Id));
        }
        public event EventHandler<ButtonClickEventArgs> Cptb_Company;
        private void cptb_company_Click(object sender, EventArgs e)
        {
            Cptb_Company?.Invoke(this, new ButtonClickEventArgs(candidate1.Id, job.Id));
        }
    }
}
