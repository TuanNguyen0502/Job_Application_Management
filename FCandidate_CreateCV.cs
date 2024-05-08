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
    public partial class FCandidate_CreateCV : Form
    {
        CandidateDAO canDAO = new CandidateDAO();
        private string cddid;
        // Danh sách các CV được tạo ban đầu từ các ứng viên
        
        public FCandidate_CreateCV(string cddID)
        {
            InitializeComponent();
            this.cddid = cddID;
            uC_CV1.CddID = cddID;
            uC_CV1.CreateCV += createCV_Cick;
            uC_CV1.RemoveCV += removeCVValid_Click;
            uC_CV1.AddEdu += addEducation_Click;
            uC_CV1.AddEx += addExperience_Click;
            uC_CV1.AddCer += addCertification_Click;
        }

        private void addEducation_Click (object sender, EventArgs e)
        {
            UC_Education edu = new UC_Education();
            uC_CV1.Flp_Educations.Controls.Add(edu);
        }
        private void addExperience_Click(object sender, EventArgs e)
        {
            UC_Experiences exp = new UC_Experiences();
            uC_CV1.Flp_Experiences.Controls.Add(exp);
        }
        private void addCertification_Click(object sender, EventArgs e)
        {
            UC_Certification cer = new UC_Certification();
            uC_CV1.Flp_Certifications.Controls.Add(cer);
        }

        public void SetEnableCreateCVButton()
        {
            uC_CV1.Btn_RemoveCVValid.Enabled = false;
            uC_CV1.Btn_CreateCV.Enabled = true;
        }

        public void createCV_Cick(object sender, ButtonClickEventArgs e)
        {
            SetEnableCreateCVButton();
            canDAO.SaveAvailableCV(e.Cv, cddid);
            this.Close();
        }
        public void removeCVValid_Click (object sender, ButtonClickEventArgs e)
        {
            canDAO.RemoveCVValid(e.CddID);
            this.Close();
        }

        private void FCandidate_CreateCV_Load(object sender, EventArgs e)
        {
            uC_CV1.Label_CandidateName.Text = canDAO.GetNameByCddID(cddid);
            uC_CV1.Label_Nominee.Text = "";
            if (canDAO.CheckCandidateExistsInResume(cddid))
            {
                MessageBox.Show("Bạn đã có sẵn CV rồi. Ứng tuyển công việc ngay thôi !");
            }
            else
            {
                MessageBox.Show("Mời bạn đăng kí CV cho riêng mình");
                SetEnableCreateCVButton();
            }
        }
    }
}
