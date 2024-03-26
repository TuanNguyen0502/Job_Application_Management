using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Manager { get => manager; set => manager = value; }
        public string TaxCode { get => taxCode; set => taxCode = value; }
        public string BusinessLicense { get => businessLicense; set => businessLicense = value; }
    }
}
