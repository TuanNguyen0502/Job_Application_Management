using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application_Management
{
    public class AppliedJobs : Job
    {
        private int appliedJobID;
        private DateTime timeApplied;
        public AppliedJobs() { }
        public int AppliedJobID
        {
            get { return appliedJobID; }
            set { appliedJobID = value; }
        }
        public DateTime TimeApplied
        {
            get { return timeApplied; }
            set { timeApplied = value; }
        } 
    }
}
