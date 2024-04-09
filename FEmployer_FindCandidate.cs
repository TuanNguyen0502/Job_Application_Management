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
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Job_Application_Management
{
    public partial class FEmployer_FindCandidate : KryptonForm
    {
        private EmployerDAO employerDAO;
        public FEmployer_FindCandidate()
        {
            employerDAO = new EmployerDAO();
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
