using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application_Management
{
    public class Employer : Person
    {
        private string workplace;
        private string company;
        public Employer(string id, string name, string email, string phone, string sex, string address, string workplace, string company) 
            : base(id, name, email, phone, sex, address)
        {
            this.Workplace = workplace;
            this.Company = company;
        }

        public string Workplace { get => workplace; set => workplace = value; }
        public string Company { get => company; set => company = value; }
    }
}
