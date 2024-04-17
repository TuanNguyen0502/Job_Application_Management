using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Job_Application_Management
{
    public partial class FEmployer_Job : KryptonForm
    {
        private string empID;
        private Form currentFormChild;
        private EmployerDAO employerDAO = new EmployerDAO();

        public FEmployer_Job(string empID)
        {
            this.empID = empID;
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

        private void button_Delete_Click(object sender, ButtonClickEventArgs e)
        {
            employerDAO.DeleteJob(e.CddID);
            flowLayoutPanel_Jobs.Controls.Remove(sender as UC_EmployerJob);
        }

        private void button_Post_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FEmployer_JobDetail(0, empID));
        } 

        private void FEmployer_Job_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {
            List<UC_EmployerJob> jobItems = employerDAO.GetJobsFromDB(empID);
            foreach (var jobItem in jobItems)
            {
                jobItem.Button_Delete_Click += button_Delete_Click;
                flowLayoutPanel_Jobs.Controls.Add(jobItem);
            }
        }
    }
}
