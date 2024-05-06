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
    public partial class FEmployer_CandidateDetail : Form
    {
        private string cddID;
        private Candidate candidate;
        private EmployerDAO employerDAO = new EmployerDAO();

        public FEmployer_CandidateDetail(string cddID)
        {
            InitializeComponent();
            this.cddID = cddID;
        }

        private void FEmployer_CandidateDetail_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            candidate = employerDAO.GetCandidateFromDB(cddID);
            label_Name.Text = candidate.Name;
            label_Email.Text = candidate.Email;
            label_Phone.Text = candidate.Phone;
            label_Sex.Text = candidate.Sex;
            label_Hometown.Text = candidate.Hometown;
            label_Education.Text = candidate.Education;

            List<UC_Employer_Coverletter> coverLetters = employerDAO.GetCandidateProfileFromDB();
            foreach (var coverLetter in coverLetters)
            {
                flowLayoutPanel2.Controls.Add(coverLetter);
            }

            List<UC_WorkHistory> histories = employerDAO.GetCandidateWorkHistoryFromDB(cddID);
            foreach (var history in histories)
            {
                flowLayoutPanel3.Controls.Add(history);
            }
        }
    }
}
