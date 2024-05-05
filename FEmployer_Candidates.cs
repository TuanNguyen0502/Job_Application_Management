using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Job_Application_Management
{
    public partial class FEmployer_Candidates : Form
    {
        private EmployerDAO employerDAO = new EmployerDAO();

        public FEmployer_Candidates()
        {
            InitializeComponent();
        }

        private void FEmployer_FindCandidate_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {
            List<UC_CoverLetter> resumeItems = employerDAO.GetCandidateProfileFromDB();
            foreach (var resume in resumeItems)
            {
                flowLayoutPanel1.Controls.Add(resume);
            }
        }
    }
}
