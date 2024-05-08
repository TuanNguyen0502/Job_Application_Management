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

namespace Job_Application_Management
{
    public partial class FEmployer_SeeCandidate : Form
    {
        private string empID;
        private int jobID;
        private EmployerDAO employerDAO = new EmployerDAO();

        public FEmployer_SeeCandidate(string empID, int jobID)
        {
            InitializeComponent();
            this.empID = empID;
            this.jobID = jobID;
        }

        private void FEmployer_SeeCandidate_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {
            string status = "Applying";
            List<UC_Employer_CandidateResume> resumeItems = employerDAO.GetCandidateResumeFromDB(empID, jobID, status);
            foreach (var resume in resumeItems)
            {
                flowLayoutPanel1.Controls.Add(resume);
            }
        }
    }
}
