using Guna.UI2.WinForms;
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
    public partial class FEmployerMain : Form
    {
        private string empID;
        private Form currentFormChild;

        public FEmployerMain(string empID)
        {
            InitializeComponent();
            this.empID = empID;
            OpenChildForm(new FEmployer_Home());
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                //var t = Task.Delay(500); //1 second/1000 ms
                //t.Wait();
            }

            panel_Center.BackgroundImage = null;
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Center.Controls.Add(childForm);
            panel_Center.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 141, b.Location.Y - 44);
            imgSlide.SendToBack();
        }

        private void button_Home_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_Home());
        }

        private void button_Information_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_Information(empID));
        }

        private void button_Job_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_Job(empID));
        }

        private void button_FindCandidate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_Candidates());
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            Program.MainFormManager.CurrentForm = new FLogin();
        }

        private void button_Interview_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_Interviews(empID));
        }
    }
}
