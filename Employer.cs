﻿using System;
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
            if (string.IsNullOrEmpty(companyName))
            {
                MessageBox.Show("Company's name cannot be empty !", "Empty name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckWorkplace()
        {
            if (string.IsNullOrEmpty(workplace))
            {
                MessageBox.Show("Workplace cannot be empty !", "Empty workplace", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public string Workplace { get => workplace; set => workplace = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
    }
}
