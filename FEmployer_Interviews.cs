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
    public partial class FEmployer_Interviews : Form
    {
        private string empID;
        private EmployerDAO employerDAO = new EmployerDAO();

        public FEmployer_Interviews(string empID)
        {
            InitializeComponent();
            this.empID = empID;
        }

        private void FEmployer_Interviews_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button_LoadData_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadData();
        }

        private void LoadData()
        {
            List<UC_Employer_Interview> interviews = employerDAO.GetInterviewsFromDB(empID);
            foreach (var interview in interviews)
            {
                flowLayoutPanel1.Controls.Add(interview);
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (textBox_Search.Text == null || textBox_Search.Text == "")
            {
                MessageBox.Show("Enter you keyword !", "Empty keyword", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            flowLayoutPanel1.Controls.Clear();
            List<UC_Employer_Interview> jobItems = employerDAO.SearchInterviewsFromDB(empID, textBox_Search.Text);
            foreach (var jobItem in jobItems)
            {
                flowLayoutPanel1.Controls.Add(jobItem);
            }
        }
    }
}
