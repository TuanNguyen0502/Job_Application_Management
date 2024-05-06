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
    public partial class FLogin : KryptonForm
    {
        DBConnection dBConnection = new DBConnection();

        public FLogin()
        {
            InitializeComponent();
        }

        private bool CheckEmpty()
        {
            if (textBox_UserName.Text == "Enter user name") 
            {
                MessageBox.Show("Please enter your user name");
                return false; 
            }
            if (textBox_Password.Text == "Enter password") 
            {
                MessageBox.Show("Please enter your password");
                return false; 
            }
            if (radioButton_Candidate.Checked == false && radioButton_Employer.Checked == false) 
            {
                MessageBox.Show("Please choose your role");
                return false; 
            }
            return true;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            FSignUp signUp = new FSignUp();
            signUp.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                string sql = $"Select Username, Password, CddID, EmpID " +
                    $"FROM USERS " +
                    $"WHERE Username = '{textBox_UserName.Text}'";
                List<Dictionary<string, object>> user = dBConnection.GetUserFromDB(sql);

                // Check exist
                if (user is null)
                {
                    MessageBox.Show("User name does not exist !");
                    return;
                }
                // Check pass
                if (user[0]["Password"].ToString() != textBox_Password.Text)
                {
                    MessageBox.Show("Wrong password !");
                    return;
                }
                
                if (radioButton_Candidate.Checked)
                {
                    string cddID = user[0]["CddID"].ToString();
                    // Check role
                    if (cddID == "")
                    {
                        MessageBox.Show("You are not Candidate !");
                        return;
                    }

                    Program.MainFormManager.CurrentForm = new FCandidateMain(cddID);
                }
                if (radioButton_Employer.Checked)
                {
                    string empID = user[0]["EmpID"].ToString();
                    // Check role
                    if (empID == "")
                    {
                        MessageBox.Show("You are not Employer !");
                        return;
                    }

                    Program.MainFormManager.CurrentForm = new FEmployerMain(empID);
                }
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ckb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Password.PasswordChar = ckb_ShowPass.Checked ? '\0' : '*';
        }
    }
}
