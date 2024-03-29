﻿using System;
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
        public FLogin()
        {
            InitializeComponent();

            textBox_UserName.Click += textBox_UserName_Click;
            textBox_UserName.GotFocus += textBox_UserName_GotFocus;
            textBox_UserName.LostFocus += textBox_UserName_LostFocus;

            textBox_Password.Click += textBox_Password_Click;
            textBox_Password.GotFocus += textBox_Password_GotFocus;
            textBox_Password.LostFocus += textBox_Password_LostFocus;
        }

        private bool CheckEmpty()
        {
            if (textBox_UserName.Text.Length == 0) 
            {
                MessageBox.Show("Please enter your user name");
                return false; 
            }
            if (textBox_Password.Text.Length == 0) 
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

        private void textBox_Password_Click(object sender, EventArgs e)
        {
            // Clear the text in the KryptonTextBox when the button is clicked
            textBox_Password.Text = "";
            textBox_Password.Focus();
        }

        private void textBox_Password_GotFocus(object sender, EventArgs e)
        {
            // Clear the default text when the KryptonTextBox gets focus
            if (textBox_Password.Text == ("Enter password"))
            {
                textBox_Password.Text = "";
            }
        }

        private void textBox_Password_LostFocus(object sender, EventArgs e)
        {
            // Restore the default text if the KryptonTextBox is empty
            if (string.IsNullOrWhiteSpace(textBox_Password.Text))
            {
                textBox_Password.Text = "Enter password";
            }
        }

        private void textBox_UserName_Click(object sender, EventArgs e)
        {
            // Clear the text in the KryptonTextBox when the button is clicked
            textBox_UserName.Text = "";
            textBox_UserName.Focus();
        }

        private void textBox_UserName_GotFocus(object sender, EventArgs e)
        {
            // Clear the default text when the KryptonTextBox gets focus
            if (textBox_UserName.Text == ("Enter user name"))
            {
                textBox_UserName.Text = "";
            }
        }

        private void textBox_UserName_LostFocus(object sender, EventArgs e)
        {
            // Restore the default text if the KryptonTextBox is empty
            if (string.IsNullOrWhiteSpace(textBox_UserName.Text))
            {
                textBox_UserName.Text = "Enter user name";
            }
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
                if (radioButton_Candidate.Checked)
                {
                    Program.MainFormManager.CurrentForm = new FCandidate();
                }
                if (radioButton_Employer.Checked)
                {
                    Program.MainFormManager.CurrentForm = new FEmployer("E001");
                }
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
