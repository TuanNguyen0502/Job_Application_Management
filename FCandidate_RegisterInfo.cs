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
    public partial class FCandidate_RegisterInfo : Form
    {
        private string cddid;
        CandidateDAO canDAO = new CandidateDAO();
        public FCandidate_RegisterInfo(string cddid)
        {
            InitializeComponent();
            this.cddid = cddid;
        }

        public Candidate GetInforAtForm()
        {
            Candidate c = new Candidate();
            c.Id = this.cddid;
            c.Name = textBox_Name.Text;
            c.Address = textBox_Address.Text;
            c.Phone = textBox_PhoneNumber.Text;
            c.Email = textBox_Email.Text;
            c.Hometown = textBox_Hometown.Text;
            if (radioButton_Male.Checked)
            {
                c.Sex = "Nam";
            }
            else
            {
                c.Sex = "Nữ";
            }
            c.Education = textBox_Education.Text;
            return c;
        }

        private void FCandidate_RegisterInfo_Load(object sender, EventArgs e)
        {
            textBox_ID.Text = cddid;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Candidate can = GetInforAtForm();
            if (canDAO.RegisterCandidateInfo(can))
            {
                MessageBox.Show("Đăng ký thông tin thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thông tin thất bại!", "Xem lại thông tin đã nhập đúng chưa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            textBox_Name.Text = "";
            textBox_Address.Text = "";
            textBox_PhoneNumber.Text = "";
            textBox_Email.Text = "";
            textBox_Education.Text = "";
            textBox_Hometown.Text = "";
            if (radioButton_Male.Checked)
            {
                radioButton_Male.Checked = false;
            } 
            else if (radioButton_Female.Checked)
            {
                radioButton_Female.Checked = false;
            }
        }
    }
}
