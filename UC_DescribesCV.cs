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
        private CV cv;
        public UC_DescribesCV(CV cv)
        {
            InitializeComponent();
            this.cv = cv;
        }

        public void LoadValueForTable()
        {
            label_ID.Text = cv.CddID;
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
    }
}
