﻿using Guna.UI2.WinForms;
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
        public FCandidateMain()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            pnl_ContainDetailsJob.BackgroundImage = null;
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_ContainDetailsJob.Controls.Add(childForm);
            pnl_ContainDetailsJob.Tag = childForm;
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
        public void ListJobs()
        {
            List<UC_CandidateMain> jobItems = canDAO.GetJobsFromDB(lblCddID.Text);
            foreach (var jobItem in jobItems)
            {
                if (flp_ContainsJobs.Controls.Count < 0)
                {
                    flp_ContainsJobs.Controls.Clear();
                }
                else
                {
                    flp_ContainsJobs.Controls.Add(jobItem);
                    jobItem.ClickToJob += clickToShowJobDetails_Click;
                }    

            }
        }
        private void clickToShowJobDetails_Click(object sender, ButtonClickEventArgs e)
        {
            FCandidate_SelectedJobDetails selected = new FCandidate_SelectedJobDetails(e.JobID, e.ID);
            OpenChildForm(selected);
        }

        private void btnSearchFor_Click(object sender, EventArgs e)
        {
            if (flp_ContainsJobs.Controls.Count >= 0)
            {
                flp_ContainsJobs.Controls.Clear();
                List<UC_CandidateMain> jobItems = canDAO.GetJobsByKeywords(txt_SearchFor.Text);
                foreach (var jobItem in jobItems)
                {
                    flp_ContainsJobs.Controls.Add(jobItem);
                }
            }
        }

        private void cbb_Address_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Address.SelectedItem.ToString() != "Tất cả tỉnh/TP")
            {
                if (flp_ContainsJobs.Controls.Count > 0)
                {
                    flp_ContainsJobs.Controls.Clear();
                }
                List<UC_CandidateMain> jobItems = canDAO.GetJobsByAddress(cbb_Address.SelectedItem.ToString());
                foreach (var jobItem in jobItems)
                {
                    flp_ContainsJobs.Controls.Add(jobItem);
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

        private void btn_JobsSaved_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FCandidate_SavedJobs());
        }

        private void btn_JobsApplied_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FCandidate_AppliedJobs());
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {

        }

        private void btn_Posting_Click(object sender, EventArgs e)
        {

        }
        
    }
}
