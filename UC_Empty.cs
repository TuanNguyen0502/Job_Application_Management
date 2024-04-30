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
    public partial class UC_Empty : UserControl
    {
        public UC_Empty()
        {
            InitializeComponent();
        }
        public event EventHandler FindJobNowClick;
        private void btn_FindJobNow_Click(object sender, EventArgs e)
        {
            FindJobNowClick?.Invoke(this, new EventArgs());
        }
    }
}
