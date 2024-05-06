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
            List<UC_Employer_Candidate> candidates = employerDAO.GetCandidatesFromDB();
            foreach (var candidate in candidates)
            {
                flowLayoutPanel1.Controls.Add(candidate);
            }
        }

        private void button_LoadData_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadInfor();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (textBox_Search.Text == null || textBox_Search.Text == "")
            {
                flowLayoutPanel1.Controls.Clear();
                LoadInfor();
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
                List<UC_Employer_Candidate> candidates = employerDAO.SearchCandidatesFromDB(textBox_Search.Text);
                foreach (var candidate in candidates)
                {
                    flowLayoutPanel1.Controls.Add(candidate);
                }
            }
        }
    }
}
