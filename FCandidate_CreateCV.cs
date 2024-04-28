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
        }
        public void createCV_Cick(object sender, ButtonClickEventArgs e)
        {
            canDAO.SaveAvailableCV(e.Cv, cddid);
        }
        public void removeCVValid_Click (object sender, ButtonClickEventArgs e)
        {
            int jobid = canDAO.GetJobIDByCddID(e.CddID);
            MessageBox.Show($"CddID = {e.CddID}, JobID = {e.JobID}");
            canDAO.RemoveCVValid(e.CddID, jobid);
        }

        private void FCandidate_CreateCV_Load(object sender, EventArgs e)
        {
            if (canDAO.CheckCandidateExistsInResume(cddid))
            {
                MessageBox.Show("Bạn đã có sẵn CV rồi. Ứng tuyển công việc ngay thôi !");
                uC_CV1.Btn_CreateCV.Enabled = false;
                uC_CV1.Btn_RemoveCVValid.Enabled = true;
            }
            else
            {
                MessageBox.Show("Mời bạn đăng kí CV cho riêng mình");
                uC_CV1.Btn_RemoveCVValid.Enabled = false;
                uC_CV1.Btn_CreateCV.Enabled = true;
            }
        }
    }
}
