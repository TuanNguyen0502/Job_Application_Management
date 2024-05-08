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

        public string Role { get => role; set => role = value; }
        public int JobID { get => jobID; set => jobID = value; }
        public string CddID { get => cddID; set => cddID = value; }
        public string EmpID { get => empID; set => empID = value; }
        public Guna2Button Button_Approve { get => button_Approve; set => button_Approve = value; }
        public Guna2Button Button_Refuse { get => button_Refuse; set => button_Refuse = value; }
        public Guna2Button Button_Invite { get => button_Invite; set => button_Invite = value; }

        public UC_CV()
        {
            InitializeComponent();
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
        public event EventHandler CreateCV;
        private void btn_CreateCV_Click(object sender, EventArgs e)
        {
            CreateCV?.Invoke(this, new EventArgs());
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
        public event EventHandler RemoveCV;

        private void btn_RemoveCVValid_Click(object sender, EventArgs e)
        {
            RemoveCV?.Invoke(this, new EventArgs());
        }

        private void UC_CV_Load(object sender, EventArgs e)
        {
            if (Role == "Employer")
            {
                if (jobID == 0)
                {
                    LoadCV();
                    CV_ReadOnlyControls();
                }
                else
                {
                    LoadResume();
                    Resume_ReadOnlyControls();
                }
            }
        }

        private void LoadCV()
        {
            /*resume = employerDAO.GetResumeFromDB(jobID, cddID);
            label_CandidateName.Text = resume.CddName;
            label_Nominee.Text = resume.JobName;
            textBox_Phone.Text = resume.CddPhone;
            textBox_Email.Text = resume.CddEmail;
            textBox_Address.Text = resume.CddAddress;
            richTextBox_CareerGoal.Text = resume.Objective;
            textBox_University.Text = resume.UniversityName;
            textBox_Major.Text = resume.Major;
            textBox_GPA.Text = resume.Gpa;
            dateTimePicker_UniversityStartDate.Value = resume.UniversityStartDate;
            dateTimePicker_UniversityEndDate.Value = resume.UniversityEndDate;
            textBox_Company.Text = resume.CompanyName;
            textBox_Workplace.Text = resume.WorkPlace;
            richTextBox_Detail.Text = resume.WorkedDetail;
            dateTimePicker_CompanyStartDate.Value = resume.CompanyStartDate;
            dateTimePicker_CompanyEndDate.Value = resume.CompanyEndDate;
            textBox_Certification.Text = resume.Certification;
            dateTimePicker_Certification.Value = resume.CertificationDate;
            label_Status.Text = resume.Status;*/
        }

        private void LoadResume()
        {
            /*resume = employerDAO.GetResumeFromDB(jobID, cddID);
            label_CandidateName.Text = resume.CddName;
            label_Nominee.Text = resume.JobName;
            textBox_Phone.Text = resume.CddPhone;
            textBox_Email.Text = resume.CddEmail;
            textBox_Address.Text = resume.CddAddress;
            richTextBox_CareerGoal.Text = resume.Objective;
            textBox_University.Text = resume.UniversityName;
            textBox_Major.Text = resume.Major;
            textBox_GPA.Text = resume.Gpa;
            dateTimePicker_UniversityStartDate.Value = resume.UniversityStartDate;
            dateTimePicker_UniversityEndDate.Value = resume.UniversityEndDate;
            textBox_Company.Text = resume.CompanyName;
            textBox_Workplace.Text = resume.WorkPlace;
            richTextBox_Detail.Text = resume.WorkedDetail;
            dateTimePicker_CompanyStartDate.Value = resume.CompanyStartDate;
            dateTimePicker_CompanyEndDate.Value = resume.CompanyEndDate;
            textBox_Certification.Text = resume.Certification;
            dateTimePicker_Certification.Value = resume.CertificationDate;
            label_Status.Text = resume.Status;*/
        }

        public void Resume_ReadOnlyControls()
        {
            textBox_Phone.ReadOnly = true;
            textBox_Email.ReadOnly = true;
            textBox_Address.ReadOnly = true;
            richTextBox_CareerGoal.ReadOnly = true;
            //textBox_University.ReadOnly = true;
            //textBox_Major.ReadOnly = true;
            //textBox_GPA.ReadOnly = true;
            ////uC_Resume_Education1.DateTimePicker_Start.
            ////uC_Resume_Education1.DateTimePicker_End.Value = resume.UniversityEndDate;
            //textBox_Company.ReadOnly = true;
            //textBox_Workplace.ReadOnly = true;
            //richTextBox_Detail.ReadOnly = true;
            ////uC_Resume_Experience1.DateTimePicker_Start.Value = resume.CompanyStartDate;
            ////uC_Resume_Experience1.DateTimePicker_End.Value = resume.CompanyEndDate;
            //textBox_Certification.ReadOnly = true;
            ////uC_Resume_Certificate1.DateTimePicker_Start.Value = resume.TimeCertificate;
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

        public void CV_ReadOnlyControls()
        {
            textBox_Phone.ReadOnly = true;
            textBox_Email.ReadOnly = true;
            textBox_Address.ReadOnly = true;
            richTextBox_CareerGoal.ReadOnly = true;
            //textBox_University.ReadOnly = true;
            //textBox_Major.ReadOnly = true;
            //textBox_GPA.ReadOnly = true;
            ////uC_Resume_Education1.DateTimePicker_Start.
            ////uC_Resume_Education1.DateTimePicker_End.Value = resume.UniversityEndDate;
            //textBox_Company.ReadOnly = true;
            //textBox_Workplace.ReadOnly = true;
            //richTextBox_Detail.ReadOnly = true;
            ////uC_Resume_Experience1.DateTimePicker_Start.Value = resume.CompanyStartDate;
            ////uC_Resume_Experience1.DateTimePicker_End.Value = resume.CompanyEndDate;
            //textBox_Certification.ReadOnly = true;
            ////uC_Resume_Certificate1.DateTimePicker_Start.Value = resume.TimeCertificate;
            btn_CreateCV.Visible = false;
            btn_RemoveCVValid.Visible = false;
            button_Refuse.Visible = false;
            button_Approve.Visible = false;
        }
    }
}
