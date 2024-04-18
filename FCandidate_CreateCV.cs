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
        UC_CV resume = new UC_CV();
        private string cddid;
        // Danh sách các CV được tạo ban đầu từ các ứng viên
        
        public FCandidate_CreateCV(string cddID)
        {
            InitializeComponent();
            this.cddid = cddID;
            resume.CreateCV += createCV_Cick;
        }
        public void createCV_Cick(object sender, EventArgs e)
        {
            MessageBox.Show(cddid);
            canDAO.SaveAvailableCV(cddid);
        }
        /*public void createResume_Cick(object sender, ButtonClickEventArgs e)
        {
            CV cv = canDAO.GetAvailableCVByCandidateID(cddid);
            if (cv != null)
            {
                canDAO.SaveResumeToDatabase(cv,cddid);
            }
            else
            {
                MessageBox.Show("Chưa tồn tại CV có sẵn. Vui lòng tạo CV có sẵn rồi mới úng tuyển.");
            }
        }*/
        public FCandidate_CreateCV()
        {
            InitializeComponent();
            canDAO = new CandidateDAO();
        }

    }
}
