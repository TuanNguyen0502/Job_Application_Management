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
    public partial class UC_Employer_InterviewByCv : UserControl
    {
        private int id;
        private string empID;
        private string cddID;
        private int jobID;
        public Label Label_JobName { get => label_JobName; set => label_JobName = value; }
        public Label Label_CandidateName { get => label_CandidateName; set => label_CandidateName = value; }
        public Label Label_InterviewTime { get => label_InterviewTime; set => label_InterviewTime = value; }
        public Label Label_Note { get => label_Note; set => label_Note = value; }
        public int ID { get => id; set => id = value; }

        public UC_Employer_InterviewByCv(int id, string empID, string cddID)
        {
            InitializeComponent();
            this.id = id;
            this.empID = empID;
            this.cddID = cddID;
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            FEmployer_Interview fEmployer_Interview = new FEmployer_Interview(id, empID, cddID, label_JobName.Text);
            fEmployer_Interview.ShowDialog();
        }
    }
}
