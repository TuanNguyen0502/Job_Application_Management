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
            List<UC_WorkHistory> historys = canDAO.GetWorkHistory();
            foreach (var history in historys)
            {
                flp_ContainsHistory.Controls.Add(history);
            }
        }
        public CandidateProfile GetCandidateProfileToCoverLetter()
        {
            CandidateProfile canProfile = new CandidateProfile();
            canProfile.Objective = ktxt_CarrerGoal.Text;
            canProfile.UniversityName = ktxt_UName.Text;
            canProfile.Major = ktxt_Major.Text;
            canProfile.Gpa = ktxt_Gpa.Text;
            canProfile.CompanyName = ktxt_ComName.Text;
            canProfile.WorkPlace = ktxt_Nominee.Text;
            canProfile.Certification = ktxt_Certification.Text;
            return canProfile;
        }

        private void btn_Post_Click(object sender, EventArgs e)
        {
            CandidateProfile canProfile = GetCandidateProfileToCoverLetter();
            canDAO.AddJobPosting(canProfile, cddId);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            CandidateProfile canProfile = GetCandidateProfileToCoverLetter();
            canDAO.EditJobPosting(canProfile, cddId);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            CandidateProfile canProfile = GetCandidateProfileToCoverLetter();
            canDAO.RemoveJobPosting(canProfile.WorkPlace, cddId);
        }


    }
}
