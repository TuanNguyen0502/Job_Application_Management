using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application_Management
{
    public class Person
    {
        private string id;
        private string name;
        private string email;
        private string phone;
        private string sex;
        private string address;

        public Person(string id, string name, string email, string phone, string sex, string address) 
        {
            this.Id = id;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.sex = sex;
            this.address = address;
        }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Id { get => id; set => id = value; }
        public string Address { get => address; set => address = value; }
    }
}
