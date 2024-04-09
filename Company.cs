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

        public Company(string name, string address, string manager, string taxCode, string businessLicense)
        {
            Name = name;
            Address = address;
            Manager = manager;
            TaxCode = taxCode;
            BusinessLicense = businessLicense;
        }
        public Company() { }

        public bool CheckAllCondition()
        {
            if (CheckName() && CheckAddress() && CheckManager() && CheckTaxCode() && CheckBusinessLicense())
            {
                return true;
            }
            return false;
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
    }
}
