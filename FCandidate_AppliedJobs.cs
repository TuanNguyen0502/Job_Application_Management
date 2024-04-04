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

namespace Job_Application_Management
{
    public partial class FCandidate_AppliedJobs : KryptonForm
    {
        CandidateDAO canDAO = new CandidateDAO();

        public FCandidate_AppliedJobs()
        {
            InitializeComponent();
        }
        private void LoadAppliedJobs()
        {
            List<UC_AppliedJobs> applieds = canDAO.GetAppliedJobsFromDB();
            if (flpMain.Controls.Count > 0)
            {
                flpStoreUC.Controls.Clear();
            }
            foreach (var applied in applieds)
            {
                flpStoreUC.Controls.Add(applied);
                applied.ButtonRusbishClick += appliedJobsButtonRusbish_Click;
            }
        }
        private void FCandidate_AppliedJobs_Load(object sender, EventArgs e)
        {
            LoadAppliedJobs();
        }
        private void appliedJobsButtonRusbish_Click(object sender, ButtonClickEventArgs e)
        {
            canDAO.RemoveAppliedJobsFromDB(e.ID);
            LoadAppliedJobs();
        }
    }
}
