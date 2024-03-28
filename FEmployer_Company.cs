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
    public partial class FEmployer_Company : KryptonForm
    {
        private string name;
        private Company company;
        private EmployerDAO employerDAO;

        public FEmployer_Company(string companyName)
        {
            this.name = companyName;
            employerDAO = new EmployerDAO();
            InitializeComponent();
        }

        private void FEmployer_Company_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {
            company = employerDAO.GetCompanyFromDB(name);

            textBox_CompanyName.Text = company.Name;
            textBox_Address.Text = company.Address;
            textBox_Manager.Text = company.Manager;
            textBox_TaxCode.Text = company.TaxCode;
            textBox_BusinessLicense.Text = company.BusinessLicense;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            UpdateCompany();
            employerDAO.SaveCompanyInfor(company);
            LoadInfor();
        }

        private void UpdateCompany()
        {
            company.Address = textBox_Address.Text;
            company.Manager = textBox_Manager.Text;
            company.TaxCode = textBox_TaxCode.Text;
            company.BusinessLicense = textBox_BusinessLicense.Text;
        }
    }
}
