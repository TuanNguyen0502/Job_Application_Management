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
using System.Data.SqlClient;

namespace Job_Application_Management
{
    public partial class FCandidate_SavedJobs : KryptonForm
    {
        CandidateDAO canDAO = new CandidateDAO();
        private string cddID;
        public FCandidate_SavedJobs(string cddID)
        {
            InitializeComponent();
            this.cddID=cddID;
        }
        public FCandidate_SavedJobs()
        {
            InitializeComponent();
        }
        public void LoadSavedJobs()
        {
            List<UC_JobsSaved> saveds = canDAO.GetSavedJobsFromDB(cddID);
            if (flpStoreUC.Controls.Count > 0)
            {
                flpStoreUC.Controls.Clear();
            }
            foreach (var saved in saveds)
            {
                flpStoreUC.Controls.Add(saved);
                saved.ButtonAddClick += savedJobsButtonApply_Click;
                saved.ButtonRusbishClick += savedJobsButtonRusbish_Click;
            }
        }
        public bool CheckEmptySavedJobs()
        {
            int count = canDAO.CountJobSaved(cddID);
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
            rdb_Tallest.Enabled = state;
        }
        private void FCandidate_SavedJobs_Load(object sender, EventArgs e)
        {
            if (CheckEmptySavedJobs())
            {
                UC_Empty empty = new UC_Empty();
                empty.FindJobNowClick += findJobNow_Click;
                flpStoreUC.Controls.Add(empty);
                PerformRadioButton(false);
            }
            else
            {
                PerformRadioButton(true);
                LoadSavedJobs();
                rdb_Nearly.Checked = true;
            }
        }
        private void savedJobsButtonApply_Click(object sender, ButtonClickEventArgs e)
        {
            
        }
        private void savedJobsButtonRusbish_Click(object sender, ButtonClickEventArgs e)
        {
            canDAO.RemoveSavedJobsFromDB(e.CddID);
            List<UC_CandidateMain> jobItems = canDAO.GetJobsFromDB(cddID);
            foreach (var jobItem in jobItems)
            {
                    List<UC_JobsSaved> jobSaveds = canDAO.GetSavedJobsFromDB(cddID);
                    foreach (var jobSaved in jobSaveds)
                    {
                        if (jobItem._Job.Id != jobSaved.SavedJob.Id)
                            continue;
                    }
                jobItem.Enabled = true;
            }
            LoadSavedJobs();
        }

        private void rdb_Nearly_CheckedChanged(object sender, EventArgs e)
        {
            List<UC_JobsSaved> uC_JobsSaveds = canDAO.GetSavedJobsFromDB(cddID);
            uC_JobsSaveds.Sort((uc1,uc2)=> uc2.SavedJob.TimeSaved.CompareTo(uc1.SavedJob.TimeSaved));
            if (flpStoreUC.Controls.Count > 0)
            {
                flpStoreUC.Controls.Clear();
            }
            foreach (var saved in uC_JobsSaveds)
            {
                flpStoreUC.Controls.Add(saved);
                saved.ButtonAddClick += savedJobsButtonApply_Click;
                saved.ButtonRusbishClick += savedJobsButtonRusbish_Click;
            }
        }

        private void rdb_Lately_CheckedChanged(object sender, EventArgs e)
        {
            List<UC_JobsSaved> uC_JobsSaveds = canDAO.GetSavedJobsFromDB(cddID);
            uC_JobsSaveds.Sort((uc1, uc2) => uc1.SavedJob.PostTime.CompareTo(uc2.SavedJob.PostTime));
            if (flpStoreUC.Controls.Count > 0)
            {
                flpStoreUC.Controls.Clear();
            }
            foreach (var saved in uC_JobsSaveds)
            {
                flpStoreUC.Controls.Add(saved);
                saved.ButtonAddClick += savedJobsButtonApply_Click;
                saved.ButtonRusbishClick += savedJobsButtonRusbish_Click;
            }
        }

        private void rdb_Tallest_CheckedChanged(object sender, EventArgs e)
        {
            List<UC_JobsSaved> uC_JobsSaveds = canDAO.GetSavedJobsFromDB(cddID);
            uC_JobsSaveds.Sort((uc1, uc2) => uc2.SavedJob.Salary.CompareTo(uc1.SavedJob.Salary));
            if (flpStoreUC.Controls.Count > 0)
            {
                flpStoreUC.Controls.Clear();
            }
            foreach (var saved in uC_JobsSaveds)
            {
                flpStoreUC.Controls.Add(saved);
                saved.ButtonAddClick += savedJobsButtonApply_Click;
                saved.ButtonRusbishClick += savedJobsButtonRusbish_Click;
            }
        }
    }
}
