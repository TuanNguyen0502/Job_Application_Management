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
        public FCandidate_SavedJobs()
        {
            InitializeComponent();
        }
        private void FCandidate_SavedJobs_Load(object sender, EventArgs e)
        {
            canDAO.GetSavedJobsFromDB(this);
        }
    }
}
