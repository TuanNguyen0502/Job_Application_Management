using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Security.Cryptography;
using System.Runtime.InteropServices.ComTypes;

namespace Job_Application_Management
{
    public partial class UC_CV : UserControl
    {
        private string role;
        private int jobID;
        private string cddID;
        private string empID;
        private CV resume;
        private int cvID;
        private EmployerDAO employerDAO = new EmployerDAO();
        private CandidateDAO candidateDAO = new CandidateDAO();

        public UC_CV()
        {
            InitializeComponent();
        }

        public string Role { get => role; set => role = value; }
        public int JobID { get => jobID; set => jobID = value; }
        public string CddID { get => cddID; set => cddID = value; }
        public string EmpID { get => empID; set => empID = value; }
        public CV Resume { get => resume; set => resume = value; }
        public Label Label_CandidateName { get { return label_CandidateName; } }
        public Guna2TextBox Label_Nominee { get { return textBox_Nominee; } }
        public Label Label_Status { get => label_Status; set => label_Status = value; }
        public Guna2Button Btn_RemoveCVValid { get { return btn_RemoveCVValid; } }
        public Guna2Button Btn_CreateCV { get { return btn_CreateCV; } }
        public Guna2Button Button_Invite { get { return button_Invite; } }
        public Guna2Button Button_Approve { get => button_Approve; set => button_Approve = value; }
        public Guna2Button Button_Refuse { get => button_Refuse; set => button_Refuse = value; }
        public FlowLayoutPanel Flp_Educations { get { return flp_Educations; } }
        public FlowLayoutPanel Flp_Experiences { get { return flp_Experiences; } }
        public FlowLayoutPanel Flp_Certifications { get { return flp_Certifications; } }
        public int CvID { get => cvID; set => cvID = value; }

