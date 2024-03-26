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
        private EmployerDAO employerDAO;
        private string connStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Jobs_Management;Integrated Security=True";
        private string sqlQuery;
        public FEmployer_Information()
        {
            employerDAO = new EmployerDAO();
            InitializeComponent();
        }

        private void FEmployer_Information_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                sqlQuery = "SELECT ID, Email, Name, Sex, Phone, Workplace FROM Employers WHERE ID = 'E001'";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBox_ID.Text = reader.GetString(0);
                        textBox_Email.Text = reader.GetString(1);
                        textBox_Name.Text = reader.GetString(2);
                        // Add sex
                        if (reader.GetString(3) == "Nam")
                        {
                            radioButton_Male.Checked = true;
                        }
                        else
                        {
                            radioButton_Female.Checked = true;
                        }
                        //
                        textBox_PhoneNumber.Text = reader.GetString(4);
                        comboBox_Workplace.Text = reader.GetString(5);
                    }
                }
                else
                    MessageBox.Show("No rows found");
            }
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            Employer employer = CreateEmployer();
            employerDAO.SaveInfor(employer);
            LoadInfor();
        }
        private Employer CreateEmployer()
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
            Employer employer = new Employer("E001", textBox_Name.Text, textBox_Email.Text, textBox_PhoneNumber.Text, sex, comboBox_Workplace.SelectedText);
            return employer;
        }
    }
}
