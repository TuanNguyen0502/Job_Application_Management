using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public partial class UC_CandidateCV : UserControl
    {
        private Form currentFormChild;
        private int jobID;
        private string cddID;
        public KryptonButton Button_detail { get => button_detail; set => button_detail = value; }
        public KryptonButton Button_delete { get => button_delete; set => button_delete = value; }
        public Label Label_Name { get => label_Name; set => label_Name = value; }
        public Label Label_University { get => label_University; set => label_University = value; }
        public Label Label_Major { get => label_Major; set => label_Major = value; }
        public Label Label_GPA { get => label_GPA; set => label_GPA = value; }
        public string CddID { get => cddID; set => cddID = value; }

        public UC_CandidateCV(int jobID)
        {
            this.jobID = jobID;
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_detail_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FResume(jobID, CddID, "Employer"));
            
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
