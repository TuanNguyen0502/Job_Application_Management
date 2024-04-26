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
    public partial class UC_Candidate_Interview : UserControl
    {
        private Job job;
        private Interview interview;
        public UC_Candidate_Interview(Job job, Interview interview)
        {
            InitializeComponent();
            this.job = job;
            this.interview = interview;
        }
    }
}
