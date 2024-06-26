﻿using ComponentFactory.Krypton.Toolkit;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public partial class UC_Employer_CandidateResume : UserControl
    {
        private int jobID;
        private string cddID;
        private string empID;
        public Guna2Button Button_detail { get => button_detail; set => button_detail = value; }
        public Label Label_Name { get => label_Name; set => label_Name = value; }
        public Label Label_University { get => label_University; set => label_University = value; }
        public Label Label_Major { get => label_Major; set => label_Major = value; }
        public Label Label_GPA { get => label_GPA; set => label_GPA = value; }
        public string CddID { get => cddID; set => cddID = value; }

        public UC_Employer_CandidateResume(string empID, int jobID)
        {
            InitializeComponent();
            this.empID = empID;
            this.jobID = jobID;
        }

        private void button_detail_Click(object sender, EventArgs e)
        {
            FResume fResume = new FResume(empID, jobID, CddID, "Employer", 0);
            fResume.ShowDialog();
            if (fResume.DialogResult == DialogResult.OK)
            {
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
