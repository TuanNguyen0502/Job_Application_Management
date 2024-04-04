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

        private void FCandidate_AppliedJobs_Load(object sender, EventArgs e)
        {

            List<UC_JobsSaved> saveds = canDAO.GetAppliedJobsFromDB();
            foreach (var saved in saveds)
            {
                saved.BtnAdd.Visible = false;
                flpMain.Controls.Add(saved);
            }
        }
    }
}
