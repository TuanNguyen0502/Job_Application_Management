using Guna.UI2.WinForms;
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
    public partial class FCandidateMain : Form
    {
        CandidateDAO canDAO = new CandidateDAO();
        Form currentFormChild;
        public FCandidateMain()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            pnl_ContainDetailsJob.BackgroundImage = null;
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_ContainDetailsJob.Controls.Add(childForm);
            pnl_ContainDetailsJob.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 145, b.Location.Y - 44);
            imgSlide.SendToBack();
        }

        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FCandidateMain_Load(object sender, EventArgs e)
        {
            ListJobs();
        }
        private void CheckJobsSavedAndPushIntoFLP(UC_CandidateMain candidateMain)
        {
            List<UC_JobsSaved> jobSaveds = canDAO.GetSavedJobsFromDB();
            foreach (var jobSaved in jobSaveds)
            {
                if (candidateMain.JobID == jobSaved.SavedJob.Id)
                {
                    candidateMain.BtnApply.Enabled = false;
                    candidateMain.BtnApply.BackColor = Color.LightGreen;
                    break;
                }
            }
            flp_ContainsJobs.Controls.Add(candidateMain);
            candidateMain.ClickToJob += clickToShowJobDetails_Click;
            candidateMain.Lbl_Salary += clickToShowJobDetails_Click;
            candidateMain.Lbl_Address += clickToShowJobDetails_Click;
            candidateMain.Lbl_JobName += clickToShowJobDetails_Click;
            candidateMain.Lbl_CompanyName += clickToShowJobDetails_Click;
            candidateMain.Cptb_Company += clickToShowJobDetails_Click;
        }
        public void ListJobs()
        {
            List<UC_CandidateMain> jobItems = canDAO.GetJobsFromDB(lblCddID.Text);
            foreach (var jobItem in jobItems)
            {
                CheckJobsSavedAndPushIntoFLP(jobItem);
            }
        }
        private void clickToShowJobDetails_Click(object sender, ButtonClickEventArgs e)
        {
            
            FCandidate_SelectedJobDetails selected = new FCandidate_SelectedJobDetails(e.JobID, e.ID);
            OpenChildForm(selected);
            
        }

        private void btnSearchFor_Click(object sender, EventArgs e)
        {
            if (flp_ContainsJobs.Controls.Count >= 0)
            {
                flp_ContainsJobs.Controls.Clear();
                List<UC_CandidateMain> jobItems = canDAO.GetJobsByKeywords(txt_SearchFor.Text);
                foreach (var jobItem in jobItems)
                {
                    CheckJobsSavedAndPushIntoFLP(jobItem);
                }
            }
        }

        private void cbb_Address_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Address.SelectedItem.ToString() != "Tất cả tỉnh/TP")
            {
                if (flp_ContainsJobs.Controls.Count > 0)
                {
                    flp_ContainsJobs.Controls.Clear();
                }
                List<UC_CandidateMain> jobItems = canDAO.GetJobsByAddress(cbb_Address.SelectedItem.ToString());
                foreach (var jobItem in jobItems)
                {
                    CheckJobsSavedAndPushIntoFLP(jobItem);
                }
            }
            else
            {
                if (flp_ContainsJobs.Controls.Count >= 0)
                {
                    flp_ContainsJobs.Controls.Clear();
                }
                ListJobs();
            }
        }
        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            flp_ContainsJobs.Controls.Clear();
            pnl_ContainDetailsJob.Controls.Clear();
            ListJobs();
        }
        private void btn_ResponeFindJobs_Click(object sender, EventArgs e)
        {
            flp_ContainsJobs.Controls.Clear();
            pnl_ContainDetailsJob.Controls.Clear();
            ListJobs();
        }
        private void btn_JobsSaved_Click(object sender, EventArgs e)
        {
            flp_ContainsJobs.Controls.Clear();
            UC_Introduction introduction = new UC_Introduction();
            introduction.Btn_ResponeFindJobs += btn_ResponeFindJobs_Click;
            flp_ContainsJobs.Controls.Add(introduction);
            OpenChildForm(new FCandidate_SavedJobs(lblCddID.Text));
        }

        private void btn_JobsApplied_Click(object sender, EventArgs e)
        {
            flp_ContainsJobs.Controls.Clear();
            UC_Introduction introduction = new UC_Introduction();
            introduction.Btn_ResponeFindJobs += btn_ResponeFindJobs_Click;
            flp_ContainsJobs.Controls.Add(introduction);
            OpenChildForm(new FCandidate_AppliedJobs());
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            FCandidate_CreateCV createCV = new FCandidate_CreateCV();
            createCV.ShowDialog();
        }

        private void btn_Posting_Click(object sender, EventArgs e)
        {
            flp_ContainsJobs.Controls.Clear();
            UC_Introduction introduction = new UC_Introduction();
            introduction.Btn_ResponeFindJobs += btn_ResponeFindJobs_Click;
            flp_ContainsJobs.Controls.Add(introduction);
            OpenChildForm(new FCandidate_PostFindJob());
        }

        private void btn_LogOut_Click_1(object sender, EventArgs e)
        {
            Program.MainFormManager.CurrentForm = new FLogin();

        }
    }
}
