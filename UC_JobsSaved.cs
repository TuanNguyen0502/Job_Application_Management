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
    public partial class UC_JobsSaved : UserControl
    {
        public UC_JobsSaved()
        {
            InitializeComponent();
            InitializeToolTip();
        }

        private void uc_JobDetail(object sender, EventArgs e)
        {
            FCandidate_SelectedJobDetail detail = new FCandidate_SelectedJobDetail();
            detail.ShowDialog();
        }

        private void UC_Candidate_Load(object sender, EventArgs e)
        {

        }

        private void InitializeToolTip()
        {
            ToolTip toolTipMain = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTipMain.AutoPopDelay = 5000;
            toolTipMain.InitialDelay = 1000;
            toolTipMain.ReshowDelay = 500;

            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTipMain.ShowAlways = true;

            // Set up the ToolTip text for the Button and TextBox.
            toolTipMain.SetToolTip(this.btnRusbish, "Bỏ qua");
            toolTipMain.SetToolTip(this.btnAdd, "Lưu");
        }
    }
}
