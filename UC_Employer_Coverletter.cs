using ComponentFactory.Krypton.Toolkit;
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
    public partial class UC_Employer_Coverletter : UserControl
    {
        private string cddID;
        
        public Label Label_Objective { get => label_CareerGoal; set => label_CareerGoal = value; }
        public Label Label_University { get => label_University; set => label_University = value; }
        public Label Label_Major { get => label_Major; set => label_Major = value; }
        public Label Label_GPA { get => label_GPA; set => label_GPA = value; }
        public Label Label_Company { get => label_Company; set => label_Company = value; }
        public Label Label_Workplace { get => label_Workplace; set => label_Workplace = value; }
        public Label Label_Certification { get => label_Certificate; set => label_Certificate = value; }
        public string CddID { get => cddID; set => cddID = value; }
        public UC_Employer_Coverletter()
        {
            InitializeComponent();
        }
    }
}
