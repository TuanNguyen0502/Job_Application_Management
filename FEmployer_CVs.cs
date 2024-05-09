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
    public partial class FEmployer_CVs : Form
    {
        private string empID;
        private EmployerDAO employerDAO = new EmployerDAO();

        public FEmployer_CVs(string empID)
        {
            InitializeComponent();
            this.empID = empID;
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
            flowLayoutPanel1.Controls.Clear();
            List<UC_Employer_CV> cvs = employerDAO.GetCVsFromDB(empID);
            List<UC_Employer_CV> favoriteCVs = employerDAO.GetFavoriteCVsFromDB(empID);
            foreach (UC_Employer_CV cv in cvs)
            {
                foreach (var favoriteCV in favoriteCVs)
                {
                    if (cv.CvID == favoriteCV.CvID && cv.CddID == favoriteCV.CddID)
                    {
                        cv.Favorite = true;
                        cv.Button_Favorite.BackColor = Color.LightGreen;
                    }
                }
                flowLayoutPanel1.Controls.Add(cv);
            }
        }

        private void LoadFavoriteCV()
        {
            flowLayoutPanel1.Controls.Clear();
            List<UC_Employer_CV> favoriteCVs = employerDAO.GetFavoriteCVsFromDB(empID);
            foreach (UC_Employer_CV cv in favoriteCVs)
            {
                cv.Favorite = true;
                cv.Button_Favorite.BackColor = Color.LightGreen;
                flowLayoutPanel1.Controls.Add(cv);
            }
        }

        private void button_Favorite_Click(object sender, EventArgs e)
        {
            LoadFavoriteCV();
        }
    }
}
