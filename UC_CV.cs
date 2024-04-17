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

        public CV GetInfoResumeAtForm()
        {
            CV myCV = new CV();

            myCV.CddName = label_CandidateName.Text;
            myCV.WorkPlace = label_Nominee.Text;
            myCV.CddPhone = textBox_Phone.Text;
            myCV.CddAddress = textBox_Address.Text;
            myCV.CddEmail = textBox_Email.Text;
            myCV.Objective = richTextBox_CareerGoal.Text;
            myCV.Major = textBox_Major.Text;
            myCV.Gpa = "8.0";
            myCV.UniversityName = textBox_University.Text;
            myCV.UniversityStartDate = dateTimePicker_UniversityStartDate.Value;
            myCV.UniversityEndDate = dateTimePicker_UniversityEndDate.Value;
            myCV.WorkedDetail = richTextBox_Detail.Text;
            myCV.CompanyName = textBox_Company.Text;
            myCV.CompanyStartDate = dateTimePicker_CompanyStartDate.Value;
            myCV.CompanyEndDate = dateTimePicker_CompanyEndDate.Value;
            myCV.WorkPlace = textBox_Workplace.Text;
            myCV.Certification = textBox_Certification.Text;
            myCV.TimeCertificate = dateTimePicker_Certification.Value;
            myCV.Status = label_Status.Text;
            MessageBox.Show("Get info resume successful. " + myCV.Objective);
            return myCV;
        }

        private void UC_CV_Load(object sender, EventArgs e)
        {
            if (Role == "Employer")
            {
                LoadInfor();
                ReadOnlyControls();
            }
        }

        private void LoadInfor()
        {
            resume = employerDAO.GetResumeFromDB(jobID, cddID);

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
            dateTimePicker_Certification.Value = resume.TimeCertificate;
            label_Status.Text = resume.Status;
        }

        public void ReadOnlyControls()
        {
            textBox_Phone.ReadOnly = true;
            textBox_Email.ReadOnly = true;
            textBox_Address.ReadOnly = true;
            richTextBox_CareerGoal.ReadOnly = true;
            textBox_University.ReadOnly = true;
            textBox_Major.ReadOnly = true;
            textBox_GPA.ReadOnly = true;
            //uC_Resume_Education1.DateTimePicker_Start.
            //uC_Resume_Education1.DateTimePicker_End.Value = resume.UniversityEndDate;
            textBox_Company.ReadOnly = true;
            textBox_Workplace.ReadOnly = true;
            richTextBox_Detail.ReadOnly = true;
            //uC_Resume_Experience1.DateTimePicker_Start.Value = resume.CompanyStartDate;
            //uC_Resume_Experience1.DateTimePicker_End.Value = resume.CompanyEndDate;
            textBox_Certification.ReadOnly = true;
            //uC_Resume_Certificate1.DateTimePicker_Start.Value = resume.TimeCertificate;
            btn_CreateCV.Visible = false;
        }

        private void btn_CreateCV_Click(object sender, EventArgs e)
        {
            //candidateDAO.SaveCVToDatabase(jobID);
        }

        private void button_Approve_Click(object sender, EventArgs e)
        {
            resume.Status = "Approved";
            label_Status.Text = resume.Status;
            employerDAO.UpdateResume(resume);
        }

        private void button_Refuse_Click(object sender, EventArgs e)
        {
            resume.Status = "Applying";
            label_Status.Text = resume.Status;
            employerDAO.UpdateResume(resume);
        }
    }
}
