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
        string jobid;
        public FCandidate_SavedJobs()
        {
            InitializeComponent();
        }
        private void LoadSavedJobs()
        {
            List<UC_JobsSaved> saveds = canDAO.GetSavedJobsFromDB();
            if (flpMain.Controls.Count > 0)
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
        private void savedJobsButtonApply_Click(object sender, EventArgs eventArgs)
        {

        }
        private void savedJobsButtonRusbish_Click(object sender, ButtonClickEventArgs e)
        {
            canDAO.RemoveSavedJobsFromDB(e.ID);
            LoadSavedJobs();
        }
    }
}
