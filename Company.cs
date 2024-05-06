using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public class Company
    {
        private string name;
        private string address;
        private string manager;
        private string taxCode;
        private string businessLicense;
        private int numberOfEmployee;
        private int numberOfFollower;
        private string introduction;

        public Company(string name, string address, string manager, string taxCode, string businessLicense, int numberOfEmployee, int numberOfFollower, string introduction)
        {
            Name = name;
            Address = address;
            Manager = manager;
            TaxCode = taxCode;
            BusinessLicense = businessLicense;
            NumberOfEmployee = numberOfEmployee;
            NumberOfFollower = numberOfFollower;
            Introduction = introduction;
        }
        public Company() { }

        public bool CheckAllCondition()
        {
            if (CheckName() && CheckAddress() && CheckManager() && CheckTaxCode() && CheckBusinessLicense() && CheckNumberOfEmployee()
                && CheckNumberOfFollower() && CheckIntroduction())
            {
                return true;
            }
            return false;
        }

        private bool CheckIntroduction()
        {
            if (string.IsNullOrEmpty(introduction))
            {
                MessageBox.Show("Introduction cannot be empty !", "Empty introduction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckNumberOfFollower()
        {
            if (numberOfFollower == 0 || numberOfFollower.ToString() == "")
            {
                MessageBox.Show("Number of followers cannot be empty !", "Empty followers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckNumberOfEmployee()
        {
            if (numberOfEmployee == 0 || numberOfEmployee.ToString() == "")
            {
                MessageBox.Show("Number of employees cannot be empty !", "Empty employees", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckBusinessLicense()
        {
            if (string.IsNullOrEmpty(businessLicense))
            {
                MessageBox.Show("Business License cannot be empty !", "Empty business license", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckTaxCode()
        {
            if (string.IsNullOrEmpty(taxCode))
            {
                MessageBox.Show("Taxcode cannot be empty !", "Empty taxcode", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckManager()
        {
            if (string.IsNullOrEmpty(manager))
            {
                MessageBox.Show("Manager's name cannot be empty !", "Empty Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckAddress()
        {
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address cannot be empty !", "Empty address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckName()
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Company's name cannot be empty !", "Empty name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Manager { get => manager; set => manager = value; }
        public string TaxCode { get => taxCode; set => taxCode = value; }
        public string BusinessLicense { get => businessLicense; set => businessLicense = value; }
        public int NumberOfEmployee { get => numberOfEmployee; set => numberOfEmployee = value; }
        public int NumberOfFollower { get => numberOfFollower; set => numberOfFollower = value; }
        public string Introduction { get => introduction; set => introduction = value; }
    }
}
