using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public partial class FCandidate_CreateCV : Form
    {
        CandidateDAO canDAO;
        private string cddID;
        UC_Resume resume = new UC_Resume();
        // Danh sách các CV được tạo ban đầu từ các ứng viên
        public List<Dictionary<string, object>> listCVs = new List<Dictionary<string, object>>();
        public FCandidate_CreateCV(string cddID)
        {
            InitializeComponent();
            this.cddID = cddID;
            canDAO = new CandidateDAO();
            uC_Resume1.Btn_CreateCV.Click += btnCreateCV_Click;
        }
        public FCandidate_CreateCV()
        {
            InitializeComponent();
            canDAO = new CandidateDAO();
        }
        public void btnCreateCV_Click(object sender, EventArgs arg)
        {
            CV cv = resume.GetInfoResumeAtForm();
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict["CddID"] = cddID;
            dict["Objective"] = cv.Objective;
            dict["UniversityName"] = cv.UniversityName;
            dict["Major"] = cv.Major;
            dict["GPA"] = cv.Gpa;
            dict["UniversityStartDate"] = cv.UniversityStartDate;
            dict["UniversityEndDate"] = cv.UniversityEndDate;
            dict["WorkPlace"] = cv.WorkPlace;
            dict["Detail"] = cv.WorkedDetail;
            dict["CompanyStartDate"] = cv.CompanyStartDate;
            dict["CompanyEndDate"] = cv.CompanyEndDate;
            dict["CertificationName"] = cv.Certification;
            dict["CertificationDate"] = cv.CertificationDate;
            MessageBox.Show(cv.Objective);
        }
        public CV GetCVByCandidateID()
        {
            CV cv = new CV();
            foreach(var item in listCVs)
            {
                if (item["CddID"].Equals(cddID))
                {
                    cv.Objective = (string)item["Objective"];
                    cv.UniversityName = (string)item["UniversityName"];
                    cv.Major = (string)item["Major"];
                    cv.Gpa = (string)item["GPA"];
                    cv.UniversityStartDate = (DateTime)item["UniversityStartDate"];
                    cv.UniversityEndDate = (DateTime)item["UniversityEndDate"];
                    cv.WorkPlace = (string)item["WorkPlace"];
                    cv.WorkedDetail = (string)item["Detail"];
                    cv.CompanyName = (string)item["CompanyName"];
                    cv.CompanyStartDate = (DateTime)item["CompanyStartDate"];
                    cv.CompanyEndDate = (DateTime)item["Objective"];
                    cv.Certification = (string)item["CertificationName"];
                    cv.CertificationDate = (DateTime)item["CertificationDate"];
                    return cv;
                }
            }
            return null;
        }
    }
}
