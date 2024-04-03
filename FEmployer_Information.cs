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
        private string sqlQuery;
        private Form currentFormChild;

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
            //employerDAO.SaveEmployerInfor(employer);
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
            employer.Workplace = comboBox_Workplace.SelectedText;
        }

        private void button_Company_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_Company(employer.CompanyName));
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
