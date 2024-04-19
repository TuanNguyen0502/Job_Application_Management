using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Job_Application_Management
{
    public partial class FEmployer_Information : KryptonForm
    {
        private string empID;
        private Employer employer;
        private EmployerDAO employerDAO;

        public FEmployer_Information(string empID)
        {
            this.empID = empID;
            employerDAO = new EmployerDAO();
            InitializeComponent();
        }

        private void FEmployer_Information_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {
            employer = employerDAO.GetEmployerFromDB(empID);

            textBox_ID.Text = employer.Id;
            textBox_Email.Text = employer.Email;
            textBox_Name.Text = employer.Name;
            if (employer.Sex == "Nam")
            {
                radioButton_Male.Checked = true;
            }
            else
            {
                radioButton_Female.Checked = true;
            }
            textBox_PhoneNumber.Text = employer.Phone;
            comboBox_Workplace.Text = employer.Workplace;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            UpdateEmployer();
            if (employer.CheckAllCondition())
            {
                employerDAO.UpdateEmployerInfor(employer);
            }
            LoadInfor();
        }

        private void UpdateEmployer()
        {
            string sex;
            if (radioButton_Male.Checked)
            {
                sex = "Nam";
            }
            else
            {
                sex = "Nữ";
            }
            employer.Name = textBox_Name.Text;
            employer.Phone = textBox_PhoneNumber.Text;
            employer.Sex = sex;
            employer.Workplace = comboBox_Workplace.SelectedItem.ToString();
        }

        private void button_Company_Click(object sender, EventArgs e)
        {
            FEmployer_Company fEmployer_Company = new FEmployer_Company(employer.CompanyName);
            fEmployer_Company.Size = new Size(1800, 500);
            fEmployer_Company.ShowDialog();
            if (fEmployer_Company.DialogResult == DialogResult.OK)
            {
                LoadInfor();
            }
        }
    }
}
