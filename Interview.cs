using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application_Management
{
    public class Interview
    {
        private int id;
        private string empID;
        private string cddID;
        private int jobID;
        private DateTime interviewTime;
        private string note;

        public Interview(string empID, string cddID, int jobID, DateTime interviewTime, string note)
        {
            this.EmpID = empID;
            this.CddID = cddID;
            this.JobID = jobID;
            this.InterviewTime = interviewTime;
            this.Note = note;
        }

        public Interview() { }

        public int Id { get => id; set => id = value; }
        public string EmpID { get => empID; set => empID = value; }
        public string CddID { get => cddID; set => cddID = value; }
        public int JobID { get => jobID; set => jobID = value; }
        public DateTime InterviewTime { get => interviewTime; set => interviewTime = value; }
        public string Note { get => note; set => note = value; }
    }
}
