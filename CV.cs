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
        private string careerGoal;
        private string workPlace;
        private string phone;
        private string email;
        private string address;
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

        private string cddName;
        private string cddPhone;
        private string cddEmail;
        private string cddAddress;
        private string universityName;
        private string gpa;
        private DateTime universityStartDate;
        private DateTime universityEndDate;
        private string workedDetail;
        private DateTime companyStartDate;
        private DateTime companyEndDate;

        private string jobName;

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

        public CV(string CddID, string JobID, string careerGoal, string universityName, string major, string gpa, DateTime universityStartDate, 
            DateTime universityEndDate, string companyName, string workPlace, string workedDetail, DateTime companyStartDate, DateTime companyEndDate, 
            string certificate, DateTime timeCertificate)
        {
            this.cddID = CddID;
            this.jobID = JobID;
            this.careerGoal = careerGoal;
            this.universityName = universityName;
            this.major = major;
            this.gpa = gpa;
            this.universityStartDate = universityStartDate;
            this.universityEndDate = universityEndDate;
            this.WorkedCompanyName = companyName;
            this.workPlace = workPlace;
            this.workedDetail = workedDetail;
            this.companyStartDate = companyStartDate;
            this.companyEndDate = companyEndDate;
            this.certificate = certificate;
            this.timeCertificate = timeCertificate;
        }

        public CV() { }

        public string CddID { get => cddID; set => cddID = value; }
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
        public string UniversityName { get => universityName; set => universityName = value; }
        public string Gpa { get => gpa; set => gpa = value; }
        public DateTime UniversityStartDate { get => universityStartDate; set => universityStartDate = value; }
        public DateTime UniversityEndDate { get => universityEndDate; set => universityEndDate = value; }
        public string WorkedDetail { get => workedDetail; set => workedDetail = value; }
        public DateTime CompanyStartDate { get => companyStartDate; set => companyStartDate = value; }
        public DateTime CompanyEndDate { get => companyEndDate; set => companyEndDate = value; }
        public string CddPhone { get => cddPhone; set => cddPhone = value; }
        public string CddEmail { get => cddEmail; set => cddEmail = value; }
        public string CddAddress { get => cddAddress; set => cddAddress = value; }
        public string CddName { get => cddName; set => cddName = value; }
        public string JobName { get => jobName; set => jobName = value; }
    }
}
