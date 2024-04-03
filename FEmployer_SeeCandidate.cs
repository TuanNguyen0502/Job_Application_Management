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
        private EmployerDAO employerDAO;

        public FEmployer_SeeCandidate(string jobID)
        {
            this.jobID = jobID;
            employerDAO = new EmployerDAO();    
            InitializeComponent();
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
            string status = "Đang ứng tuyển";
            List<UC_CandidateCV> resumeItems = employerDAO.GetCandidateResumeFromDB(jobID, status);
            foreach (var resume in resumeItems)
            {
                flowLayoutPanel1.Controls.Add(resume);
            }
        }
    }
}
