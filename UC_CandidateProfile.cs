using ComponentFactory.Krypton.Toolkit;
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
    public partial class UC_CandidateProfile : UserControl
    {
        private string cddID;
        public UC_CandidateProfile()
        {
            InitializeComponent();
        }

        public Label Label_University { get => label_University; set => label_University = value; }
        public Label Label_Name { get => label_Name; set => label_Name = value; }
        public Label Label_GPA { get => label_GPA; set => label_GPA = value; }
        public Label Label_Major { get => label_Major; set => label_Major = value; }
        public KryptonButton Button_detail { get => button_detail; set => button_detail = value; }
        public Label Label_Objective { get => label_Objective; set => label_Objective = value; }
        public Label Label_Company { get => label_Company; set => label_Company = value; }
        public Label Label_Workplace { get => label_Workplace; set => label_Workplace = value; }
        public Label Label_Certification { get => label_Certification; set => label_Certification = value; }
        public string CddID { get => cddID; set => cddID = value; }
    }
}
