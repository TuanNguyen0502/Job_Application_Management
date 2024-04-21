using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            set
            {
                if (value <0)
                    MessageBox.Show("Mã công việc đã ứng viên chưa được chỉ định");
                else
                    appliedJobID = value;
            }
        }
        public DateTime TimeApplied
        {
            get { return timeApplied; }
            set
            {
                if (value == null || value == DateTime.MinValue)
                    MessageBox.Show("Thời gian đã ứng tuyển chưa được chỉ định");
                else
                    timeApplied = value;
            }
        } 
    }
}
