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
    public partial class FEmployer_Interview : Form
    {
        private string empID;
        private string cddID;
        private int jobID;
        public FEmployer_Interview(string empID, string cddID, int jobID)
        {
            InitializeComponent();
            this.empID = empID;
            this.cddID = cddID;
            this.jobID = jobID;
        }
    }
}
