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

        public Employer(string id, string name, string email, string phone, string sex, string workplace) 
            : base(id, name, email, phone, sex)
        {
            this.Workplace = workplace;
        }

        public string Workplace { get => workplace; set => workplace = value; }
    }
}
