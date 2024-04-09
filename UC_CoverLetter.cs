using ComponentFactory.Krypton.Toolkit;
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
        private string cddID;
        public KryptonTextBox textBox_Name { get => ktxt_FullName; set => ktxt_FullName = value; }
        public KryptonTextBox textBox_Job { get => ktxt_JobApp; set => ktxt_JobApp = value; }
        public KryptonTextBox textBox_Objective { get => ktxt_CarrerGoal; set => ktxt_CarrerGoal = value; }
        public KryptonTextBox textBox_University { get => ktxt_UName; set => ktxt_UName = value; }
        public KryptonTextBox textBox_Major { get => ktxt_Major; set => ktxt_Major = value; }
        public KryptonTextBox textBox_GPA { get => ktxt_Gpa; set => ktxt_Gpa = value; }
        public KryptonTextBox textBox_Company { get => ktxt_ComName; set => ktxt_ComName = value; }
        public KryptonTextBox textBox_Workplace { get => ktxt_Nominee; set => ktxt_Nominee = value; }
        public KryptonTextBox textBox_Certification { get => ktxt_Certification; set => ktxt_Certification = value; }
        public string CddID { get => cddID; set => cddID = value; }

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
