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
    public partial class FResume : KryptonForm
    {
        private string jobID;
        private string cddID;
        public FResume(string jobID, string cddID)
        {
            this.jobID = jobID;
            this.cddID = cddID;
            InitializeComponent();
            uC_Resume1.JobID = jobID;
            uC_Resume1.CddID = cddID;
        }
        public FResume()
        {
            InitializeComponent();
        }
    }
}
