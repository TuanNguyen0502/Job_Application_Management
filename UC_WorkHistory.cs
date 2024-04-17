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
        public event EventHandler AddHistory;
        private void ptb_AddHistory_Click(object sender, EventArgs e)
        {
            
            AddHistory?.Invoke(this, new EventArgs());
        }
        public event EventHandler<ClickAddHistory> DoneAddHistory;
        private void ptb_Done_Click(object sender, EventArgs e)
        {
            DoneAddHistory?.Invoke(this, new ClickAddHistory(txt_CddName.Text, txt_CompanyName.Text, dtp_Start.Value, dtp_End.Value));
        }
        public event EventHandler<ClickAddHistory> RemoveHistory;
        private void ptb_Cancel_Click(object sender, EventArgs e)
        {
            RemoveHistory?.Invoke(this, new ClickAddHistory(txt_CddName.Text, txt_CompanyName.Text, dtp_Start.Value, dtp_End.Value));
        }
    }
}
