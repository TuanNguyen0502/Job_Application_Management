using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Job_Application_Management
{
    public class Person
    {
        private string id;
        private string name;
        private string email;
        private string phone;
        private string sex;

        public Person(string id, string name, string email, string phone, string sex) 
        {
            this.Id = id;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.sex = sex;
        }

        public Person()
        { }

        public bool CheckID()
        {
            if (id == null) return false; return true;
        }
        public bool CheckName()
        {
            if (name == null) return false; return true;
        }
        public bool CheckEmail()
        {
            if (email == null || EmailIsValid(Email) == false) return false; return true;
        }
        private static bool EmailIsValid(string email)
        {
            var valid = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }

            return valid;
        }
        public bool CheckPhone()
        {
            if (phone.StartsWith("0"))
            {
                if (phone.Length == 10)
                    return true;
            }
            else if (phone.StartsWith("+84"))
            {
                if (phone.Length == 12)
                    return true;
            }
            return false;
        }
        public bool CheckSex()
        {
            if (sex == null) return false; return true;
        }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Id { get => id; set => id = value; }
    }
}
