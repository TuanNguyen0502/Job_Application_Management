using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application_Management
{
    public class SavedJobs : Job
    {
        private int savedJobID;
        private DateTime timesaved;
        public SavedJobs() { }
        public int SavedJobID
        {
            get { return savedJobID; }
            set { savedJobID = value; }
        }
        public DateTime TimeSaved
        {
            get { return timesaved; }
            set { timesaved = value; }
        }
    }
}
