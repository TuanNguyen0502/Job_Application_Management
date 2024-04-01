using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Job_Application_Management
{
    public partial class UC_Resume : UserControl
    {
        private string jobID;
        private string cddID;
        private CV resume;
        private EmployerDAO employerDAO;
        private CandidateDAO candidateDAO;
        public UC_Resume()
        {
            employerDAO = new EmployerDAO();
            InitializeComponent();
        }

        private void button_AddEducation_Click(object sender, EventArgs e)
        {
            int ucHeight = 300;
            int ucWidth = 1288;
            // increase flow layout panel height
            flowLayoutPanel_Education.Size = new System.Drawing.Size(ucWidth, flowLayoutPanel_Education.Height + ucHeight);
            // add uc
            UC_Resume_Education uC_Resume_Education = new UC_Resume_Education();
            flowLayoutPanel_Education.Controls.Add(uC_Resume_Education);
        }

        private void button_AddExperience_Click(object sender, EventArgs e)
        {
            int ucHeight = 381;
            int ucWidth = 1674;
            // increase flow layout panel height
            flowLayoutPanel_Experience.Size = new System.Drawing.Size(ucWidth, flowLayoutPanel_Experience.Height + ucHeight);
            // add uc
            UC_Resume_Experience uC_Resume_Experience = new UC_Resume_Experience();
            flowLayoutPanel_Experience.Controls.Add(uC_Resume_Experience);
        }

        private void button_AddCertification_Click(object sender, EventArgs e)
        {
            int ucHeight = 197;
            int ucWidth = 1674;
            // increase flow layout panel height
            flowLayoutPanel_Certificate.Size = new System.Drawing.Size(ucWidth, flowLayoutPanel_Certificate.Height + ucHeight);
            // add uc
            UC_Resume_Certificate uC_Resume_Certificate = new UC_Resume_Certificate();
            flowLayoutPanel_Certificate.Controls.Add(uC_Resume_Certificate);
        }
        
        public CV GetInfoResumeAtForm()
        {
            CV myCV = new CV();

            myCV.CddName = label_CandidateName.Text;
            myCV.WorkPlace = label_Nominee.Text;
            myCV.CddPhone = textBox_Phone.Text;
            myCV.CddAddress = textBox_Address.Text;
            myCV.CddEmail = textBox_Email.Text;
            myCV.Objective = richTextBox_CareerObjective.Text;
            myCV.Major = uC_Resume_Education1.TextBox_Major.Text;
            myCV.UniversityName = uC_Resume_Education1.TextBox_School.Text;
            myCV.WorkedDetail = uC_Resume_Education1.RichTextBox_EducationDetail.Text;
            myCV.JobID = uC_Resume_Experience1.TextBox_JobID.Text;
            myCV.CompanyName = uC_Resume_Experience1.TextBox_Compay.Text;
            myCV.WorkPlace = uC_Resume_Experience1.TextBox_Place.Text;
            myCV.Certification = uC_Resume_Certificate1.TextBox_CertificateName.Text;
            myCV.TimeCertificate = uC_Resume_Certificate1.DateTimePicker_Start.Value;

            return myCV;
        }

        public string JobID { get => jobID; set => jobID = value; }
        public string CddID { get => cddID; set => cddID = value; }

        private void UC_Resume_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {
            resume = employerDAO.GetResumeFromDB(jobID, cddID);

            label_CandidateName.Text = resume.CddName;
            label_Nominee.Text = resume.JobName;
            textBox_Phone.Text = resume.CddPhone;
            textBox_Email.Text = resume.CddEmail;
            textBox_Address.Text = resume.CddAddress;
            richTextBox_CareerObjective.Text = resume.Objective;
            uC_Resume_Education1.TextBox_School.Text = resume.UniversityName;
            uC_Resume_Education1.TextBox_Major.Text = resume.Major;
            uC_Resume_Education1.RichTextBox_EducationDetail.Text = resume.Gpa;
            uC_Resume_Education1.DateTimePicker_Start.Value = resume.UniversityStartDate;
            uC_Resume_Education1.DateTimePicker_End.Value = resume.UniversityEndDate;
            uC_Resume_Experience1.TextBox_Compay.Text = resume.CompanyName;
            uC_Resume_Experience1.TextBox_Place.Text = resume.WorkPlace;
            uC_Resume_Experience1.RichTextBox_JobDetail.Text = resume.WorkedDetail;
            uC_Resume_Experience1.DateTimePicker_Start.Value = resume.CompanyStartDate;
            uC_Resume_Experience1.DateTimePicker_End.Value = resume.CompanyEndDate;
            uC_Resume_Certificate1.TextBox_CertificateName.Text = resume.Certification;
            uC_Resume_Certificate1.DateTimePicker_Start.Value = resume.TimeCertificate;
        }

        public void ReadOnlyControls()
        {
            textBox_Phone.ReadOnly = true;
            textBox_Email.ReadOnly = true;
            textBox_Address.ReadOnly = true;
            richTextBox_CareerObjective.ReadOnly = true;
            uC_Resume_Education1.TextBox_School.ReadOnly = true;
            uC_Resume_Education1.TextBox_Major.ReadOnly = true;
            uC_Resume_Education1.RichTextBox_EducationDetail.ReadOnly = true;
            //uC_Resume_Education1.DateTimePicker_Start.
            //uC_Resume_Education1.DateTimePicker_End.Value = resume.UniversityEndDate;
            uC_Resume_Experience1.TextBox_Compay.ReadOnly = true;
            uC_Resume_Experience1.TextBox_Place.ReadOnly = true;
            uC_Resume_Experience1.RichTextBox_JobDetail.ReadOnly = true;
            //uC_Resume_Experience1.DateTimePicker_Start.Value = resume.CompanyStartDate;
            //uC_Resume_Experience1.DateTimePicker_End.Value = resume.CompanyEndDate;
            uC_Resume_Certificate1.TextBox_CertificateName.ReadOnly = true;
            //uC_Resume_Certificate1.DateTimePicker_Start.Value = resume.TimeCertificate;
        }

        private void btn_CreateCV_Click(object sender, EventArgs e)
        {
            candidateDAO = new CandidateDAO();
            candidateDAO.SaveCVToDatabase(jobID);
        }
    }
}
