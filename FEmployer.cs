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
    public partial class FEmployer : KryptonForm
    {
        private Form currentFormChild;
        public FEmployer()
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
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Center.Controls.Add(childForm);
            panel_Center.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_Information_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_Information());
        }

        private void button_PostJob_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_PostJob());
        }

        private void button_FindCandidate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_FindCandidate());
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
                currentFormChild.Close();
        }

        private void button_SignOut_Click(object sender, EventArgs e)
        {
            Program.MainFormManager.CurrentForm = new FLogin();
        }
    }
}
