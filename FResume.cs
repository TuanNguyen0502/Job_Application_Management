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
using Guna.UI2.WinForms;

namespace Job_Application_Management
{
    public partial class FResume : KryptonForm
    {
        private string role;
        private int jobID;
        private string cddID;
        private EmployerDAO employerDAO = new EmployerDAO();

        public FResume(int jobID, string cddID, string role)
        {
            this.jobID = jobID;
            this.cddID = cddID;
            this.role = role;
            InitializeComponent();
            uC_CV1.Role = role;
            uC_CV1.JobID = jobID;
            uC_CV1.CddID = cddID;
            uC_CV1.Button_Approve.Click += button_Approve_Click;
            uC_CV1.Button_Refuse.Click += button_Refuse_Click;
        }

        public FResume()
        {
            InitializeComponent();
        }

        private void button_Approve_Click(object sender, EventArgs e)
        {
            uC_CV1.Resume.Status = "Approved";
            uC_CV1.Label_Status.Text = uC_CV1.Resume.Status;
            employerDAO.UpdateResume(uC_CV1.Resume);
            this.DialogResult = DialogResult.OK;
        }

        private void button_Refuse_Click(object sender, EventArgs e)
        {
            uC_CV1.Resume.Status = "Applying";
            uC_CV1.Label_Status.Text = uC_CV1.Resume.Status;
            employerDAO.UpdateResume(uC_CV1.Resume);
            this.DialogResult = DialogResult.OK;
        }
    }
}
