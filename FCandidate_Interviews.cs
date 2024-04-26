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
    public partial class FCandidate_Interviews : Form
    {
        CandidateDAO canDAO = new CandidateDAO();
        
        public FCandidate_Interviews()
        {
            InitializeComponent();
        }

        private void FCandidate_Interviews_Load(object sender, EventArgs e)
        {
            List<UC_Candidate_Interview> lstInterviews = canDAO.GetListInterviewsToDB();
            foreach(var item in lstInterviews)
            {
                flp_ContainsInterviews.Controls.Add(item);
            }
        }
    }
}
