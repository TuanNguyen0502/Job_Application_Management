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
using Guna.UI2.WinForms;

namespace Job_Application_Management
{
    public partial class FResume : Form
    {
        private string role;
        private string empID;
        private int jobID;
        private string cddID;
        private EmployerDAO employerDAO = new EmployerDAO();

        public FResume(string empID, int jobID, string cddID, string role, int cvID)
        {
            this.empID = empID;
            this.jobID = jobID;
            this.cddID = cddID;
            this.role = role;
            InitializeComponent();
            uC_CV1.Role = role;
            uC_CV1.EmpID = empID;
            uC_CV1.JobID = jobID;
            uC_CV1.CddID = cddID;
            uC_CV1.CvID = cvID;
            uC_CV1.Button_Approve.Click += button_Approve_Click;
            uC_CV1.Button_Refuse.Click += button_Refuse_Click;
            uC_CV1.InviteCandidate += button_Invite_Click;
        }

        public FResume()
        {
            InitializeComponent();
        }

        private void button_Approve_Click(object sender, EventArgs e)
        {
            uC_CV1.Resume.Status = "Approved";
            uC_CV1.Label_Status.Text = uC_CV1.Resume.Status;
            employerDAO.UpdateResume(uC_CV1.Resume);
            FEmployer_Interview fEmployer_Interview = new FEmployer_Interview(empID, cddID, jobID);
            fEmployer_Interview.ShowDialog();
            this.DialogResult = DialogResult.OK;
        }

        private void button_Refuse_Click(object sender, EventArgs e)
        {
            uC_CV1.Resume.Status = "Applying";
            uC_CV1.Label_Status.Text = uC_CV1.Resume.Status;
            employerDAO.UpdateResume(uC_CV1.Resume);
            this.DialogResult = DialogResult.OK;
        }

        private void button_Invite_Click(object sender, ButtonInviteCandidate e)
        {
            FEmployer_Interview fEmployer_Interview = new FEmployer_Interview(e.EmpID, e.CddID, e.JobName);
            fEmployer_Interview.ShowDialog();
        }
    }
}
