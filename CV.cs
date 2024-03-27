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
        private string cddID;
        private string jobID;
        private string workPlace;
        private string phone;
        private string email;
        private string address;
        private string careerGoal;
        private string uSchool;
        private string startDateEducation;
        private string endDateEducaiton;
        private string major;
        //public string academicAchivement;
        public string workedCompanyName;
        public string workedWorkPlace;
        //public string workedAchivement;
        public string certificate;
        public DateTime timeCertificate;
        public CV(string CddID, string JobID, string workPlace, string phone, string email, string address, string careerGoal, string uSchool, string startDate, string endDate, string major, string workedCompanyName, string workedWorkPlace, string certificate, DateTime timeCertificate)
        {
            this.cddID = CddID;
            this.jobID = JobID;
            this.workPlace=workPlace;
            this.phone=phone;
            this.email=email;
            this.address=address;
            this.careerGoal=careerGoal;
            this.uSchool=uSchool;
            this.startDateEducation=startDate;
            this.endDateEducaiton=endDate;
            this.major=major;
            this.workedCompanyName=workedCompanyName;
            this.workedWorkPlace=workedWorkPlace;
            this.certificate=certificate;
            this.timeCertificate = timeCertificate;
        }
        public string CddID { get => cddID; }
        public string JobID { get; set; }
        public string WorkPlace { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string CareerGoal { get; set; }
        public string USchool { get => uSchool; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Major { get; set; }
        public string WorkedCompanyName { get; set; }
        public string WorkedWorkPlace { get; set; }
        public string Certificate { get; set; }
        public DateTime TimeCertificate { get; set; }
    }
}
