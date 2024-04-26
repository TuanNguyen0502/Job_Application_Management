using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application_Management
{
    public class ClickInterviews
    {
        public string CddName { get; }
        public string CompanyName { get; }
        public string JobName { get; }
        public DateTime Interview { get; }
        public string Note { get; }
        public ClickInterviews(string cddName, string companyName, string jobName, DateTime interview, string note)
        {
            CddName=cddName;
            CompanyName=companyName;
            JobName=jobName;
            Interview=interview;
            Note=note;
        }
    }
}
