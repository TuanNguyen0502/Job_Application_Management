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
    public partial class FEmployer_Job : KryptonForm
    {
        private Form currentFormChild;

        public FEmployer_Job()
        {
            InitializeComponent();
            
            uC_EmployerJob1.Button_Post.Click += button_Post_Click;
            uC_EmployerJob1.Button_delete.Click += Button_Delete_Click;

            uC_EmployerJob2.Button_Post.Click += button_Post_Click;
            uC_EmployerJob2.Button_delete.Click += Button_Delete_Click;
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

        private void button_Post_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_JobDetail());
        }

        private void button_Change_Click(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
