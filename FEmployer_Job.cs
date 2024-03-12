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
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Size = new Size(1300, 550);
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_Post_Click(object sender, EventArgs e)
        {

        }

        private void button_Change_Click(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

        }

        private void ucJob_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_JobDetail());
        }
    }
}
