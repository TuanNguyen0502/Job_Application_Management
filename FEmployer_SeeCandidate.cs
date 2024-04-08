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
        private int jobID;
        private string connStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Jobs_Management;Integrated Security=True";
        private EmployerDAO employerDAO;

        public FEmployer_SeeCandidate(int jobID)
        {
            this.jobID = jobID;
            employerDAO = new EmployerDAO();    
            InitializeComponent();
        }

        private void FEmployer_SeeCandidate_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {
            string status = "Applying";
            List<UC_CandidateCV> resumeItems = employerDAO.GetCandidateResumeFromDB(jobID, status);
            foreach (var resume in resumeItems)
            {
                flowLayoutPanel1.Controls.Add(resume);
            }
        }
    }
}
