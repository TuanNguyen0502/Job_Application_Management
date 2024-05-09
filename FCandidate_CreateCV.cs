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
        private void FCandidate_CreateCV_Load(object sender, EventArgs e)
        {
            uC_CV1.Button_Approve.Visible = false;
            uC_CV1.Button_Refuse.Visible = false;
            CheckCV();
        }

        private void CheckCV()
        {
            if (canDAO.CheckCandidateExistsInDatabase(cddid))
            {
                DialogResult result = MessageBox.Show("Bạn đã có sẵn CV rồi. Bạn muốn đăng ký thêm CV nữa?", "Đăng ký CV", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
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

        public void createCV_Cick(object sender, ButtonClickEventArgs e)
        {
            canDAO.SaveAvailableCV(e.Cv, cddid);
            this.Close();
        }
        public void removeCVValid_Click (object sender, ButtonClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa CV này không?", "Xóa CV", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                canDAO.RemoveCVValid(e.Cv.ID);
                this.Close();
            }
        }

    }
}
