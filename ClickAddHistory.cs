using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application_Management
{
    public class ClickAddHistory
    {
        public string CddID { get;}
        public string CompanyName { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public ClickAddHistory(string name, string companyName, DateTime startDate, DateTime endDate)
        {
            CddID=name;
            CompanyName=companyName;
            StartDate=startDate;
            EndDate=endDate;
        }
        public bool CheckNull()
        {
            if (CddID == null || CompanyName == null || StartDate == null || EndDate == null)
            {
                return true;
            }
            return false;
        }
    }
}
