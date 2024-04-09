using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public class Employer : Person
    {
        private string workplace;
        private string companyName;

        public Employer(string id, string name, string email, string phone, string sex, string workplace, string companyName) 
            : base(id, name, email, phone, sex)
        {
            this.Workplace = workplace;
            this.CompanyName = companyName;
        }
        public Employer()
        { }

        public bool CheckAllCondition()
        {
            if (CheckName() && CheckEmail() && CheckPhone() && CheckGender() && CheckWorkplace() && CheckWorkplace() && CheckCompanyName())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckCompanyName()
        {
            if (this.companyName == null || companyName == "")
            {
                MessageBox.Show("Company cannot be null !");
                return false;
            }
            return true;
        }

        public bool CheckWorkplace()
        {
            if (this.Workplace == null || Workplace == "")
            {
                MessageBox.Show("Workplace cannot be null !");
                return false;
            }
            return true;
        }

        public string Workplace { get => workplace; set => workplace = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
    }
}
