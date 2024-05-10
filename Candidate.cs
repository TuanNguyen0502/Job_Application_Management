using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public class Candidate : Person
    {
        private string nominee;
        private string hometown;
        private string education;
        private string address;
        private string jobname;

        public Candidate(string id, string name, string email, string phone, string sex, string address, string hometown, string education, string nominee)
            : base(id, name, email, phone, sex)
        {
            this.hometown = hometown;
            this.education = education;
            this.address = address;
            this.nominee=nominee;
        }
        public Candidate() { }
        public string Hometown 
        { 
            get => hometown;
            set
            {
                if (value == null || value == "")
                {
                    MessageBox.Show("Chưa chỉ định quê hương");
                }
                else
                {
                    hometown = value;
                }
            }
        }
        public string Nominee 
        { 
            get => nominee; 
            set
            {
                if (value == null || value == "")
                {
                    MessageBox.Show("Chưa chỉ định công việc muốn ứng tuyển");
                }
                else
                {
                    nominee = value;
                }
            } 
        }
        public string Education 
        { 
            get => education;
            set
            {
                if (value == null || value == "")
                {
                    MessageBox.Show("Chưa chỉ định trường đại học");
                }
                else
                {
                    education = value;
                }
            }
        }
        public string Address 
        { 
            get => address;
            set
            {
                if (value == null || value == "")
                {
                    MessageBox.Show("Chưa chỉ định địa chỉ");
                }
                else
                {
                    address = value;
                }
            }
        }
        public string JobName 
        { 
            get => jobname;
            set
            {
                if (value == null || value == "")
                {
                    MessageBox.Show("Chưa chỉ định tên công việc");
                }
                else
                {
                    jobname = value;
                }
            }
        }
    }
}
