using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private string connStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Jobs_Management;Integrated Security=True";
        private string sqlQuery;
        private UC_EmployerJob[] uC_EmployerJobs;
        private EmployerDAO employerDAO;

        public FEmployer_Job()
        {
            InitializeComponent();
            employerDAO = new EmployerDAO();
            uC_EmployerJobs = new UC_EmployerJob[] { };
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
            OpenChildForm(new FEmployer_JobDetail(null));
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

        private void FEmployer_Job_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {
            List<UC_EmployerJob> jobItems = employerDAO.GetJobsFromDB();
            foreach (var jobItem in jobItems)
            {
                flowLayoutPanel_Jobs.Controls.Add(jobItem);
            }
        }
    }
}
