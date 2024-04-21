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
            if (Introduction == null || introduction == "")
            {
                MessageBox.Show("Introduction cannot be null !");
                return false;
            }
            return true;
        }

        public bool CheckNumberOfFollower()
        {
            if (numberOfFollower == 0 || numberOfFollower.ToString() == "")
            {
                MessageBox.Show("Number of follower cannot be null !");
                return false;
            }
            return true;
        }

        public bool CheckNumberOfEmployee()
        {
            if (numberOfEmployee == 0 || numberOfEmployee.ToString() == "")
            {
                MessageBox.Show("Number of employee cannot be null !");
                return false;
            }
            return true;
        }

        public bool CheckBusinessLicense()
        {
            if (businessLicense == null || businessLicense == "")
            {
                MessageBox.Show("Business License cannot be null !");
                return false;
            }
            return true;
        }

        public bool CheckTaxCode()
        {
            if (taxCode == null || taxCode == "")
            {
                MessageBox.Show("Tax code cannot be null !");
                return false;
            }
            return true;
        }

        public bool CheckManager()
        {
            if (manager == null || manager == "")
            {
                MessageBox.Show("Manager name cannot be null !");
                return false;
            }
            return true;
        }

        public bool CheckAddress()
        {
            if (address == null || address == "")
            {
                MessageBox.Show("Address cannot be null !");
                return false;
            }
            return true;
        }

        public bool CheckName()
        {
            if (Name == null || name == "")
            {
                MessageBox.Show("Name cannot be null !");
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
