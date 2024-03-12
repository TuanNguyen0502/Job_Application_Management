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
    public partial class FEmployer_JobDetail : KryptonForm
    {
        private Form currentFormChild;

        public FEmployer_JobDetail()
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
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_SeeCandidate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_SeeCandidate());
        }

        private void button_ApprovedCandidate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_ApprovedCandidate());
        }
    }
}
