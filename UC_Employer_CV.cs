using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public partial class UC_Employer_CV : UserControl
    {
        private int id;
        private string empID;
        private string cddID;
        private int cvID;
        private bool favorite;
        private EmployerDAO employerDAO = new EmployerDAO();

        public Label Label_Name { get => label_Name; set => label_Name = value; }
        public Label Label_Job { get => label_Job; set => label_Job = value; }
        public Label Label_Phone { get => label_Phone; set => label_Phone = value; }
        public Label Label_Email { get => label_Email; set => label_Email = value; }
        public Label Label_Address { get => label_Address; set => label_Address = value; }
        public Button Button_Favorite { get => button_Favorite; set => button_Favorite = value; }
        public string CddID { get => cddID; set => cddID = value; }
        public int CvID { get => cvID; set => cvID = value; }
        public bool Favorite { get => favorite; set => favorite = value; }
        public string EmpID { get => empID; set => empID = value; }
        public int Id { get => id; set => id = value; }

        public UC_Employer_CV(string empID, string cddID, int cvID)
        {
            InitializeComponent();
            this.empID = empID;
            this.CddID = cddID;
            this.CvID = cvID;
        }

        private void button_detail_Click(object sender, EventArgs e)
        {
            FResume fResume = new FResume(empID, 0, CddID, "Employer");
            fResume.ShowDialog();
        }

        private void button_Favorite_Click(object sender, EventArgs e)
        {
            if (!favorite)
            {
                favorite = true;
                button_Favorite.BackColor = Color.LightGreen;
                FavoriteCV cv = new FavoriteCV(DateTime.Now, empID, cvID);
                employerDAO.AddFavoriteCV(cv);
            }
            else
            {
                favorite = false;
                Color color = new Color();
                color = Color.FromArgb(202, 239, 245);
                button_Favorite.BackColor = color;
                FavoriteCV cv = new FavoriteCV(DateTime.Now, empID, cvID);
                employerDAO.DeleteFavoriteCV(cv);
            }
        }
    }
}
