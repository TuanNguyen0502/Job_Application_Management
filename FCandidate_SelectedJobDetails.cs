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
    public partial class FCandidate_SelectedJobDetails : Form
    {
        private string jobid;
        private string cddid;
        private string companyName;

        Label lblDescriptionTitle;
        Label lblWorkingDurationTitle;
        Label lblRequestCddTitle;
        Label lblBenifitTitle;
        Label lblAddress_RecruitTitle;

        Label lblDescription;
        Label lblWorkingDuration;
        Label lblRequestCdd;
        Label lblBenifit;
        Label lblAddress_Recruit;

        CandidateDAO canDAO = new CandidateDAO();
        public FCandidate_SelectedJobDetails()
        {
            InitializeComponent();
            GetDataFromDB();
        }
        public FCandidate_SelectedJobDetails(string jobid, string cddid)
        {
            this.jobid = jobid;
            this.cddid = cddid;
            InitializeComponent();
            GetDataFromDB();
            
        }
        public void GetDataFromDB()
        {
            List<Dictionary<string, object>> keyValueJobDetails = canDAO.GetSelectedJobDetails(jobid);
            foreach (var item in keyValueJobDetails)
            {
                lblJobId.Text = jobid;
                lblJobName_Address.Text = (string)item["JobName"] + $" [{(string)item["Address"]}]";
                lblSalary.Text = item["Salary"].ToString();
                lblAddress.Text = (string)item["Address"];
                lblAdress2.Text = (string)item["Address"];
                lblExp.Text = (string)item["Experience"];
                lblExp2.Text = (string)item["Experience"];
                lblComName.Text = (string)item["CompanyName"];
                DateTime postTime = (DateTime)item["PostTime"];
                TimeSpan diff = postTime.Subtract(DateTime.Now);
                if (diff.TotalDays > 15)
                {
                    lblStatus.Text = "Đã hết hạn. Ứng tuyển lại?";
                }
                else lblStatus.Text = "Đang ứng tuyển";

                companyName = (string)item["CompanyName"];

                // Khai báo các lable để add thông tin vào
                // Description infomation
                lblDescriptionTitle = new Label();
                this.lblDescriptionTitle.Size = new System.Drawing.Size(600, 20);
                this.lblDescriptionTitle.TabIndex = 1;
                this.lblDescriptionTitle.Text = "MÔ TẢ CÔNG VIỆC";
                this.lblDescriptionTitle.Font = new Font("Arial", 10, FontStyle.Bold);
                flpnRecruitment.Controls.Add(lblDescriptionTitle);
                lblDescription = new Label();
                this.lblDescription.Size = new System.Drawing.Size(600, 30);
                this.lblDescription.AutoSize = false;
                this.lblDescription.TabIndex = 2;
                this.lblDescription.Text = (string)item["JobDecription"];
                this.lblDescription.Font = new Font("Arial", 9, FontStyle.Regular);
                flpnRecruitment.Controls.Add(lblDescription);
                // WorkingDurable information
                lblWorkingDurationTitle = new Label();
                this.lblWorkingDurationTitle.Size = new System.Drawing.Size(600, 20);
                this.lblWorkingDurationTitle.TabIndex = 3;
                this.lblWorkingDurationTitle.Text = "THỜI GIAN LÀM VIỆC";
                this.lblWorkingDurationTitle.Font = new Font("Arial", 10, FontStyle.Bold);
                flpnRecruitment.Controls.Add(lblWorkingDurationTitle);
                lblWorkingDuration = new Label();
                this.lblWorkingDuration.Size = new System.Drawing.Size(600, 30);
                this.lblWorkingDuration.AutoSize = false;
                this.lblWorkingDuration.TabIndex = 4;
                int workDuration = (int)item["WorkDuration"];
                this.lblWorkingDuration.Text = workDuration.ToString();
                this.lblWorkingDuration.Font = new Font("Arial", 9, FontStyle.Regular);
                flpnRecruitment.Controls.Add(lblWorkingDuration);
                // Request candidate
                lblRequestCddTitle = new Label();
                this.lblRequestCddTitle.Size = new System.Drawing.Size(600, 20);
                this.lblRequestCddTitle.TabIndex = 5;
                this.lblRequestCddTitle.Text = "YÊU CẦU ỨNG VIÊN";
                this.lblRequestCddTitle.Font = new Font("Arial", 10, FontStyle.Bold);
                flpnRecruitment.Controls.Add(lblRequestCddTitle);
                lblRequestCdd = new Label();
                this.lblRequestCdd.Size = new System.Drawing.Size(600, 30);
                this.lblRequestCdd.AutoSize = false;
                this.lblRequestCdd.TabIndex = 6;
                this.lblRequestCdd.Text = (string)item["RequestCdd"];
                this.lblRequestCdd.Font = new Font("Arial", 9, FontStyle.Regular);
                flpnRecruitment.Controls.Add(lblRequestCdd);
                // Benefit
                lblBenifitTitle = new Label();
                this.lblBenifitTitle.Size = new System.Drawing.Size(600, 20);
                this.lblBenifitTitle.TabIndex = 7;
                this.lblBenifitTitle.Text = "NHỮNG PHÚC LỢI";
                this.lblBenifitTitle.Font = new Font("Arial", 10, FontStyle.Bold);
                flpnRecruitment.Controls.Add(lblBenifitTitle);
                lblBenifit = new Label();
                this.lblBenifit.Size = new System.Drawing.Size(600, 30);
                this.lblBenifit.AutoSize = false;
                this.lblBenifit.TabIndex = 8;
                this.lblBenifit.Text = (string)item["Benefit"];
                this.lblBenifit.Font = new Font("Arial", 9, FontStyle.Regular);
                flpnRecruitment.Controls.Add(lblBenifit);
                // Recruit
                lblAddress_Recruit = new Label();
                this.lblAddress_Recruit.Size = new System.Drawing.Size(600, 20);
                this.lblAddress_Recruit.TabIndex = 9;
                this.lblAddress_Recruit.Text = "ĐỊA ĐIỂM LÀM VIỆC";
                this.lblAddress_Recruit.Font = new Font("Arial", 10, FontStyle.Bold);
                flpnRecruitment.Controls.Add(lblAddress_Recruit);

                lblAddress_RecruitTitle = new Label();
                this.lblAddress_RecruitTitle.Size = new System.Drawing.Size(600, 30);
                this.lblAddress_RecruitTitle.AutoSize = false;
                this.lblAddress_RecruitTitle.TabIndex = 10;
                this.lblAddress_RecruitTitle.Text = (string)item["Address"];
                this.lblAddress_RecruitTitle.Font = new Font("Arial", 9, FontStyle.Regular);
                flpnRecruitment.Controls.Add(lblAddress_RecruitTitle);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FCandidate_CompanyDetails com = new FCandidate_CompanyDetails(companyName);
            com.ShowDialog();
        }
        private void FEmployer_SeeCVDetailOfCandidate_Load(object sender, EventArgs e)
        {
            //flpnRecruitment.Controls.Add()
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            canDAO.AddAppliedJob(jobid);
            //
            canDAO.SaveResumeToDatabase(cddid, jobid);
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            canDAO.AddSavedJob(jobid);
        }
    }
}
