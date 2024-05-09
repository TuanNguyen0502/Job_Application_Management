using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public class Interview
    {
        private int id;
        private string empID;
        private string cddID;
        private int jobID;
        private string jobName;
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
        public Interview(string empID, string cddID, string jobName, DateTime interviewTime, string note)
        {
            this.EmpID = empID;
            this.CddID = cddID;
            this.JobID = 0;
            this.JobName = jobName;
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
        public string JobName { get => jobName; set => jobName = value; }

        private bool CheckInterviewTime()
        {
            if (interviewTime == null)
            {
                MessageBox.Show("Interview time cannot be null !", "Empty interview time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (interviewTime.CompareTo(DateTime.Now) < 0)
            {
                MessageBox.Show("Interview time cannot be in the past or today !", "Unaccepted deadline", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool CheckNote()
        {
            if (string.IsNullOrEmpty(note))
            {
                MessageBox.Show("Note can not be empty !", "Empty note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool CheckAllConditions()
        {
            if (CheckInterviewTime() && CheckNote())
            {
                return true;
            }
            return false;
        }
    }
}
