using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public class CV
    {
        private int cvID;
        private string cddID;
        private string nominee;
        private int jobID;
        private string objective;
        private string universityName;
        private string major;
        private string gpa;
        private string universityStartDate;
        private string universityEndDate;
        private string companyName;
        private string workPlace;
        private string workedDetail;
        private string companyStartDate;
        private string companyEndDate;
        private string certification;
        private string certificationDate;
        private string status;
        // Thuộc tính từ bảng khác
        private string jobName;
        private string cddName;
        private string cddAddress;
        private string cddEmail;
        private string cddPhone;
        

        public CV(string cddID, int jobID, string objective, string universityName, string major, string gpa, string universityStartDate, string universityEndDate, string companyName, string workPlace, string workedDetail, string companyStartDate, string companyEndDate, string certificationName, string certificationDate, string jobName, string cddName, string cddAddress, string cddEmail, string cddPhone)
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
        public CV (string cddID, string objective, string universityName, string major, string gpa, string companyName, string workPlace, string certificationName, string cddName)
        {
            CddID=cddID;
            this.objective=objective;
            UniversityName=universityName;
            Major=major;
            Gpa=gpa;
            this.companyName=companyName;
            this.workPlace=workPlace;
            this.certification=certificationName;
            this.cddName=cddName;
        }
        public CV() { }

        public string CddID 
        { 
            get => cddID; 
            set
            {
                if (value == null || value == "")
                {
                    MessageBox.Show("CddID chưa được chỉ định");
                }
                else
                {
                    cddID = value;
                }
            }
        }
        public int JobID 
        { 
            get => jobID; set
            {
                if (value < 0)
                    MessageBox.Show("JobID chưa được chỉ định");
                else 
                { 
                    jobID = value; 
                }
            }
        }
        public string Objective 
        { 
            get => objective; set
            {
                if (value == null || value == "")
                {
                    MessageBox.Show("Mục tiêu nghề nghiệp chưa được chỉ định");
                }
                else
                {
                    objective = value;
                }
            }
        }
        public string Major 
        { 
            get => major;
            set
            {
                if (value == null || value == "")
                {
                    MessageBox.Show("Nghề nghiệp chưa được chỉ định");
                }
                else
                {
                    major = value;
                }
            }
        }
        public string UniversityName 
        { 
            get => universityName; set
            {
                if (value == null || value == "")
                    MessageBox.Show("Tên trường đại học/cao đẳng chưa được chỉ định");
                else
                    universityName = value;
            }
        }
        public string Gpa 
        { 
            get => gpa; 
            set
            {
                if (value == null || value == "")
                    MessageBox.Show("Gpa chưa được chỉ định");
                else
                    gpa = value;
            }
        }
        public string UniversityStartDate 
        { 
            get => universityStartDate; set
            {
                if (value == null || value == "")
                    MessageBox.Show("Ngày bắt đầu nhập học chưa được chỉ định");
                else
                    universityStartDate = value;
            } 
        }
        public string UniversityEndDate 
        { 
            get => universityEndDate; set
            {
                if (value == null || value == "")
                    MessageBox.Show("Ngày tốt nghiệp chưa được chỉ định");
                else
                    universityEndDate = value;
            }
        }
        public string WorkedDetail 
        { 
            get => workedDetail;
            set
            {
                if (value == null || value == "")
                    MessageBox.Show("Chi tiết công việc chưa được chỉ định");
                else
                    workedDetail = value;
            }
        }
        public string CompanyStartDate 
        { 
            get => companyStartDate;
            set
            {
                if (value == null || value == "")
                    MessageBox.Show("Ngày vào công ty chưa được chỉ định");
                else
                    companyStartDate = value;
            }
        }
        public string CompanyEndDate 
        { 
            get => companyEndDate;
            set
            {
                if (value == null || value == "")
                    MessageBox.Show("Ngày nghỉ công ty chưa được chỉ định");
                else
                    companyEndDate = value;
            }
        }
        public string CddPhone 
        { 
            get => cddPhone;
            set
            {
                if (value == null || value == "")
                    MessageBox.Show("Gpa chưa được chỉ định");
                else
                    cddPhone = value;
            }
        }
        public string CddEmail 
        { 
            get => cddEmail;
            set
            {
                if (value == null || value == "")
                    MessageBox.Show("Email ứng viên chưa được chỉ định");
                else
                    cddEmail = value;
            }
        }
        public string CddAddress 
        { 
            get => cddAddress;
            set
            {
                if (value == null || value == "")
                    MessageBox.Show("Địa chỉ của ứng viên chưa được chỉ định");
                else
                    cddAddress = value;
            }
        }
        public string CddName 
        { 
            get => cddName;
            set
            {
                if (value == null || value == "")
                    MessageBox.Show("Tên ứng viên chưa được chỉ định");
                else
                    cddName = value;
            }
        }
        public string JobName 
        { 
            get => jobName;
            set
            {
                if (value == null || value == "")
                    MessageBox.Show("Tên công việc chưa được chỉ định");
                else
                    jobName = value;
            }
        }
        public string CompanyName 
        { 
            get => companyName;
            set
            {
                if (value == null || value == "")
                    MessageBox.Show("Tên công ty chưa được chỉ định");
                else
                    companyName = value;
            }
        }
        public string WorkPlace 
        { 
            get => workPlace;
            set
            {
                if (value == null || value == "")
                    MessageBox.Show("Vị trí làm việc chưa được chỉ định");
                else
                    workPlace = value;
            }
        }
        public string Certification 
        { 
            get => certification;
            set
            {
                if (value == null || value == "")
                    MessageBox.Show("Chững chỉ chưa được chỉ định");
                else
                    certification = value;
            }
        }
        public string CertificationDate 
        { 
            get => certificationDate;
            set
            {
                if (value == null || value == "")
                    MessageBox.Show("Ngày/tháng/năm được cấp chứng chỉ chưa được chỉ định");
                else
                    certificationDate = value;
            }
        }
        public string Status 
        { 
            get => status;
            set
            {
                if (value == null || value == "")
                    MessageBox.Show("Trạng thái CV chưa được chỉ định");
                else
                    status = value;
            }
        }
        public string Nominee
        {
            get => nominee;
            set
            {
                if (value == null || value == "")
                    MessageBox.Show("Công việc ứng tuyển chưa chỉ định");
                else
                    nominee = value;
            }
        }

        public int CvID { get => cvID; set => cvID = value; }
    }
}
