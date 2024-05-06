using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Job_Application_Management
{
    public partial class FEmployer_ApprovedCandidate : Form
    {
        private string empID;
        private int jobID;
        private EmployerDAO employerDAO = new EmployerDAO();
        public FEmployer_ApprovedCandidate(string empID, int jobID)
        {
            InitializeComponent();
            this.empID = empID;
            this.jobID = jobID;
        }

        private void FEmployer_ApprovedCandidate_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {
            string status = "Approved";
            List<UC_Employer_CandidateCV> resumeItems = employerDAO.GetCandidateResumeFromDB(empID, jobID, status);
            foreach (var resume in resumeItems)
            {
                flowLayoutPanel1.Controls.Add(resume);
            }
        }
    }
}
