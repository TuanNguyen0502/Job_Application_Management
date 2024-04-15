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

        private void rdb_Nearly_CheckedChanged(object sender, EventArgs e)
        {
            List<UC_JobsSaved> uC_JobsSaveds = canDAO.GetSavedJobsFromDB();
            uC_JobsSaveds.Sort((uc1,uc2)=> uc2.TimeSaved.CompareTo(uc1.TimeSaved));
            if (flpStoreUC.Controls.Count > 0)
            {
                flpStoreUC.Controls.Clear();
            }
            foreach (var saved in uC_JobsSaveds)
            {
                flpStoreUC.Controls.Add(saved);
                saved.ButtonAddClick += savedJobsButtonApply_Click;
                saved.ButtonRusbishClick += savedJobsButtonRusbish_Click;
            }
        }

        private void rdb_Lately_CheckedChanged(object sender, EventArgs e)
        {
            List<UC_JobsSaved> uC_JobsSaveds = canDAO.GetSavedJobsFromDB();
            uC_JobsSaveds.Sort((uc1, uc2) => uc1.TimePost.CompareTo(uc2.TimePost));
            if (flpStoreUC.Controls.Count > 0)
            {
                flpStoreUC.Controls.Clear();
            }
            foreach (var saved in uC_JobsSaveds)
            {
                flpStoreUC.Controls.Add(saved);
                saved.ButtonAddClick += savedJobsButtonApply_Click;
                saved.ButtonRusbishClick += savedJobsButtonRusbish_Click;
            }
        }

        private void rdb_Tallest_CheckedChanged(object sender, EventArgs e)
        {
            List<UC_JobsSaved> uC_JobsSaveds = canDAO.GetSavedJobsFromDB();
            uC_JobsSaveds.Sort((uc1, uc2) => uc2.Salary.CompareTo(uc1.Salary));
            if (flpStoreUC.Controls.Count > 0)
            {
                flpStoreUC.Controls.Clear();
            }
            foreach (var saved in uC_JobsSaveds)
            {
                flpStoreUC.Controls.Add(saved);
                saved.ButtonAddClick += savedJobsButtonApply_Click;
                saved.ButtonRusbishClick += savedJobsButtonRusbish_Click;
            }
        }
    }
}
