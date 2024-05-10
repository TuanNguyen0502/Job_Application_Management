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
    public partial class FCandidate_UpdateInfo : Form
    {
        UserControl currentFormChild;
        FlowLayoutPanel flp_ContainsWorkHistory;
        CandidateDAO candidateDAO = new CandidateDAO();
        private string cddid;
        public FCandidate_UpdateInfo(string cddid)
        {
            InitializeComponent();
            this.cddid=cddid;
        }

        private void OpenChildForm(UserControl childForm, Panel panel_Contains)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Hide();
            }

            panel_Contains.BackgroundImage = null;
            currentFormChild = childForm;
            childForm.Dock = DockStyle.Fill;
            panel_Contains.Controls.Add(childForm);
            panel_Contains.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FCandidate_UpdateInfo_Load(object sender, EventArgs e)
        {
            LoadCandidateInfo();
            UC_IntroductionHotizontal introHorizontal = new UC_IntroductionHotizontal();
            introHorizontal.Btn_ResponeFindJobs += btn_LoadJobs;
            OpenChildForm(introHorizontal, pnl_ContainsIntro);
        }

        private void btn_LoadJobs(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadCandidateInfo()
        {
            Candidate candidate = candidateDAO.GetCandidateInfor(cddid);
            textBox_ID.Text = candidate.Id;
            textBox_Name.Text = candidate.Name;
            textBox_PhoneNumber.Text = candidate.Phone;
            textBox_Email.Text = candidate.Email;
            textBox_Address.Text = candidate.Address;
            textBox_Hometown.Text = candidate.Hometown;
            textBox_Education.Text = candidate.Education;
            if (candidate.Sex.Equals("Nam"))
            {
                radioButton_Male.Checked = true;
                radioButton_Female.Checked = false;
            }
            else
            {
                radioButton_Male.Checked = false;
                radioButton_Female.Checked = true;
            }
        }

        public void UpdateCandidateInfor()
        {
            string sex = radioButton_Male.Checked ? "Nam" : "Nữ";
            Candidate candidate = new Candidate(textBox_ID.Text, textBox_Name.Text, textBox_Email.Text, textBox_PhoneNumber.Text, sex, textBox_Address.Text, textBox_Hometown.Text, textBox_Education.Text, null);
            candidateDAO.UpdateCandidateInfor(candidate);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            UpdateCandidateInfor();
        }

        private void button_History_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }
        public void btnAddHistory_Click(object sender, EventArgs e)
        {
            UC_WorkHistory history = new UC_WorkHistory();
            history.AddHistory += btnAddHistory_Click;
            history.DoneAddHistory += btnDoneAddHistory_Click;
            history.RemoveHistory += btnRemoveHistory_Click;
            pnl_Center.Controls.Add(history);

        }
        public void btnDoneAddHistory_Click(object sender, ClickAddHistory e)
        {
            candidateDAO.AddWorkHistory(cddid, e.CompanyName, e.StartDate, e.EndDate);
            pnl_Center.Controls.Clear();
            LoadHistory();
        }
        public void btnRemoveHistory_Click(object sender, ClickAddHistory e)
        {
            candidateDAO.RemoveWorkHistory(cddid, e.CompanyName);
            pnl_Center.Controls.Clear();
            LoadHistory();
        }

        public void LoadHistory()
        {
            flp_ContainsWorkHistory = new FlowLayoutPanel();
            flp_ContainsWorkHistory.Size = new System.Drawing.Size(1000, 765);
            flp_ContainsWorkHistory.AutoScroll = true;

            pnl_Center.Hide();

            pnl_ContainWH.Controls.Add(flp_ContainsWorkHistory);
            List<UC_WorkHistory> historys = candidateDAO.GetWorkHistory();
            foreach (var history in historys)
            {
                history.AddHistory += btnAddHistory_Click;
                history.DoneAddHistory += btnDoneAddHistory_Click;
                history.RemoveHistory += btnRemoveHistory_Click;
                flp_ContainsWorkHistory.Controls.Add(history);
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            pnl_Center.Show();
            FCandidate_UpdateInfo_Load(this, EventArgs.Empty);
        }
    }
}
