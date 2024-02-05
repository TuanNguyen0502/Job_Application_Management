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
    public partial class frmCandidate : Form
    {
        public frmCandidate()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure want to exit this program?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            // Xử lý kết quả từ Message Box
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
