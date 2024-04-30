using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Job_Application_Management
{
    public partial class FCandidate_Interviews : Form
    {
        CandidateDAO canDAO = new CandidateDAO();
        
        public FCandidate_Interviews()
        {
            InitializeComponent();
        }
        public Guna2Button Btn_Search { get { return btn_Search; } }
        private void FCandidate_Interviews_Load(object sender, EventArgs e)
        {
            List<UC_Candidate_Interview> lstInterviews = canDAO.GetListInterviewsToDB();
            foreach(var item in lstInterviews)
            {
                item.SeeInterview_Click += seeInterview_Click;
                flp_ContainsInterviews.Controls.Add(item);
            }
        }
        public event EventHandler<ClickInterviews> ClickInterviews;
        private void seeInterview_Click(object sender, ClickInterviews e)
        {
            ClickInterviews?.Invoke(this, new ClickInterviews(e.CddName, e.CompanyName, e.JobName, e.Interview, e.Note));
        }

        public event EventHandler Readload_Click;
        private void btn_Reload_Click(object sender, EventArgs e)
        {
            Readload_Click?.Invoke(this, new EventArgs());
        }

        public event EventHandler Search_Click;
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search_Click?.Invoke(this, new EventArgs());
            List<UC_Candidate_Interview> lstInterviews = canDAO.GetListInterviewByKey(txt_Search.Text);
            foreach (var item in lstInterviews)
            {
                item.SeeInterview_Click += seeInterview_Click;
                flp_ContainsInterviews.Controls.Add(item);
            }
        }
    }
}
