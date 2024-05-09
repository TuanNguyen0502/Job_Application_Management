using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application_Management
{
    public class FavoriteCV
    {
        private DateTime timeSaved;
        private string empID;
        private int cvID;

        public FavoriteCV(DateTime timeSaved, string empID, int cvID)
        {
            TimeSaved = timeSaved;
            EmpID = empID;
            CvID = cvID;
        }

        public DateTime TimeSaved { get => timeSaved; set => timeSaved = value; }
        public string EmpID { get => empID; set => empID = value; }
        public int CvID { get => cvID; set => cvID = value; }
    }
}
