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
    public partial class FCandidate : Form
    {
        public FCandidate()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
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
                FCandidate_AppliedJobs aj = new FCandidate_AppliedJobs();
                aj.ShowDialog();
            }
            else if (cbbFunctions.SelectedItem.ToString().Equals("Việc làm đã lưu"))
            {
                FCandidate_SavedJobs sj = new FCandidate_SavedJobs();
                sj.ShowDialog();
            }
        }

        private void cbbSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSetting.SelectedItem.ToString().Equals("Cài đặt thông tin cá nhân"))
            {
                FCandidate_SubmitApplication sa = new FCandidate_SubmitApplication();
                sa.ShowDialog();
            }
            else if (cbbSetting.SelectedItem.ToString().Equals("Đăng xuất"))
            {
                FLogin log = new FLogin();
                log.ShowDialog();
            }
        }
    }
}
