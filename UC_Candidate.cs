using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public partial class UC_Candidate : UserControl
    {
        public UC_Candidate()
        {
            InitializeComponent();
        }

        private void uc_JobDetail(object sender, EventArgs e)
        {
            FCandidate_SelectedJobDetail detail = new FCandidate_SelectedJobDetail();
            detail.ShowDialog();
        }
    }
}
