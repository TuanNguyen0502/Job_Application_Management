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
    public partial class UC_CV : UserControl
    {
        public UC_CV()
        {
            InitializeComponent();
        }

        public event EventHandler AddEdu;
        private void btnAdd_Education_Click(object sender, EventArgs e)
        {
            AddEdu?.Invoke(this, new EventArgs());
        }
        public event EventHandler AddEx;
        private void btnAdd_Experiences_Click(object sender, EventArgs e)
        {
            AddEx?.Invoke(this, new EventArgs());
        }
        public event EventHandler AddCer;
        private void btnAdd_Certification_Click(object sender, EventArgs e)
        {
            AddCer?.Invoke(this, new EventArgs());
        }
        public event EventHandler CreateCV;
        private void btn_CreateCV_Click(object sender, EventArgs e)
        {
            CreateCV?.Invoke(this, new EventArgs());
        }
        public event EventHandler ApproveCV;

        private void button_Approve_Click(object sender, EventArgs e)
        {
            ApproveCV?.Invoke(this, new EventArgs());
        }
        public event EventHandler RefuseCV;

        private void button_Refuse_Click(object sender, EventArgs e)
        {
            RefuseCV?.Invoke(this, new EventArgs());
        }
        public event EventHandler RemoveCV;

        private void btn_RemoveCVValid_Click(object sender, EventArgs e)
        {
            RemoveCV?.Invoke(this, new EventArgs());
        }
    }
}
