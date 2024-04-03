using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Security.Cryptography;

namespace Job_Application_Management
{
    public partial class FEmployer_ApprovedCandidate : KryptonForm
    {
        private Form currentFormChild;
        private string jobID;
        private EmployerDAO employerDAO;
        public FEmployer_ApprovedCandidate(string jobID)
        {
            employerDAO = new EmployerDAO();
            this.jobID = jobID;
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.FormBorderStyle = FormBorderStyle.Sizable;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Detail_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FCandidate_CreateCV());
        }

        private void button_Refuse_Click(object sender, EventArgs e)
        {

        }

        private void FEmployer_ApprovedCandidate_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {
            string status = "Đã xác nhận";
            List<UC_CandidateCV> resumeItems = employerDAO.GetCandidateResumeFromDB(jobID, status);
            foreach (var resume in resumeItems)
            {
                flowLayoutPanel1.Controls.Add(resume);
            }
        }
    }
}
