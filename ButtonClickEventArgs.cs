using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application_Management
{
    public class ButtonClickEventArgs : EventArgs
    {
        public string CddID { get; }
        public int JobID { get; }
        public CV Cv { get; }
        public ButtonClickEventArgs(string cddId, int jobid)
        {
            CddID = cddId;
            JobID = jobid;
        }
        public ButtonClickEventArgs(CV cv)
        {
            Cv = cv;
        }
        
    }
}
