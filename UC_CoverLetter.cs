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
    public partial class UC_CoverLetter : UserControl
    {
        public UC_CoverLetter()
        {
            InitializeComponent();
        }
        public CandidateProfile GetCandidateProfileToCoverLetter()
        {
            CandidateProfile canProfile = new CandidateProfile();
            canProfile.Objective = ktxt_CarrerGoal.Text;
            canProfile.UniversityName = ktxt_UName.Text;
            canProfile.Major = ktxt_Major.Text;
            canProfile.Gpa = ktxt_Major.Text;
            canProfile.CompanyName = ktxt_ComName.Text;
            canProfile.WorkPlace = ktxt_Nominee.Text;
            canProfile.Certification = ktxt_Certification.Text;
            return canProfile;
        }
        public event EventHandler ButtonPostJob;
        private void btn_Post_Click(object sender, EventArgs e)
        {
            ButtonPostJob?.Invoke(this, new EventArgs());
        }
        public event EventHandler ButtonEditPostJob;
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ButtonEditPostJob?.Invoke(this, new EventArgs());
        }
        public event EventHandler ButtonRemovePostJob;
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            ButtonRemovePostJob?.Invoke(this, new EventArgs());
        }
    }
}
