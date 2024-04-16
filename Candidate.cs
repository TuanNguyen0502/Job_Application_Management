using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application_Management
{
    public class Candidate : Person
    {
        private string hometown;
        private string education;
        private string address;
        private string jobname;

        public Candidate(string id, string name, string email, string phone, string sex, string address, string hometown, string education) 
            : base(id, name, email, phone, sex)
        {
            this.hometown = hometown;
            this.education = education;
            this.address = address;
        }
        public Candidate() { }
        public string Hometown { get => hometown; set => hometown = value; }
        public string Education { get => education; set => education = value; }
        public string Address { get => address; set => address = value; }
        public string JobName { get => jobname; set => jobname = value; }
    }
}
