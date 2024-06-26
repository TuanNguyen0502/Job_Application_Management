﻿using System;
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
        private int jobid;
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
        public FCandidate_SelectedJobDetails(int jobid, string cddid)
        {
            this.jobid = jobid;
            this.cddid = cddid;
            InitializeComponent();
            GetDataFromDB();
            CheckAppliedJobsAfterPushIntoPanle();
        }
        public void CheckJobSaved()
        {
            int flag = canDAO.CountJobSaved(cddid);
            if (flag > 0)
            {
                btnSaved.BackColor = Color.DarkGreen;
                btnSaved.Enabled = false;
            }
            else
            {
                btnSaved.BackColor = Color.White;
                btnSaved.Enabled = true;
            }
        }
        private void FCandidate_SelectedJobDetails_Load(object sender, EventArgs e)
        {
            CheckJobSaved();
        }
        public void CheckAppliedJobsAfterPushIntoPanle()
        {
            List<UC_AppliedJobs> appliedJobs = canDAO.GetAppliedJobsFromDB(cddid);
            foreach (var applied in appliedJobs)
            {
                if (jobid == applied.AppliedJobs.Id && applied.AppliedJobs.CddID == cddid)
                {
                    btnApply.Enabled = false;
                    btnApply.BackColor = Color.Gray;
                    break;
                }
            }
        }
        public void GetDataFromDB()
        {
            List<Dictionary<string, object>> keyValueJobDetails = canDAO.GetSelectedJobDetails(jobid);
            foreach (var item in keyValueJobDetails)
            {
                lblJobId.Text = jobid.ToString();
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
                else lblStatus.Text = "Applying";

                companyName = (string)item["CompanyName"];

                // Khai báo các lable để add thông tin vào
                // Description infomation
                lblDescriptionTitle = new Label();
                this.lblDescriptionTitle.Size = new System.Drawing.Size(300, 20);
                this.lblDescriptionTitle.TabIndex = 1;
                this.lblDescriptionTitle.Text = "MÔ TẢ CÔNG VIỆC";
                this.lblDescriptionTitle.Font = new Font("Arial", 10, FontStyle.Bold);
                flpnRecruitment.Controls.Add(lblDescriptionTitle);
                lblDescription = new Label();
                this.lblDescription.Size = new System.Drawing.Size(300, 30);
                this.lblDescription.AutoSize = false;
                this.lblDescription.TabIndex = 2;
                this.lblDescription.Text = (string)item["JobDecription"];
                this.lblDescription.Font = new Font("Arial", 9, FontStyle.Regular);
                flpnRecruitment.Controls.Add(lblDescription);
                // WorkingDurable information
                lblWorkingDurationTitle = new Label();
                this.lblWorkingDurationTitle.Size = new System.Drawing.Size(300, 20);
                this.lblWorkingDurationTitle.TabIndex = 3;
                this.lblWorkingDurationTitle.Text = "THỜI GIAN LÀM VIỆC";
                this.lblWorkingDurationTitle.Font = new Font("Arial", 10, FontStyle.Bold);
                flpnRecruitment.Controls.Add(lblWorkingDurationTitle);
                lblWorkingDuration = new Label();
                this.lblWorkingDuration.Size = new System.Drawing.Size(300, 30);
                this.lblWorkingDuration.AutoSize = false;
                this.lblWorkingDuration.TabIndex = 4;
                this.lblWorkingDuration.Text = (string)item["WorkDuration"];
                this.lblWorkingDuration.Font = new Font("Arial", 9, FontStyle.Regular);
                flpnRecruitment.Controls.Add(lblWorkingDuration);
                // Request candidate
                lblRequestCddTitle = new Label();
                this.lblRequestCddTitle.Size = new System.Drawing.Size(300, 20);
                this.lblRequestCddTitle.TabIndex = 5;
                this.lblRequestCddTitle.Text = "YÊU CẦU ỨNG VIÊN";
                this.lblRequestCddTitle.Font = new Font("Arial", 10, FontStyle.Bold);
                flpnRecruitment.Controls.Add(lblRequestCddTitle);
                lblRequestCdd = new Label();
                this.lblRequestCdd.Size = new System.Drawing.Size(300, 30);
                this.lblRequestCdd.AutoSize = false;
                this.lblRequestCdd.TabIndex = 6;
                this.lblRequestCdd.Text = (string)item["RequestCdd"];
                this.lblRequestCdd.Font = new Font("Arial", 9, FontStyle.Regular);
                flpnRecruitment.Controls.Add(lblRequestCdd);
                // Benefit
                lblBenifitTitle = new Label();
                this.lblBenifitTitle.Size = new System.Drawing.Size(300, 20);
                this.lblBenifitTitle.TabIndex = 7;
                this.lblBenifitTitle.Text = "NHỮNG PHÚC LỢI";
                this.lblBenifitTitle.Font = new Font("Arial", 10, FontStyle.Bold);
                flpnRecruitment.Controls.Add(lblBenifitTitle);
                lblBenifit = new Label();
                this.lblBenifit.Size = new System.Drawing.Size(300, 30);
                this.lblBenifit.AutoSize = false;
                this.lblBenifit.TabIndex = 8;
                this.lblBenifit.Text = (string)item["Benefit"];
                this.lblBenifit.Font = new Font("Arial", 9, FontStyle.Regular);
                flpnRecruitment.Controls.Add(lblBenifit);
                // Recruit
                lblAddress_Recruit = new Label();
                this.lblAddress_Recruit.Size = new System.Drawing.Size(300, 20);
                this.lblAddress_Recruit.TabIndex = 9;
                this.lblAddress_Recruit.Text = "ĐỊA ĐIỂM LÀM VIỆC";
                this.lblAddress_Recruit.Font = new Font("Arial", 10, FontStyle.Bold);
                flpnRecruitment.Controls.Add(lblAddress_Recruit);

                lblAddress_RecruitTitle = new Label();
                this.lblAddress_RecruitTitle.Size = new System.Drawing.Size(300, 30);
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

        private void btn_SelectCV_Click (object sender, ButtonClickEventArgs e)
        {
            CV cv = canDAO.GetAvailableCVByCandidateID(e.Cv.ID, cddid);
            if (cv != null)
            {
                if (canDAO.SaveResumeToDatabase(cv, jobid))
                {
                    canDAO.AddAppliedJob(jobid, cddid);
                    btnApply.Enabled = false;
                    btnApply.BackColor = Color.Gray;
                }
            }
            else
            {
                MessageBox.Show("CV chưa được tạo sẵn. Hãy tạo sẵn (đăng ký) CV trước khi ứng tuyển");
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            FCandidate_ListCVOfCandidate lstCV = new FCandidate_ListCVOfCandidate(cddid);
            lstCV.SelectCV_Click += btn_SelectCV_Click;
            lstCV.ShowDialog();
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            canDAO.AddSavedJob(jobid, cddid);
        }
    }
}
