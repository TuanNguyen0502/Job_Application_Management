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
        public FCandidate_AppliedJobs()
        {
            InitializeComponent();
        }

        private void FCandidate_AppliedJobs_Load(object sender, EventArgs e)
        {

        }

        private void btn_FindJob_Click(object sender, EventArgs e)
        {
            FCandidate fCandidate = new FCandidate();
            fCandidate.ShowDialog();
        }
    }
}
