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
    public partial class UC_Employer_Candidate : UserControl
    {
        private string cddID;

        public Label Label_Name { get => label_Name; set => label_Name = value; }
        public Label Label_Phone { get => label_Phone; set => label_Phone = value; }
        public Label Label_Email { get => label_Email; set => label_Email = value; }
        public Label Label_Hometown { get => label_Hometown; set => label_Hometown = value; }
        public Label Label_University { get => label_University; set => label_University = value; }
        public string CddID { get => cddID; set => cddID = value; }

        public UC_Employer_Candidate()
        {
            InitializeComponent();
        }

        private void label_Name_Click(object sender, EventArgs e)
        {

        }
    }
}
