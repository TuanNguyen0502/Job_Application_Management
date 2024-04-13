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
    public partial class UC_Introduction : UserControl
    {
        public UC_Introduction()
        {
            InitializeComponent();
        }
        public event EventHandler Btn_ResponeFindJobs;
        private void btn_ResponeFind_Click(object sender, EventArgs e)
        {
            Btn_ResponeFindJobs?.Invoke(this, new EventArgs());
        }
    }
}
