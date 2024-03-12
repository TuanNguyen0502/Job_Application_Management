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

namespace Job_Application_Management
{
    public partial class frmCadidate_Main : KryptonForm
    {
        public frmCadidate_Main()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure want to exit this program?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            // Xử lý kết quả từ Message Box
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbbFunctions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFunctions.SelectedItem.ToString().Equals("Việc làm đã ứng tuyển"))
            {
                FCandidate_AppliedJobs fCandidate_AppliedJobs = new FCandidate_AppliedJobs();
                fCandidate_AppliedJobs.ShowDialog();
            }
            else if (cbbFunctions.SelectedItem.ToString().Equals("Việc làm đã lưu"))
            {
                FCandidate_SavedJobs fCandidate_SavedJobs = new FCandidate_SavedJobs();
                fCandidate_SavedJobs.ShowDialog();
            }
        }

        private void cbbSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSetting.SelectedItem.ToString().Equals("Cài đặt thông tin cá nhân"))
            {
                FCandidate_SubmitApplication fCandidate_SubmitApplication = new FCandidate_SubmitApplication();
                fCandidate_SubmitApplication.ShowDialog();
            }
            else if (cbbSetting.SelectedItem.ToString().Equals("Đăng xuất"))
            {
                FLogin fLogin = new FLogin();
                fLogin.ShowDialog();
            }
        }

        private void FCandidate_Load(object sender, EventArgs e)
        {

        }
    }
}
