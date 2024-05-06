using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public class SavedJobs : Job
    {
        private int savedJobID;
        private DateTime timesaved;
        private string cddid;
        public SavedJobs() { }
        public int SavedJobID
        {
            get { return savedJobID; }
            set
            {
                if (value < 0)
                    MessageBox.Show("Mã công việc đã lưu chưa được chỉ định");
                else
                    savedJobID = value;
            }
        }
        public DateTime TimeSaved
        {
            get { return timesaved; }
            set
            {
                if (value == null || value == DateTime.MinValue)
                    MessageBox.Show("Thời gian lưu công việc chưa được chỉ định");
                else
                    timesaved = value;
            }
        }
        public string CddID
        {
            get { return cddid; }
            set { cddid = value; }
        }
    }
}
