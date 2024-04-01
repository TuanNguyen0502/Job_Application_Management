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
    public partial class FCandidate_CreateCV : Form
    {
        CandidateDAO canDAO;
        private string cddID;
        public FCandidate_CreateCV(string cddID)
        {
            InitializeComponent();
            this.cddID = cddID;
            canDAO = new CandidateDAO();
        }
        public FCandidate_CreateCV()
        {
            InitializeComponent();
            canDAO = new CandidateDAO();
        }
        public void SaveCVToDatabase()
        {
            

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            SaveCVToDatabase();
        }

        private void uc_AtFormCreateCV_Load(object sender, EventArgs e)
        {

        }
    }
}
