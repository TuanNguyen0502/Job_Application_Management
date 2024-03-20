using ComponentFactory.Krypton.Toolkit;
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
    public partial class UC_EmployerJob : UserControl
    {
        private Form currentFormChild;
        private string jobID;

        public Label Label_PostedTime { get => label_PostedTime; set => label_PostedTime = value; }
        public Label Label_JobName { get => label_JobName; set => label_JobName = value; }
        public KryptonButton Button_Edit { get => button_Edit; set => button_Edit = value; }
        public KryptonButton Button_delete { get => button_delete; set => button_delete = value; }
        public string JobID { get => jobID; set => jobID = value; }

        public UC_EmployerJob()
        {
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
            childForm.Size = new Size(1300, 600);
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_JobDetail(JobID));
        }
    }
}
