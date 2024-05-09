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
    public partial class UC_DescribesCV : UserControl
    {
        CandidateDAO canDAO = new CandidateDAO();
        private CV cv;
        public UC_DescribesCV(CV cv)
        {
            InitializeComponent();
            this.cv = cv;
        }

        public void LoadValueForTable()
        {
            label_ID.Text = cv.ID.ToString();
            lbl_Nominee.Text = cv.Nominee;
            label_Major.Text = cv.Major;
            label_GPA.Text = cv.Gpa;
            lbl_UniversityName.Text = cv.UniversityName;
            lblCertification.Text = cv.Certification;
        }

        private void UC_DescribesCV_Load(object sender, EventArgs e)
        {
            LoadValueForTable();
        }
        public event EventHandler<ButtonClickEventArgs> Remove_DescribeCV;
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Remove_DescribeCV?.Invoke(this, new ButtonClickEventArgs(cv));
        }
        public event EventHandler<ButtonClickEventArgs> Describe_Click; 
        private void UC_DescribesCV_Click(object sender, EventArgs e)
        {
            Describe_Click?.Invoke(this, new ButtonClickEventArgs(cv));
        }
        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            Describe_Click?.Invoke(this, new ButtonClickEventArgs(cv));
        }
    }
}
