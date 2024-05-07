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
            uC_CV1.CreateCV_Click += createCV_Cick;
            uC_CV1.RemoveCVValid_Click += removeCVValid_Click;
            uC_CV1.Button_Approve.Visible = false;
            uC_CV1.Button_Refuse.Visible = false;
        }

        public void SetEnableCreateCVButton()
        {
            uC_CV1.Btn_RemoveCVValid.Enabled = false;
            uC_CV1.Btn_CreateCV.Enabled = true;
        }

        public void SetEnableRemoveCVButton()
        {
            uC_CV1.Btn_CreateCV.Enabled = false;
            uC_CV1.Btn_RemoveCVValid.Enabled = true;
        }

        public void createCV_Cick(object sender, ButtonClickEventArgs e)
        {
            SetEnableCreateCVButton();
            canDAO.SaveAvailableCV(e.Cv, cddid);
            this.Close();
        }
        public void removeCVValid_Click (object sender, ButtonClickEventArgs e)
        {
            SetEnableRemoveCVButton();
            canDAO.RemoveCVValid(e.CddID);
            this.Close();
        }

        private void FCandidate_CreateCV_Load(object sender, EventArgs e)
        {
            string CddName = canDAO.GetNameByCddID(cddid);
            uC_CV1.Label_CandidateName.Text = CddName;
            if (canDAO.CheckCandidateExistsInResume(cddid))
            {
                MessageBox.Show("Bạn đã có sẵn CV rồi. Ứng tuyển công việc ngay thôi !");
                SetEnableRemoveCVButton();
            }
            else
            {
                MessageBox.Show("Mời bạn đăng kí CV cho riêng mình");
                SetEnableCreateCVButton();
            }
        }
    }
}
