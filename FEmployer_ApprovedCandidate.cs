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
using System.Security.Cryptography;

namespace Job_Application_Management
{
    public partial class FEmployer_ApprovedCandidate : KryptonForm
    {
        private int jobID;
        private EmployerDAO employerDAO;
        public FEmployer_ApprovedCandidate(int jobID)
        {
            employerDAO = new EmployerDAO();
            this.jobID = jobID;
            InitializeComponent();
        }

        private void FEmployer_ApprovedCandidate_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {
            string status = "Approved";
            List<UC_CandidateCV> resumeItems = employerDAO.GetCandidateResumeFromDB(jobID, status);
            foreach (var resume in resumeItems)
            {
                flowLayoutPanel1.Controls.Add(resume);
            }
        }
    }
}
