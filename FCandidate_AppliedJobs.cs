﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Job_Application_Management
{
    public partial class FCandidate_AppliedJobs : KryptonForm
    {
        CandidateDAO canDAO = new CandidateDAO();
        private string cddid;
        public FCandidate_AppliedJobs(string cddid)
        {
            InitializeComponent();
            this.cddid = cddid;
        }
        private void LoadAppliedJobs()
        {
            List<UC_AppliedJobs> applieds = canDAO.GetAppliedJobsFromDB(cddid);
            if (flpStoreUC.Controls.Count > 0)
            {
                flpStoreUC.Controls.Clear();
            }
            foreach (var applied in applieds)
            {
                flpStoreUC.Controls.Add(applied);
                applied.ButtonRusbishClick += appliedJobsButtonRusbish_Click;
            }
        }

        public bool CheckEmptyAppliedJobs()
        {
            int count = canDAO.CountJobApplied(cddid);
            if (count == 0)
                return true;
            return false;
        }
        public event EventHandler FindJobNowAtSavedJobClick;
        public void findJobNow_Click(object sender, EventArgs e)
        {
            FindJobNowAtSavedJobClick?.Invoke(this, new EventArgs());
        }
        public void PerformRadioButton(bool state)
        {
            rdb_Lately.Enabled = state;
            rdb_Nearly.Enabled = state;
            rdb_TallestSalary.Enabled = state;
        }
        private void FCandidate_AppliedJobs_Load(object sender, EventArgs e)
        {
            if (CheckEmptyAppliedJobs())
            {
                UC_Empty empty = new UC_Empty();
                empty.Lbl_Title.Text = "Bạn chưa ứng tuyển công việc nào";
                empty.FindJobNowClick += findJobNow_Click;
                flpStoreUC.Controls.Add(empty);
                PerformRadioButton(false);
            }
            else
            {
                PerformRadioButton(true);
                LoadAppliedJobs();
                rdb_Nearly.Checked = true;
            }
        }
        private void appliedJobsButtonRusbish_Click(object sender, ButtonClickEventArgs e)
        {
            canDAO.RemoveAppliedJobsFromDB(e.CddID);
            LoadAppliedJobs();
        }

        private void rdb_Nearly_CheckedChanged(object sender, EventArgs e)
        {
            List<UC_AppliedJobs> uC_AppliedJobs = canDAO.GetAppliedJobsFromDB(cddid);
            uC_AppliedJobs.Sort((uc1, uc2) => uc2.AppliedJobs.TimeApplied.CompareTo(uc1.AppliedJobs.TimeApplied));
            if (flpStoreUC.Controls.Count > 0)
            {
                flpStoreUC.Controls.Clear();
            }
            foreach (var saved in uC_AppliedJobs)
            {
                flpStoreUC.Controls.Add(saved);
                saved.ButtonRusbishClick += appliedJobsButtonRusbish_Click;
            }
        }

        private void rdb_Lately_CheckedChanged(object sender, EventArgs e)
        {
            List<UC_AppliedJobs> uC_AppliedJobs = canDAO.GetAppliedJobsFromDB(cddid);
            uC_AppliedJobs.Sort((uc1, uc2) => uc2.AppliedJobs.PostTime.CompareTo(uc1.AppliedJobs.PostTime));
            if (flpStoreUC.Controls.Count > 0)
            {
                flpStoreUC.Controls.Clear();
            }
            foreach (var saved in uC_AppliedJobs)
            {
                flpStoreUC.Controls.Add(saved);
                saved.ButtonRusbishClick += appliedJobsButtonRusbish_Click;
            }
        }

        private void rbd_TallestSalary_CheckedChanged(object sender, EventArgs e)
        {
            List<UC_AppliedJobs> uC_AppliedJobs = canDAO.GetAppliedJobsFromDB(cddid);
            uC_AppliedJobs.Sort((uc1, uc2) => uc2.AppliedJobs.Salary.CompareTo(uc1.AppliedJobs.Salary));
            if (flpStoreUC.Controls.Count > 0)
            {
                flpStoreUC.Controls.Clear();
            }
            foreach (var saved in uC_AppliedJobs)
            {
                flpStoreUC.Controls.Add(saved);
                saved.ButtonRusbishClick += appliedJobsButtonRusbish_Click;
            }
        }
    }
}
