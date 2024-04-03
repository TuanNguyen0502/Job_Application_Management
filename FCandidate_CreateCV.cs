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
        }
        public FCandidate_CreateCV()
        {
            InitializeComponent();
            canDAO = new CandidateDAO();
        }
        public void SaveCVToListCV()
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
            MessageBox.Show(cv.CddID);
            /*foreach (var item in dict)
            {
                MessageBox.Show(item.Value.ToString());
            }*/
            listCVs.Add(dict);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
        }

        private void uc_AtFormCreateCV_Load(object sender, EventArgs e)
        {
            SaveCVToListCV();
        }
    }
}
