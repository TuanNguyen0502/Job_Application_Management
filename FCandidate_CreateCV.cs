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
            uC_CV1.CreateCV_Click += createCV_Cick;
        }
        public void createCV_Cick(object sender, ButtonClickEventArgs e)
        {
            canDAO.SaveAvailableCV(e.Cv, cddid);
        }

        private void FCandidate_CreateCV_Load(object sender, EventArgs e)
        {
            if (canDAO.CheckCandidateExistsInResume(cddid))
            {
                MessageBox.Show("Bạn đã có sẵn CV rồi. Ứng tuyển công việc ngay thôi !");
                uC_CV1.Btn_CreateCV.Enabled = false;
            }
        }
    }
}
