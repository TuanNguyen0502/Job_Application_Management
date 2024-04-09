using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application_Management
{
    public class ButtonClickEventArgs : EventArgs
    {
        public string ID { get; }
        public int JobID { get; }
        public ButtonClickEventArgs(string text, int jobid)
        {
            ID = text;
            JobID = jobid;
        }
        
    }
}
