using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application_Management
{
    public class ButtonInviteCandidate
    {
        public string CddID { get; }
        public string EmpID { get; }
        public string JobName { get; }
        public ButtonInviteCandidate(string empID, string cddID, string jobName)
        {
            EmpID = empID;
            CddID = cddID;
            JobName = jobName;
        }
    }
}
