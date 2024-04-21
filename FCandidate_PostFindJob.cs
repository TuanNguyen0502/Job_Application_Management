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
    public partial class FCandidate_PostFindJob : Form
    {
        private string cddId;
        CandidateDAO canDAO = new CandidateDAO();
        public FCandidate_PostFindJob(string cddId)
        {
            InitializeComponent();
            this.cddId = cddId;
        }
        public FCandidate_PostFindJob()
        {
            InitializeComponent();
            flp_ContainsHistory.Controls.Clear();
            
        }
        public void btnAddHistory_Click(object sender, EventArgs e)
        {
            UC_WorkHistory history = new UC_WorkHistory();
            history.AddHistory += btnAddHistory_Click;
            history.DoneAddHistory += btnDoneAddHistory_Click;
            history.RemoveHistory += btnRemoveHistory_Click;
            flp_ContainsHistory.Controls.Add(history);
            
        }
        public void btnDoneAddHistory_Click(object sender, ClickAddHistory e)
        {
            canDAO.AddWorkHistory(cddId, e.CompanyName, e.StartDate, e.EndDate);
            flp_ContainsHistory.Controls.Clear();
            LoadHistory();
        }
        public void btnRemoveHistory_Click(object sender, ClickAddHistory e)
        {
            canDAO.RemoveWorkHistory(cddId, e.CompanyName);
            flp_ContainsHistory.Controls.Clear();
            LoadHistory();
        }
        public void LoadHistory()
        {
            List<UC_WorkHistory> historys = canDAO.GetWorkHistory();
            foreach (var history in historys)
            {
                history.AddHistory += btnAddHistory_Click;
                history.DoneAddHistory += btnDoneAddHistory_Click;
                history.RemoveHistory += btnRemoveHistory_Click;
                flp_ContainsHistory.Controls.Add(history);
            }
        }
        private void FCandidate_PostFindJob_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }
        public CandidateProfile GetCandidateProfileToCoverLetter()
        {
            CandidateProfile canProfile = new CandidateProfile();
            canProfile.Objective = txt_CarrerGoal.Text;
            canProfile.UniversityName = txt_School.Text;
            canProfile.Major = txt_Major.Text;
            canProfile.Gpa = txt_Gpa.Text;
            canProfile.CompanyName = txt_Company.Text;
            canProfile.WorkPlace = txt_Nominee.Text;
            canProfile.Certification = txt_Certificates.Text;
            return canProfile;
        }

        private void btn_Post_Click_1(object sender, EventArgs e)
        {
            CandidateProfile canProfile = GetCandidateProfileToCoverLetter();
            canDAO.AddJobPosting(canProfile, cddId);
        }

        private void btn_Edit_Click_1(object sender, EventArgs e)
        {
            CandidateProfile canProfile = GetCandidateProfileToCoverLetter();
            canDAO.EditJobPosting(canProfile, cddId);
        }

        private void btn_Remove_Click_1(object sender, EventArgs e)
        {
            CandidateProfile canProfile = GetCandidateProfileToCoverLetter();
            canDAO.RemoveJobPosting(canProfile.WorkPlace, cddId);
        }
    }
}
