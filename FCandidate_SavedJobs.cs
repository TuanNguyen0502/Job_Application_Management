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
using System.Data.SqlClient;

namespace Job_Application_Management
{
    public partial class FCandidate_SavedJobs : KryptonForm
    {
        CandidateDAO canDAO = new CandidateDAO();
        private string cddID;
        public FCandidate_SavedJobs(string cddID)
        {
            InitializeComponent();
            this.cddID=cddID;
        }
        public FCandidate_SavedJobs()
        {
            InitializeComponent();
        }
        public void LoadSavedJobs()
        {
            List<UC_JobsSaved> saveds = canDAO.GetSavedJobsFromDB();
            if (flpStoreUC.Controls.Count > 0)
            {
                flpStoreUC.Controls.Clear();
            }
            foreach (var saved in saveds)
            {
                flpStoreUC.Controls.Add(saved);
                saved.ButtonAddClick += savedJobsButtonApply_Click;
                saved.ButtonRusbishClick += savedJobsButtonRusbish_Click;
            }
        }
        private void FCandidate_SavedJobs_Load(object sender, EventArgs e)
        {
            LoadSavedJobs();
        }
        private void savedJobsButtonApply_Click(object sender, ButtonClickEventArgs e)
        {
            
        }
        private void savedJobsButtonRusbish_Click(object sender, ButtonClickEventArgs e)
        {
            canDAO.RemoveSavedJobsFromDB(e.ID);
            List<UC_CandidateMain> jobItems = canDAO.GetJobsFromDB(cddID);
            foreach (var jobItem in jobItems)
            {
                    List<UC_JobsSaved> jobSaveds = canDAO.GetSavedJobsFromDB();
                    foreach (var jobSaved in jobSaveds)
                    {
                        if (jobItem.JobID != jobSaved.JobID)
                            continue;
                    }
                jobItem.Enabled = true;
            }
            LoadSavedJobs();
        }

    }
}
