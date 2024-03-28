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

        public UC_Resume()
        {
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
        public string RichTextBox_CareerObjective
        {
            get { return richTextBox_CareerObjective.Text; }
        }
        public TableLayoutPanel TableLayoutPanel1
        {
            get { return tableLayoutPanel1; }
        }
        public FlowLayoutPanel FlowLayoutPanel1
        {
            get { return flowLayoutPanel1; }
        }
        public UserControl UC_Resume_Education1
        {
            get { return uC_Resume_Education1; }
        }
        public string TextBox_School
        {
            get { return uC_Resume_Education1.TextBox_School.Text; }
        }
        public string TextBox_Start
        {
            get { return uC_Resume_Education1.TextBox_Start.Text; }
        }
        public string TextBox_End
        {
            get { return uC_Resume_Education1.TextBox_End.Text; }
        }
        public string TextBox_Major
        {
            get { return uC_Resume_Education1.TextBox_Major.Text; }
        }
        public string RichTextBox_EducationDetail
        {
            get { return uC_Resume_Education1.RichTextBox_EducationDetail.Text; }
        }
        //
        public UserControl UC_Resume_Experience1
        {
            get { return uC_Resume_Experience1; }
        }
        public string TextBox_JobID
        {
            get { return uC_Resume_Experience1.TextBox_JobID.Text; }
        }
        public string TextBox_Compay
        {
            get { return uC_Resume_Experience1.TextBox_Compay.Text; }
        }
        public string TextBox_Place
        {
            get { return uC_Resume_Experience1.TextBox_Place.Text; }
        }
        public UserControl UC_Resume_Certificate1
        {
            get { return uC_Resume_Certificate1; }
        }
        public string TextBox_CertificateName
        {
            get { return uC_Resume_Certificate1.TextBox_CertificateName.Text; }
        }
        public DateTime KryptonDateTimePicker1
        {
            get { return uC_Resume_Certificate1.KryptonDateTimePicker1.Value; }
        }
        public string TextBox_Phone
        {
            get { return textBox_Phone.Text; }
        }
        public string TextBox_Email
        {
            get { return textBox_Email.Text; }
        }
        public string TextBox_Address
        {
            get { return textBox_Address.Text; }
        }

        public string JobID { get => jobID; set => jobID = value; }
        public string CddID { get => cddID; set => cddID = value; }

        private void UC_Resume_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {

        }
    }
}
