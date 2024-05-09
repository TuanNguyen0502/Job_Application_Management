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

namespace Job_Application_Management
{
    public partial class UC_CV : UserControl
    {
        private string role;
        private int jobID;
        private string cddID;
        private string empID;
        private CV resume;
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
        public Label Label_Nominee { get { return label_Nominee; } }
        public Label Label_Status { get => label_Status; set => label_Status = value; }
        public Guna2Button Btn_RemoveCVValid { get { return btn_RemoveCVValid; } }
        public Guna2Button Btn_CreateCV { get { return btn_CreateCV; } }
        public Guna2Button Button_Approve { get => button_Approve; set => button_Approve = value; }
        public Guna2Button Button_Refuse { get => button_Refuse; set => button_Refuse = value; }
        public FlowLayoutPanel Flp_Educations { get { return flp_Educations; } }
        public FlowLayoutPanel Flp_Experiences { get { return flp_Experiences; } }
        public FlowLayoutPanel Flp_Certifications { get { return flp_Certifications; } }
        #region Get Value in Educations
        private string GetUniversityNames()
        {
            string UniversityNames = "";
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Education uc)
                {
                    UniversityNames = uc.TextBox_University.Text + "/";
                }
            }
            return UniversityNames.Substring(0, UniversityNames.Length - 1);
        }
        private string GetMajors()
        {
            string Majors = "";
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Education uc)
                {
                    Majors = uc.TextBox_Major.Text + "/";
                }
            }
            return Majors.Substring(0, Majors.Length - 1);
        }
        private string GetGPAs()
        {
            string Gpas = "";
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Education uc)
                {
                    Gpas = uc.TextBox_GPA.Text + "/";
                }
            }
            return Gpas.Substring(0, Gpas.Length - 1);
        }
        private string GetUniversityStartDate()
        {
            string StartDate = "";
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Education uc)
                {
                    StartDate = uc.DateTimePicker_UniversityStartDate.Value.ToShortDateString() + "/";
                }
            }
            return StartDate.Substring(0, StartDate.Length - 1);
        }
        private string GetUniversityEndDate()
        {
            string EndDate = "";
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Education uc)
                {
                    EndDate = uc.DateTimePicker_UniversityEndDate.Value.ToShortDateString() + "/";
                }
            }
            return EndDate.Substring(0, EndDate.Length - 1);
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
                    CompanyName = uc.CompanyName + "/";
                }
            }
            return CompanyName.Substring(0, CompanyName.Length - 1);
        }
        private string GetWorkPlace()
        {
            string CompanyName = "";
            foreach (Control control in flp_Experiences.Controls)
            {
                if (control is UC_Experiences uc)
                {
                    CompanyName = uc.TextBox_Workplace + "/";
                }
            }
            return CompanyName.Substring(0, CompanyName.Length - 1);
        }
        private string GetDetail()
        {
            string CompanyName = "";
            foreach (Control control in flp_Experiences.Controls)
            {
                if (control is UC_Experiences uc)
                {
                    CompanyName = uc.RichTextBox_Detail + "/";
                }
            }
            return CompanyName.Substring(0, CompanyName.Length - 1);
        }
        private string GetCompanyStartDate()
        {
            string StartDate = "";
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Experiences uc)
                {
                    StartDate = uc.DateTimePicker_CompanyStartDate.Value.ToShortDateString() + "/";
                }
            }
            return StartDate.Substring(0, StartDate.Length - 1);
        }
        private string GetCompanyEndDate()
        {
            string EndDate = "";
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Experiences uc)
                {
                    EndDate = uc.DateTimePicker_CompanyEndDate.Value.ToShortDateString() + "/";
                }
            }
            return EndDate.Substring(0, EndDate.Length - 1);
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
                    Certification = uc.TextBox_Certification.Text;
                }
            }
            return Certification.Substring(0, Certification.Length - 1);
        }
        private string GetCertificationDate()
        {
            string Certification = "";
            foreach (Control control in flp_Certifications.Controls)
            {
                if (control is UC_Certification uc)
                {
                    Certification = uc.DateTimePicker_Certification.Value.ToShortTimeString();
                }
            }
            return Certification.Substring(0, Certification.Length - 1);
        }
        #endregion

        public CV GetInfoResumeAtForm()
        {
            CV myCV = new CV();

            myCV.CddName = label_CandidateName.Text;
            myCV.Nominee = label_Nominee.Text;
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
            MessageBox.Show("Get info resume successful. " + myCV.Objective);
            return myCV;
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
        }

        #region Set value for Education
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
            string[] words = UniStartDate.Split('/');
            int i = 0;
            foreach (Control control in flp_Educations.Controls)
            {
                if (control is UC_Education uc)
                {
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
        private void SetCompanyName(string CompanyName)
        {
            string[] words = CompanyName.Split('/');
            int i = 0;
            foreach (Control control in flp_Educations.Controls)
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
            foreach (Control control in flp_Educations.Controls)
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
            foreach (Control control in flp_Educations.Controls)
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
            foreach (Control control in flp_Educations.Controls)
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
            foreach (Control control in flp_Educations.Controls)
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
        private void SetCertificationName(string Certification)
        {
            string[] words = Certification.Split('/');
            int i = 0;
            foreach (Control control in flp_Educations.Controls)
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
            foreach (Control control in flp_Educations.Controls)
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
            label_Nominee.Text = resume.JobName;
            textBox_Phone.Text = resume.CddPhone;
            textBox_Email.Text = resume.CddEmail;
            textBox_Address.Text = resume.CddAddress;
            richTextBox_CareerGoal.Text = resume.Objective;
            SetUniversityName(resume.UniversityName);
            SetMajor(resume.Major);
            SetGpa(resume.Gpa);
            SetUniversityStartDate(resume.UniversityStartDate);
            SetUniversityEndDate(resume.UniversityEndDate);
            SetCompanyName(resume.CompanyName);
            SetWorkPlace(resume.WorkPlace);
            SetDetail(resume.WorkedDetail);
            SetCompanyStartDate(resume.CompanyStartDate);
            SetCompanyEndDate(resume.CompanyEndDate);
            SetCertificationName(resume.Certification);
            SetCertificationDate(resume.CertificationDate);
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
            if (resume.Status == "Applying")
            {
                button_Refuse.Visible = false;
            }
            if (resume.Status == "Approved")
            {
                button_Approve.Visible = false;
            }
        }

        private void CV_LoadData()
        {
            /*resume = employerDAO.GetResumeFromDB(jobID, cddID);
            label_CandidateName.Text = resume.CddName;
            label_Nominee.Text = resume.JobName;
            textBox_Phone.Text = resume.CddPhone;
            textBox_Email.Text = resume.CddEmail;
            textBox_Address.Text = resume.CddAddress;
            richTextBox_CareerGoal.Text = resume.Objective;
            SetUniversityName(resume.UniversityName);
            SetMajor(resume.Major);
            SetGpa(resume.Gpa);
            SetUniversityStartDate(resume.UniversityStartDate);
            SetUniversityEndDate(resume.UniversityEndDate);
            SetCompanyName(resume.CompanyName);
            SetWorkPlace(resume.WorkPlace);
            SetDetail(resume.WorkedDetail);
            SetCompanyStartDate(resume.CompanyStartDate);
            SetCompanyEndDate(resume.CompanyEndDate);
            SetCertificationName(resume.Certification);
            SetCertificationDate(resume.CertificationDate);
            label_Status.Text = resume.Status;*/
        }

        public void CV_ReadOnlyControls()
        {
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
            CreateCV?.Invoke(this, new ButtonClickEventArgs(CddID, JobID));
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
    }
}
