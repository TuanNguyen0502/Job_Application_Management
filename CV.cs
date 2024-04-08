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
        private int jobID;
        private string objective;
        private string universityName;
        private string major;
        private string gpa;
        private DateTime universityStartDate;
        private DateTime universityEndDate;
        private string companyName;
        private string workPlace;
        private string workedDetail;
        private DateTime companyStartDate;
        private DateTime companyEndDate;
        private string certification;
        private DateTime certificationDate;
        private string status;
        // Thuộc tính từ bảng khác
        private string jobName;
        private string cddName;
        private string cddAddress;
        private string cddEmail;
        private string cddPhone;
        

        public CV(string cddID, int jobID, string objective, string universityName, string major, string gpa, DateTime universityStartDate, DateTime universityEndDate, string companyName, string workPlace, string workedDetail, DateTime companyStartDate, DateTime companyEndDate, string certificationName, DateTime certificationDate, string jobName, string cddName, string cddAddress, string cddEmail, string cddPhone)
        {
            CddID=cddID;
            JobID=jobID;
            this.objective=objective;
            UniversityName=universityName;
            Major=major;
            Gpa=gpa;
            UniversityStartDate=universityStartDate;
            UniversityEndDate=universityEndDate;
            this.companyName=companyName;
            this.workPlace=workPlace;
            WorkedDetail=workedDetail;
            CompanyStartDate=companyStartDate;
            CompanyEndDate=companyEndDate;
            this.certification=certificationName;
            this.certificationDate=certificationDate;
            JobName=jobName;
            CddName=cddName;
            CddAddress=cddAddress;
            CddEmail=cddEmail;
            CddPhone=cddPhone;
        }
        public CV (string cddID, string objective, string universityName, string major, string gpa, string companyName, string workPlace, string certificationName)
        {
            CddID=cddID;
            this.objective=objective;
            UniversityName=universityName;
            Major=major;
            Gpa=gpa;
            this.companyName=companyName;
            this.workPlace=workPlace;
            this.certification=certificationName;

        }
        public CV() { }

        public string CddID { get => cddID; set => cddID = value; }
        public int JobID { get => jobID; set => jobID = value; }
        public string Objective { get => objective; set => objective = value; }
        public string Major { get => major; set => major = value; }
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
        public string CompanyName { get => companyName; set => companyName = value; }
        public string WorkPlace { get => workPlace; set => workPlace = value; }
        public string Certification { get => certification; set => certification = value; }
        public DateTime CertificationDate { get => certificationDate; set => certificationDate = value; }
        public string Status { get => status; set => status = value; }

    }
}
