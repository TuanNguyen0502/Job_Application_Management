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
    public partial class FEmployer_ApprovedCandidate : KryptonForm
    {
        private Form currentFormChild;

        public FEmployer_ApprovedCandidate()
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
            childForm.FormBorderStyle = FormBorderStyle.Sizable;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Detail_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FCandidate_CreateCV());
        }

        private void button_Refuse_Click(object sender, EventArgs e)
        {

        }
    }
}
