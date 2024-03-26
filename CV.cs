using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;

namespace Job_Application_Management
{
    public class CV
    {
        public string workPlace;
        public string phone;
        public string email;
        public string address;
        public string careerGoal;
        public string uSchool;
        public string startDateEducation;
        public string endDateEducaiton;
        public string major;
        //public string academicAchivement;
        public string workedCompanyName;
        public string workedWorkPlace;
        //public string workedAchivement;
        public string certificate;

        public DateTime timeCertificate;
        public CV(string workPlace, string phone, string email, string address, string careerGoal, string uSchool, string startDate, string endDate, string major, string workedCompanyName, string workedWorkPlace, string certificate, DateTime timeCertificate)
        {
            this.workPlace=workPlace;
            this.phone=phone;
            this.email=email;
            this.address=address;
            this.careerGoal=careerGoal;
            USchool=uSchool;
            this.startDateEducation=startDate;
            this.endDateEducaiton=endDate;
            this.major=major;
            this.workedCompanyName=workedCompanyName;
            this.workedWorkPlace=workedWorkPlace;
            this.certificate=certificate;
            this.timeCertificate = timeCertificate;
        }
        public string WorkPlace { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string CareerGoal { get; set; }
        public string USchool { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Major { get; set; }
        public string WorkedCompanyName { get; set; }
        public string WorkedWorkPlace { get; set; }
        public string Certificate { get; set; }
        public DateTime TimeCertificate { get; set; }
    }
}
