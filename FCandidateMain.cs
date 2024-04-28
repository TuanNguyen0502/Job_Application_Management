using Guna.UI2.WinForms;
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
    public partial class FCandidateMain : Form
    {
        CandidateDAO canDAO = new CandidateDAO();
        Form currentFormChild;
        private FlowLayoutPanel flp_ContainsWorkHistory;
        public FCandidateMain()
        {
            InitializeComponent();
        }
        public FCandidateMain(string cddID) : this()
        {
            lblCddID.Text = cddID;
            lbl_Notification.Text = "0";
            NumberOfNotification();
            lbl_CddName.Text = canDAO.GetNameByCddID(cddID);
        }
        public void SetIntroduction()
        {
            flp_ContainsJobs.Controls.Clear();
            UC_Introduction introduction = new UC_Introduction();
            introduction.Btn_ResponeFindJobs += btn_ResponeFindJobs_Click;
            flp_ContainsJobs.Controls.Add(introduction);
        }
        public void NumberOfNotification()
        {
            int numberOfNotification = canDAO.CountRowsInInterviews();
            lbl_Notification.Text = numberOfNotification.ToString();
        }
        private void OpenChildForm(Form childForm, Panel panel_Contains)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            panel_Contains.BackgroundImage = null;
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Contains.Controls.Add(childForm);
            panel_Contains.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 145, b.Location.Y - 44);
            imgSlide.SendToBack();
        }

        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FCandidateMain_Load(object sender, EventArgs e)
        {
            ListJobs();
        }
        private void CheckJobsSavedAndPushIntoFLP(UC_CandidateMain candidateMain)
        {
            
            List<UC_JobsSaved> jobSaveds = canDAO.GetSavedJobsFromDB();
            foreach (var jobSaved in jobSaveds)
            {
                if (candidateMain._Job.Id == jobSaved.SavedJob.Id)
                {
                    candidateMain.BtnApply.Enabled = false;
                    candidateMain.BtnApply.BackColor = Color.LightGreen;
                    break;
                }
            }
            flp_ContainsJobs.Controls.Add(candidateMain);
            candidateMain.ClickToJob += clickToShowJobDetails_Click;
            candidateMain.Lbl_Salary += clickToShowJobDetails_Click;
            candidateMain.Lbl_Address += clickToShowJobDetails_Click;
            candidateMain.Lbl_JobName += clickToShowJobDetails_Click;
            candidateMain.Lbl_CompanyName += clickToShowJobDetails_Click;
            candidateMain.Cptb_Company += clickToShowJobDetails_Click;
        }
        public void ListJobs()
        {
            
            List<UC_CandidateMain> jobItems = canDAO.GetJobsFromDB(lblCddID.Text);
            foreach (var jobItem in jobItems)
            {
                CheckJobsSavedAndPushIntoFLP(jobItem);
            }
        }
        private void clickToShowJobDetails_Click(object sender, ButtonClickEventArgs e)
        {
            
            FCandidate_SelectedJobDetails selected = new FCandidate_SelectedJobDetails(e.JobID, e.CddID);
            OpenChildForm(selected, pnl_ContainDetailsJob);
            
        }

        private void btnSearchFor_Click(object sender, EventArgs e)
        {
            pnl_ContainDetailsJob.Controls.Clear();
            if (flp_ContainsJobs.Controls.Count >= 0)
            {
                flp_ContainsJobs.Controls.Clear();
                List<UC_CandidateMain> jobItems = canDAO.GetJobsByKeywords(txt_SearchFor.Text);
                foreach (var jobItem in jobItems)
                {
                    CheckJobsSavedAndPushIntoFLP(jobItem);
                }
            }
        }

        private void cbb_Address_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnl_ContainDetailsJob.Controls.Clear();
            if (cbb_Address.SelectedItem.ToString() != "Tất cả tỉnh/TP")
            {
                if (flp_ContainsJobs.Controls.Count > 0)
                {
                    flp_ContainsJobs.Controls.Clear();
                }
                List<UC_CandidateMain> jobItems = canDAO.GetJobsByAddress(cbb_Address.SelectedItem.ToString());
                foreach (var jobItem in jobItems)
                {
                    CheckJobsSavedAndPushIntoFLP(jobItem);
                }
            }
            else
            {
                if (flp_ContainsJobs.Controls.Count >= 0)
                {
                    flp_ContainsJobs.Controls.Clear();
                }
                ListJobs();
            }
        }
        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            
            flp_ContainsJobs.Controls.Clear();
            pnl_ContainDetailsJob.Controls.Clear();
            ListJobs();
        }
        private void btn_ResponeFindJobs_Click(object sender, EventArgs e)
        {
            
            flp_ContainsJobs.Controls.Clear();
            pnl_ContainDetailsJob.Controls.Clear();
            ListJobs();
        }
        private void btn_JobsSaved_Click(object sender, EventArgs e)
        {

            SetIntroduction();
            OpenChildForm(new FCandidate_SavedJobs(lblCddID.Text), pnl_ContainDetailsJob);
        }

        private void btn_JobsApplied_Click(object sender, EventArgs e)
        {

            SetIntroduction();
            OpenChildForm(new FCandidate_AppliedJobs(), pnl_ContainDetailsJob);
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            
            FCandidate_CreateCV createCV = new FCandidate_CreateCV(lblCddID.Text);
            createCV.ShowDialog();
        }

        private void btn_Posting_Click(object sender, EventArgs e)
        {

            SetIntroduction();
            OpenChildForm(new FCandidate_PostFindJob(lblCddID.Text), pnl_ContainDetailsJob);
        }

        private void btn_LogOut_Click_1(object sender, EventArgs e)
        {
            Program.MainFormManager.CurrentForm = new FLogin();

        }

        private void clickInterview_Click(object sender, ClickInterviews e)
        {
            Label lbl_MessageInterview = new Label();
            // 
            // lbl_MessageInterview
            // 
            lbl_MessageInterview.Anchor = System.Windows.Forms.AnchorStyles.None;
            lbl_MessageInterview.Location = new System.Drawing.Point(3, 0);
            lbl_MessageInterview.Name = "lbl_MessageInterview";
            lbl_MessageInterview.Size = new System.Drawing.Size(473, 700);
            lbl_MessageInterview.TabIndex = 0;
            lbl_MessageInterview.Font = new Font("Segoe UI", 12);
            lbl_MessageInterview.AutoSize = false;
            lbl_MessageInterview.Text = $"Chào bạn [{e.CddName}],"

            +$"Lời đầu tiên, chúng tôi xin cảm ơn bạn vì đã quan tâm đến vị trí ứng tuyển của công ty[{e.CompanyName}]. Thông qua hồ sơ mà bạn đã gửi về, chúng tôi nhận thấy bạn có kiến thức chuyên môn phù hợp với vị trí mà chúng tôi đang tuyển."

            +$"Chúng tôi trân trọng kính mời bạn đến tham gia buổi phỏng vấn của công ty chúng tôi tại:"+

                        $"Thời gian: Ngày [{e.Interview.Day}], [{e.Interview}]"+
                        $"Địa điểm: [Địa chỉ Công ty]"+
                        $"Ngôn ngữ phỏng vấn: [Ngôn ngữ]"+
                        $"Để buổi phỏng vấn được diễn ra thuận lợi, bạn vui lòng phản hồi lại email này trong 24h kể từ khi nhận được. Mọi thắc mắc khác, bạn vui lòng liên hệ với chúng tôi qua: [Số điện thoại] - [E-mail]"+

                        $"[{e.CompanyName}] chúc bạn sẽ có một buổi phỏng vấn thành công."+

            $"Trân trọng,"+

            $"[Chữ ký công ty :D]";
            flp_ContainsJobs.Controls.Clear();
            flp_ContainsJobs.Controls.Add(lbl_MessageInterview);
        }

        private void btn_Readload_Click(object sender, EventArgs e)
        {
            SetIntroduction();
            FCandidate_Interviews fInterview = new FCandidate_Interviews();
            fInterview.ClickInterviews += clickInterview_Click;
            fInterview.Readload_Click += btn_Readload_Click;
            fInterview.Search_Click += btn_Search_Click;
            OpenChildForm(fInterview, pnl_ContainDetailsJob);
        }

        private void btn_Search_Click (object sender, EventArgs e)
        {
            SetIntroduction();
            FCandidate_Interviews fInterview = new FCandidate_Interviews();
            fInterview.ClickInterviews += clickInterview_Click;
            fInterview.Readload_Click += btn_Readload_Click;
            fInterview.Search_Click += btn_Search_Click;
            OpenChildForm(fInterview, pnl_ContainDetailsJob);
        }

        private void ptb_Notification_Click(object sender, EventArgs e)
        {
            SetIntroduction();
            FCandidate_Interviews fInterview = new FCandidate_Interviews();
            fInterview.ClickInterviews += clickInterview_Click;
            fInterview.Readload_Click += btn_Readload_Click;
            fInterview.Search_Click += btn_Search_Click;
            OpenChildForm(fInterview, pnl_ContainDetailsJob);
        }

        private void lbl_Notification_Click(object sender, EventArgs e)
        {
            SetIntroduction();
            FCandidate_Interviews fInterview = new FCandidate_Interviews();
            fInterview.ClickInterviews += clickInterview_Click;
            OpenChildForm(fInterview, pnl_ContainDetailsJob);
        }


        private void btn_WorkHistory_Click(object sender, EventArgs e)
        {
            SetIntroduction();
            LoadHistory();
        }
        public void btnAddHistory_Click(object sender, EventArgs e)
        {
            UC_WorkHistory history = new UC_WorkHistory();
            history.AddHistory += btnAddHistory_Click;
            history.DoneAddHistory += btnDoneAddHistory_Click;
            history.RemoveHistory += btnRemoveHistory_Click;
            pnl_ContainDetailsJob.Controls.Add(history);

        }
        public void btnDoneAddHistory_Click(object sender, ClickAddHistory e)
        {
            canDAO.AddWorkHistory(lblCddID.Text, e.CompanyName, e.StartDate, e.EndDate);
            pnl_ContainDetailsJob.Controls.Clear();
            LoadHistory();
        }
        public void btnRemoveHistory_Click(object sender, ClickAddHistory e)
        {
            canDAO.RemoveWorkHistory(lblCddID.Text, e.CompanyName);
            pnl_ContainDetailsJob.Controls.Clear();
            LoadHistory();
        }

        public void LoadHistory()
        {
            flp_ContainsWorkHistory = new FlowLayoutPanel();
            flp_ContainsWorkHistory.Size = new System.Drawing.Size(830, 665);
            flp_ContainsWorkHistory.AutoScroll = true;
            pnl_ContainDetailsJob.Controls.Clear();
            pnl_ContainDetailsJob.Controls.Add(flp_ContainsWorkHistory);
            List<UC_WorkHistory> historys = canDAO.GetWorkHistory();
            foreach (var history in historys)
            {
                history.AddHistory += btnAddHistory_Click;
                history.DoneAddHistory += btnDoneAddHistory_Click;
                history.RemoveHistory += btnRemoveHistory_Click;
                flp_ContainsWorkHistory.Controls.Add(history);
            }

            
        }
    }
}
