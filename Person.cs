using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

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

        public bool CheckSex()
        {
            if (sex == null)
            {
                MessageBox.Show("Gender cannot be null !");
                return false;
            }
            sex = sex.ToLower();
            if (sex != "nam" || sex != "nữ" || sex != "male" || sex != "female")
            {
                MessageBox.Show("Gender is not correct !");
                return false;
            }
            return true;
        }

        public bool CheckPhone()
        {
            if (phone == null)
            {
                MessageBox.Show("Phone number cannot be null !");
                return false;
            }
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
            MessageBox.Show("Phone number is not in correct form !");
            return false;
        }

        public bool CheckEmail()
        {
            if (this.email == null)
            {
                MessageBox.Show("Email cannot be null !");
                return false;
            }
            if (EmailIsValid(this.email) == false)
            {
                MessageBox.Show("Email is not in the correct form !");
            }
            return true;
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

        public bool CheckName()
        {
            if (this.name == null)
            {
                MessageBox.Show("Name cannot be null !");
                return false;
            }
            return true;
        }

        public bool CheckID()
        {
            if (this.id == null)
            {
                MessageBox.Show("ID cannot be null !");
                return false;
            }
            return true;
        }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Id { get => id; set => id = value; }
    }
}
