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
        UC_Resume resume = new UC_Resume();
        private string cddid;
        // Danh sách các CV được tạo ban đầu từ các ứng viên
        
        public FCandidate_CreateCV(string cddID)
        {
            InitializeComponent();
            this.cddid = cddID;
            uC_Resume1.Btn_CreateCV.Click += btnCreateCV_Click;
        }
        public FCandidate_CreateCV()
        {
            InitializeComponent();
            canDAO = new CandidateDAO();
        }
        private void btnCreateCV_Click(object sender, EventArgs e)
        {
            //canDAO.SaveAvailableCV(cddid);
        }
        
        private void uc_AtFormCreateCV_Load(object sender, EventArgs e)
        {
        }
    }
}
