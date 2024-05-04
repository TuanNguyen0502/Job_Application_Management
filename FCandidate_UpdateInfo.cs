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
    public partial class FCandidate_UpdateInfo : Form
    {
        CandidateDAO candidateDAO = new CandidateDAO();
        private string cddid;
        public FCandidate_UpdateInfo(string cddid)
        {
            InitializeComponent();
            this.cddid=cddid;
        }

        private void FCandidate_UpdateInfo_Load(object sender, EventArgs e)
        {
            LoadCandidateInfo();
        }

        private void LoadCandidateInfo()
        {
            Candidate candidate = candidateDAO.GetCandidateInfor(cddid);
            textBox_ID.Text = candidate.Id;
            textBox_Name.Text = candidate.Name;
            textBox_PhoneNumber.Text = candidate.Phone;
            textBox_Email.Text = candidate.Email;
            textBox_Address.Text = candidate.Address;
            textBox_Hometown.Text = candidate.Hometown;
            textBox_Education.Text = candidate.Education;
            if (candidate.Sex.Equals("Nam"))
            {
                radioButton_Male.Checked = true;
                radioButton_Female.Checked = false;
            }
            else
            {
                radioButton_Male.Checked = false;
                radioButton_Female.Checked = true;
            }
        }
    }
}
