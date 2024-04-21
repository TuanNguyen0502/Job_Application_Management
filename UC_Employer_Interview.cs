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
    public partial class UC_Employer_Interview : UserControl
    {
        public Label Label_JobName {  get => label_JobName; set => label_JobName = value; }
        public Label Label_CandidateName { get => label_CandidateName; set => label_CandidateName = value; }
        public Label Label_InterviewTime { get => label_InterviewTime; set => label_InterviewTime = value; }
        public Label Label_Note{ get => label_Note; set => label_Note = value; }

        public UC_Employer_Interview()
        {
            InitializeComponent();
        }
    }
}
