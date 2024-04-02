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
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Job_Application_Management
{
    public partial class FCandidate : KryptonForm
    {
        CandidateDAO canDAO = new CandidateDAO();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public FCandidate()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        public void frmCandidateMain_Load(object sender, EventArgs e)
        {
            cbbAddress.Text = "";
            ListJobs();
        }
        public void ListJobs()
        {
            List<UC_CandidateMain> jobItems = canDAO.GetJobsFromDB();
            foreach (var jobItem in jobItems)
            {
                if (flpScrollPane.Controls.Count < 0)
                {
                    flpScrollPane.Controls.Clear();
                }
                else
                    flpScrollPane.Controls.Add(jobItem);
            }
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btnJobApp_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnJobApp.Height;
            pnlNav.Top = btnJobApp.Top;
            btnJobApp.BackColor = Color.FromArgb(224, 224, 224);
            FCandidate_SavedJobs saved = new FCandidate_SavedJobs();
            saved.ShowDialog();
        }

        private void btnCompanies_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCompanies.Height;
            pnlNav.Top = btnCompanies.Top;
            btnCompanies.BackColor = Color.FromArgb(224, 224, 224);
            FCandidate_AppliedJobs applied = new FCandidate_AppliedJobs();
            applied.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLogout.Height;
            pnlNav.Top = btnLogout.Top;
            btnLogout.BackColor = Color.FromArgb(224, 224, 224);
            
            Program.MainFormManager.CurrentForm = new FLogin();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSetting.Height;
            pnlNav.Top = btnSetting.Top;
            btnSetting.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(227, 229, 234);
        }

        private void btnJobApp_Leave(object sender, EventArgs e)
        {
            btnJobApp.BackColor = Color.FromArgb(227, 229, 234);
        }

        private void btnCompanies_Leave(object sender, EventArgs e)
        {
            btnCompanies.BackColor = Color.FromArgb(227, 229, 234);
        }

        private void btnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(227, 229, 234);
        }

        private void btnSetting_Leave(object sender, EventArgs e)
        {
            btnSetting.BackColor = Color.FromArgb(227, 229, 234);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchJob_Click(object sender, EventArgs e)
        {
            if (flpScrollPane.Controls.Count >= 0)
            {
                flpScrollPane.Controls.Clear();
                List<UC_CandidateMain> jobItems = canDAO.GetJobsByKeywords(txtSearchFor.Text);
                foreach (var jobItem in jobItems)
                {
                    flpScrollPane.Controls.Add(jobItem);
                }
            }
        }
        private void cbbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbAddress.SelectedItem.ToString() != "Tất cả tỉnh/TP")
            {
                if (flpScrollPane.Controls.Count > 0)
                {
                    flpScrollPane.Controls.Clear();
                }
                List<UC_CandidateMain> jobItems = canDAO.GetJobsByAddress(cbbAddress.SelectedItem.ToString());
                foreach (var jobItem in jobItems)
                {
                    flpScrollPane.Controls.Add(jobItem);
                }
            }
            else
            {
                if (flpScrollPane.Controls.Count >= 0)
                {
                    flpScrollPane.Controls.Clear();
                }
                ListJobs();
            }
        }

        private void btnRegisterCV_Click(object sender, EventArgs e)
        {
            FCandidate_CreateCV createCV = new FCandidate_CreateCV(lblCddID.Text);
            createCV.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FResume resume = new FResume();
            resume.ShowDialog(); 

        }
    }
}
