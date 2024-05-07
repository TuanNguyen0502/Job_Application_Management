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
    public partial class FSignUp : Form
    {
        CandidateDAO canDAO = new CandidateDAO();
        public FSignUp()
        {
            InitializeComponent();
        }

        private void SetCddID()
        {
            string getCddID = canDAO.GetCddID();
            int number = canDAO.ConvertCddToNumber(getCddID);
            string cddid = $"CDD{number:D3}";
            txt_CanID.Text = cddid;
        }

        private void FSignUp_Load(object sender, EventArgs e)
        {
            SetCddID();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "" && txt_Password.Text == "" && txt_Confirm.Text == "")
            {
                MessageBox.Show("Tài khoản mật khẩu còn trống.", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Password.Text != "" && txt_Confirm.Text != "" && txt_Password.Text != txt_Confirm.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận chưa khớp.", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Username.Text == "" && txt_Password.Text != "")
            {
                MessageBox.Show("Tài khoản còn trống.", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Password.Text == "" && txt_Username.Text != "")
            {
                MessageBox.Show("Mật khẩu còn trống.", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Password.Text == txt_Confirm.Text)
            {
                if (canDAO.CheckCandidateExistsInDatabase(txt_CanID.Text) == false)
                {
                    MessageBox.Show("Vui lòng nhấn vào nút 'Chi tiết' để lưu thông tin, rồi mới đăng ký tài khoản.", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    canDAO.RegisterUser(txt_Username.Text, txt_Password.Text, txt_CanID.Text);
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Username.Text = "";
            txt_Password.Text = "";
            txt_Confirm.Text = "";
        }

        private void lbl_BackLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_CanID_Click(object sender, EventArgs e)
        {
            FCandidate_RegisterInfo register = new FCandidate_RegisterInfo(txt_CanID.Text);
            register.ShowDialog();
        }

        private void lbl_InfoDetails_Click(object sender, EventArgs e)
        {
            FCandidate_RegisterInfo register = new FCandidate_RegisterInfo(txt_CanID.Text);
            register.ShowDialog();
        }

        private void ckb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = ckb_ShowPass.Checked ? '\0' : '*';
            txt_Confirm.PasswordChar = ckb_ShowPass.Checked ? '\0' : '*';
        }
    }
}
