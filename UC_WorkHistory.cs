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
    public partial class UC_WorkHistory : UserControl
    {
        CandidateProfile candidateProfile;
        public void AddValueForControls()
        {
            txt_CddName.Text = candidateProfile.CddName;
            txt_CompanyName.Text = candidateProfile.CompanyName;
            dtp_Start.Value = candidateProfile.CompanyStartDate;
            dtp_End.Value = candidateProfile.CompanyEndDate;
        }
        public UC_WorkHistory()
        {
            InitializeComponent();
        }
        public UC_WorkHistory(CandidateProfile cp)
        {
            InitializeComponent();
            this.candidateProfile = cp;
            AddValueForControls();
        }
    }
}