        #region Get Value in Educations
        private string GetUniversityNames()
        {
            string UniversityNames = "";
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Education uc)
                {
                    UniversityNames += uc.TextBox_University.Text + "/";
                }
            }
            if (UniversityNames.Length > 0) { return UniversityNames.Substring(0, UniversityNames.Length - 1); }
            return null;
        }
        private string GetMajors()
        {
            string Majors = "";
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Education uc)
                {
                    Majors += uc.TextBox_Major.Text + "/";
                }
            }
            if (Majors.Length > 0) { return Majors.Substring(0, Majors.Length - 1); }
            return null;
        }
        private string GetGPAs()
        {
            string Gpas = "";
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Education uc)
                {
                    Gpas += uc.TextBox_GPA.Text + "/";
                }
            }
            if (Gpas.Length > 0) { return Gpas.Substring(0, Gpas.Length - 1); }
            return null;
        }
        private string GetUniversityStartDate()
        {
            string StartDate = "";
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Education uc)
                {
                    StartDate += uc.DateTimePicker_UniversityStartDate.Value.Year + "-" +
                        uc.DateTimePicker_UniversityStartDate.Value.Month + "-" +
                        uc.DateTimePicker_UniversityStartDate.Value.Day + "/";
                }
            }
            if (StartDate.Length > 0) { return StartDate.Substring(0, StartDate.Length - 1); }
            return null;
        }
        private string GetUniversityEndDate()
        {
            string EndDate = "";
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Education uc)
                {
                    EndDate += uc.DateTimePicker_UniversityEndDate.Value.Year + "-" +
                        uc.DateTimePicker_UniversityEndDate.Value.Month + "-" +
                        uc.DateTimePicker_UniversityEndDate.Value.Day + "/";
                }
            }
            if (EndDate.Length > 0) { return EndDate.Substring(0, EndDate.Length - 1); }
            return null;
        }
        #endregion

        #region Get Value in Experiences

        private string GetCompanyName()
        {
            string CompanyName = "";
            foreach (Control control in flp_Experiences.Controls)
            {
                if (control is UC_Experiences uc)
                {
                    CompanyName += uc.TextBox_Company.Text + "/";
                }
            }
            if (CompanyName.Length > 0) { return CompanyName.Substring(0, CompanyName.Length - 1); }
            return null;
        }
        private string GetWorkPlace()
        {
            string CompanyName = "";
            foreach (Control control in flp_Experiences.Controls)
            {
                if (control is UC_Experiences uc)
                {
                    CompanyName += uc.TextBox_Workplace.Text + "/";
                }
            }
            if (CompanyName.Length > 0) { return CompanyName.Substring(0, CompanyName.Length - 1); }
            return null;
        }
        private string GetDetail()
        {
            string CompanyName = "";
            foreach (Control control in flp_Experiences.Controls)
            {
                if (control is UC_Experiences uc)
                {
                    CompanyName += uc.RichTextBox_Detail + "/";
                }
            }
            if (CompanyName.Length > 0) { return CompanyName.Substring(0, CompanyName.Length - 1); }
            return null;
        }
        private string GetCompanyStartDate()
        {
            string StartDate = "";
            foreach (Control control in flp_Experiences.Controls)
            {
                if (control is UC_Experiences uc)
                {
                    StartDate += uc.DateTimePicker_CompanyStartDate.Value.Year + "-" +
                        uc.DateTimePicker_CompanyStartDate.Value.Month + "-" +
                        uc.DateTimePicker_CompanyStartDate.Value.Day + "/";
                }
            }
            if (StartDate.Length > 0) { return StartDate; }
            return null;
        }
        private string GetCompanyEndDate()
        {
            string EndDate = "";
            foreach (Control control in flp_Experiences.Controls)
            {
                if (control is UC_Experiences uc)
                {
                    EndDate += uc.DateTimePicker_CompanyEndDate.Value.Year + "-" +
                                uc.DateTimePicker_CompanyEndDate.Value.Month + "-" +
                                uc.DateTimePicker_CompanyEndDate.Value.Day + "/";
                }
            }
            if (EndDate.Length > 0) { return EndDate.Substring(0, EndDate.Length - 1); }
            return null;
        }

        #endregion

        #region Get Value in Certifications
        private string GetCertificationName()
        {
            string Certification = "";
            foreach (Control control in flp_Certifications.Controls)
            {
                if (control is UC_Certification uc)
                {
                    Certification += uc.TextBox_Certification.Text + "/";
                }
            }
            if (Certification.Length > 0) { return Certification.Substring(0, Certification.Length - 1); }
            return null;
        }
        private string GetCertificationDate()
        {
            string Certification = "";
            foreach (Control control in flp_Certifications.Controls)
            {
                if (control is UC_Certification uc)
                {
                    Certification += uc.DateTimePicker_Certification.Value.Year + "-" +
                        uc.DateTimePicker_Certification.Value.Month + "-" +
                        uc.DateTimePicker_Certification.Value.Day + "/";
                }
            }
            if (Certification.Length > 0) { return Certification.Substring(0, Certification.Length - 1); }
            return null;
        }
        #endregion

        public CV GetInfoResumeAtForm()
        {
            CV myCV = new CV();

            myCV.CddName = label_CandidateName.Text;
            myCV.Nominee = textBox_Nominee.Text;
            myCV.CddPhone = textBox_Phone.Text;
            myCV.CddAddress = textBox_Address.Text;
            myCV.CddEmail = textBox_Email.Text;
            myCV.Objective = richTextBox_CareerGoal.Text;
            myCV.Major = GetMajors();
            myCV.Gpa = GetGPAs();
            myCV.UniversityName = GetUniversityNames();
            myCV.UniversityStartDate = GetUniversityStartDate();
            myCV.UniversityEndDate = GetUniversityStartDate();
            myCV.WorkedDetail = GetDetail();
            myCV.CompanyName = GetCompanyName();
            myCV.CompanyStartDate = GetCompanyStartDate();
            myCV.CompanyEndDate = GetCompanyEndDate();
            myCV.WorkPlace = GetWorkPlace();
            myCV.Certification = GetCertificationName();
            myCV.CertificationDate = GetCertificationDate();
            myCV.Status = label_Status.Text;
            return myCV;
        }
        public void LoadCandidateInfo()
        {
            Candidate can = candidateDAO.GetCandidateInfor(CddID);
            label_CandidateName.Text = can.Name;
            textBox_Address.Text = can.Address;
            textBox_Phone.Text = can.Phone;
            textBox_Email.Text = can.Email;
            richTextBox_CareerGoal.Text = "02 năm kinh nghiệm đào tạo kỹ năng bán hàng và kỹ năng mềm tại trường đại học và doanh nghiệp. Kinh nghiệm đứng lớp 50 - 500 học viên. Có thế mạnh về thiết kế chương trình, đào tạo trực tuyến và xây dựng chuẩn đầu ra. Đang tìm kiếm cơ hội làm việc tại vị trí [X] để đóng góp gia tăng chất lượng chương trình đào tạo cho công ty [Y]";
        }
        private void UC_CV_Load(object sender, EventArgs e)
        {
            if (Role == "Employer")
            {
                if (jobID == 0)
                {
                    CV_LoadData();
                    CV_ReadOnlyControls();
                }
                else
                {
                    Resume_LoadData();
                    Resume_ReadOnlyControls();
                }
            }
            else
            {
                CV_LoadData();
                LoadCandidateInfo();
            }
        }

        #region Set value for Education
        private void SetUniversity(string universityName, string major, string gpa, string universityStartDate, string universityEndDate)
        {

            if (universityName != null && major != null && gpa != null && universityStartDate != null && universityEndDate != null)
            {
                string[] words = universityName.Split('/');
                if (words.Length > 1)
                {
                    for (int i = 0; i < words.Length - 1; i++)
                    {
                        flp_Educations.Controls.Add(new UC_Education());
                    }
                }
                SetUniversityName(universityName);
                SetMajor(major);
                SetGpa(gpa);
                SetUniversityStartDate(universityStartDate);
                SetUniversityEndDate(universityEndDate);
            }
        }
        private void SetUniversityName(string UniversityName)
        {
            string[] words = UniversityName.Split('/');
            int i = 0;
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Education uc)
                {
                    uc.TextBox_University.Text = words[i];
                    i++;
                }
            }
        }

        private void SetMajor(string Major)
        {
            string[] words = Major.Split('/');
            int i = 0;
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Education uc)
                {
                    uc.TextBox_Major.Text = words[i];
                    i++;
                }
            }
        }

        private void SetGpa(string Gpa)
        {
            string[] words = Gpa.Split('/');
            int i = 0;
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Education uc)
                {
                    uc.TextBox_GPA.Text = words[i];
                    i++;
                }
            }
        }

        private void SetUniversityStartDate(string UniStartDate)
        {
            MessageBox.Show(UniStartDate);
            string[] words = UniStartDate.Split('/');
            int i = 0;
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Education uc)
                {
                    MessageBox.Show(words[i]);
                    uc.DateTimePicker_UniversityStartDate.Value = Convert.ToDateTime(words[i]);
                    i++;
                }
            }
        }
        private void SetUniversityEndDate(string EndDate)
        {
            string[] words = EndDate.Split('/');
            int i = 0;
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Education uc)
                {
                    uc.DateTimePicker_UniversityEndDate.Value = Convert.ToDateTime(words[i]);
                    i++;
                }
            }
        }

        #endregion
        #region Set value for Experiences
        private void SetCompany(string companyName, string workplace, string detail, string companyStartDate, string companyEndDate)
        {
            if (companyName != null && workplace != null && detail != null && companyStartDate != null && companyEndDate != null)
            {
                string[] words = companyName.Split('/');
                if (words.Length > 1)
                {
                    for (int i = 0; i < words.Length - 1; i++)
                    {
                        flp_Experiences.Controls.Add(new UC_Experiences());
                    }
                }
                SetCompanyName(companyName);
                SetWorkPlace(workplace);
                SetDetail(detail);
                SetCompanyStartDate(companyStartDate);
                SetCompanyEndDate(companyEndDate);
            }    
        }
        private void SetCompanyName(string companyName)
        {
            string[] words = companyName.Split('/');
            int i = 0;
            foreach (Control control in flp_Experiences.Controls)
            {
                if (control is UC_Experiences uc)
                {
                    uc.TextBox_Company.Text = words[i];
                    i++;
                }
            }
        }
        private void SetWorkPlace(string WorkPlace)
        {
            string[] words = WorkPlace.Split('/');
            int i = 0;
            foreach (Control control in flp_Experiences.Controls)
            {
                if (control is UC_Experiences uc)
                {
                    uc.TextBox_Workplace.Text = words[i];
                    i++;
                }
            }
        }
        private void SetDetail(string Detail)
        {
            string[] words = Detail.Split('/');
            int i = 0;
            foreach (Control control in flp_Experiences.Controls)
            {
                if (control is UC_Experiences uc)
                {
                    uc.RichTextBox_Detail.Text = words[i];
                    i++;
                }
            }
        }
        private void SetCompanyStartDate(string CompanyStartDate)
        {
            string[] words = CompanyStartDate.Split('/');
            int i = 0;
            foreach (Control control in flp_Experiences.Controls)
            {
                if (control is UC_Experiences uc)
                {
                    uc.DateTimePicker_CompanyStartDate.Value = Convert.ToDateTime(words[i]);
                    i++;
                }
            }
        }
        private void SetCompanyEndDate(string CompanyEndDate)
        {
            string[] words = CompanyEndDate.Split('/');
            int i = 0;
            foreach (Control control in flp_Experiences.Controls)
            {
                if (control is UC_Experiences uc)
                {
                    uc.DateTimePicker_CompanyEndDate.Value = Convert.ToDateTime(words[i]);
                    i++;
                }
            }
        }
        #endregion
        #region Set value for Certifications
        private void SetCertification(string certification, string certificationDate)
        {
            if (certification != null && certificationDate != null)
            {
                string[] words = certification.Split('/');
                if (words.Length > 1)
                {
                    for (int j = 0; j < words.Length - 1; j++)
                    {
                        flp_Certifications.Controls.Add(new UC_Certification());
                    }
                }
                SetCertificationName(certification);
                SetCertificationDate(certificationDate);
            }    
        }
        private void SetCertificationName(string Certification)
        {
            string[] words = Certification.Split('/');
            int i = 0;
            foreach (Control control in flp_Certifications.Controls)
            {
                if (control is UC_Certification uc)
                {
                    uc.TextBox_Certification.Text = words[i];
                    i++;
                }
            }
        }
        private void SetCertificationDate(string Certification)
        {
            string[] words = Certification.Split('/');
            int i = 0;
            foreach (Control control in flp_Certifications.Controls)
            {
                if (control is UC_Certification uc)
                {
                    uc.DateTimePicker_Certification.Value = Convert.ToDateTime(words[i]);
                    i++;
                }
            }
        }
        #endregion
        
        private void Resume_LoadData()
        {
            resume = employerDAO.GetResumeFromDB(jobID, cddID);
            label_CandidateName.Text = resume.CddName;
            textBox_Nominee.Text = resume.JobName;
            textBox_Phone.Text = resume.CddPhone;
            textBox_Email.Text = resume.CddEmail;
            textBox_Address.Text = resume.CddAddress;
            richTextBox_CareerGoal.Text = resume.Objective;
            SetUniversity(resume.UniversityName, resume.Major, resume.Gpa, resume.UniversityStartDate, resume.UniversityEndDate);
            SetCompany(resume.CompanyName, resume.WorkPlace, resume.WorkedDetail, resume.CompanyStartDate, resume.CompanyEndDate);
            SetCertification(resume.Certification, resume.CertificationDate);
            label_Status.Text = resume.Status;
        }

        public void Resume_ReadOnlyControls()
        {
            textBox_Phone.ReadOnly = true;
            textBox_Email.ReadOnly = true;
            textBox_Address.ReadOnly = true;
            richTextBox_CareerGoal.ReadOnly = true;
            foreach (UC_Education uc in this.flp_Educations.Controls)
            {
                uc.TextBox_University.ReadOnly = true;
                uc.TextBox_Major.ReadOnly = true;
                uc.TextBox_GPA.ReadOnly = true;
                uc.DateTimePicker_UniversityStartDate.Enabled = false;
                uc.DateTimePicker_UniversityEndDate.Enabled = false;
            }
            foreach (UC_Experiences uc in this.flp_Experiences.Controls)
            {
                uc.TextBox_Company.ReadOnly = true;
                uc.TextBox_Workplace.ReadOnly = true;
                uc.RichTextBox_Detail.ReadOnly = true;
                uc.DateTimePicker_CompanyStartDate.Enabled = false;
                uc.DateTimePicker_CompanyEndDate.Enabled = false;
            }
            foreach (UC_Certification uc in this.flp_Certifications.Controls)
            {
                uc.TextBox_Certification.ReadOnly = true;
                uc.DateTimePicker_Certification.Enabled = false;
            }
            btn_CreateCV.Visible = false;
            btn_RemoveCVValid.Visible = false;
            button_Invite.Visible = false;
            btnAdd_Education.Visible = false;
            btnAdd_Experiences.Visible = false;
            btnAdd_Certification.Visible = false;
            if (resume.Status == "Applying")
            {
                button_Refuse.Visible = false;
            }
            if (resume.Status == "Approved")
            {
                button_Approve.Visible = false;
            }
        }
        public void CV_LoadData()
        {
            CV cv = employerDAO.GetCVFromDB(cvID);
            label_CandidateName.Text = cv.CddName;
            textBox_Nominee.Text = cv.Nominee;
            textBox_Phone.Text = cv.CddPhone;
            textBox_Email.Text = cv.CddEmail;
            textBox_Address.Text = cv.CddAddress;
            richTextBox_CareerGoal.Text = cv.Objective;
            SetUniversity(cv.UniversityName, cv.Major, cv.Gpa, cv.UniversityStartDate, cv.UniversityEndDate);
            SetCompany(cv.CompanyName, cv.WorkPlace, cv.WorkedDetail, cv.CompanyStartDate, cv.CompanyEndDate);
            SetCertification(cv.Certification, cv.CertificationDate);
            label_Status.Text = "Applying";
        }

        public void CV_ReadOnlyControls()
        {
            textBox_Nominee.ReadOnly = true;
            dateTimePicker_Dob.Enabled = false;
            textBox_Phone.ReadOnly = true;
            textBox_Email.ReadOnly = true;
            textBox_Address.ReadOnly = true;
            richTextBox_CareerGoal.ReadOnly = true;
            foreach (UC_Education uc in this.flp_Educations.Controls)
            {
                uc.TextBox_University.ReadOnly = true;
                uc.TextBox_Major.ReadOnly = true;
                uc.TextBox_GPA.ReadOnly = true;
                uc.DateTimePicker_UniversityStartDate.Enabled = false;
                uc.DateTimePicker_UniversityEndDate.Enabled = false;
            }
            foreach (UC_Experiences uc in this.flp_Experiences.Controls)
            {
                uc.TextBox_Company.ReadOnly = true;
                uc.TextBox_Workplace.ReadOnly = true;
                uc.RichTextBox_Detail.ReadOnly = true;
                uc.DateTimePicker_CompanyStartDate.Enabled = false;
                uc.DateTimePicker_CompanyEndDate.Enabled = false;
            }
            foreach (UC_Certification uc in this.flp_Certifications.Controls)
            {
                uc.TextBox_Certification.ReadOnly = true;
                uc.DateTimePicker_Certification.Enabled = false;
            }
            btn_CreateCV.Visible = false;
            btn_RemoveCVValid.Visible = false;
            button_Refuse.Visible = false;
            button_Approve.Visible = false;
            btnAdd_Education.Visible = false;
            btnAdd_Experiences.Visible = false;
            btnAdd_Certification.Visible = false;
        }

        public event EventHandler AddEdu;
        private void btnAdd_Education_Click(object sender, EventArgs e)
        {
            AddEdu?.Invoke(this, new EventArgs());
        }
        public event EventHandler AddEx;
        private void btnAdd_Experiences_Click(object sender, EventArgs e)
        {
            AddEx?.Invoke(this, new EventArgs());
        }
        public event EventHandler AddCer;
        private void btnAdd_Certification_Click(object sender, EventArgs e)
        {
            AddCer?.Invoke(this, new EventArgs());
        }
        public event EventHandler<ButtonClickEventArgs> CreateCV;
        private void btn_CreateCV_Click(object sender, EventArgs e)
        {
            CV cv = GetInfoResumeAtForm();
            CreateCV?.Invoke(this, new ButtonClickEventArgs(cv));
        }
        public event EventHandler ApproveCV;

        private void button_Approve_Click(object sender, EventArgs e)
        {
            ApproveCV?.Invoke(this, new EventArgs());
        }
        public event EventHandler RefuseCV;

        private void button_Refuse_Click(object sender, EventArgs e)
        {
            RefuseCV?.Invoke(this, new EventArgs());
        }
        public event EventHandler<ButtonClickEventArgs> RemoveCV;

        private void btn_RemoveCVValid_Click(object sender, EventArgs e)
        {
            RemoveCV?.Invoke(this, new ButtonClickEventArgs(CddID,JobID));
        }

        public event EventHandler<ButtonInviteCandidate> InviteCandidate;
        private void button_Invite_Click(object sender, EventArgs e)
        {
            InviteCandidate?.Invoke(this, new ButtonInviteCandidate(empID, cddID, textBox_Nominee.Text));
        }
    }
}
