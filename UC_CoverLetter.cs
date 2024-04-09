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
        public bool CheckNullAtCoverLetter()
        {
            if (string.IsNullOrEmpty(ktxt_CarrerGoal.Text))
            {
                MessageBox.Show("Mục tiêu nghề nghiệp bị rỗng. Cần nhập");
                return false;
            }
            if (string.IsNullOrEmpty(ktxt_UName.Text))
            {
                MessageBox.Show("Trường đại học bị rỗng. Cần nhập");
                return false;
            }
            if (string.IsNullOrEmpty(ktxt_Major.Text))
            {
                MessageBox.Show("Chuyên ngành bị rỗng. Cần nhập");
                return false;
            }
            if (string.IsNullOrEmpty(ktxt_Gpa.Text))
            {
                MessageBox.Show("GPA bị rỗng. Cần nhập");
                return false;
            }
            if (string.IsNullOrEmpty(ktxt_ComName.Text))
            {
                MessageBox.Show("Công ty bị rỗng. Cần nhập");
                return false;
            }
            if (string.IsNullOrEmpty(ktxt_Nominee.Text))
            {
                MessageBox.Show("Vị trí ứng tuyển bị rỗng. Cần nhập");
                return false;
            }
            if (string.IsNullOrEmpty(ktxt_Certification.Text))
            {
                MessageBox.Show("Chứng chỉ bị rỗng. Cần nhập");
                return false;
            }
            return true;
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
