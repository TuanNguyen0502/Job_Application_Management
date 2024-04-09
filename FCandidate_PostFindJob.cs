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
            uC_CoverLetter1.ButtonPostJob += btnAddPostJob_Click;
            uC_CoverLetter1.ButtonEditPostJob += btnEditPostJob_Click;
            uC_CoverLetter1.ButtonRemovePostJob += btnRemovePostJob_Click;
        }
        public FCandidate_PostFindJob()
        {
            InitializeComponent();
        }

        private void uC_CoverLetter1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPostJob_Click(object sender, EventArgs args)
        {
            CandidateProfile canProfile = uC_CoverLetter1.GetCandidateProfileToCoverLetter();
            if(uC_CoverLetter1.CheckNullAtCoverLetter())
                canDAO.AddJobPosting(canProfile, cddId);
        }
        private void btnEditPostJob_Click(object sender, EventArgs args)
        {
            CandidateProfile canProfile = uC_CoverLetter1.GetCandidateProfileToCoverLetter();
            canDAO.EditJobPosting(canProfile, cddId);
        }
        private void btnRemovePostJob_Click(object sender, EventArgs args)
        {
            CandidateProfile canProfile = uC_CoverLetter1.GetCandidateProfileToCoverLetter();
            canDAO.RemoveJobPosting(canProfile.WorkPlace, cddId);
        }
    }
}
