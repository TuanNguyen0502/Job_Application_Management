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
    public partial class FEmployer_Resumes : Form
    {
        private EmployerDAO employerDAO = new EmployerDAO();

        public FEmployer_Resumes()
        {
            InitializeComponent();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Search.Text))
            {
                flowLayoutPanel1.Controls.Clear();
                LoadData();
            }
            else
            {

            }
        }

        private void FEmployer_Resumes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {

        }
    }
}
