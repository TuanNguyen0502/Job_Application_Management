using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application_Management
{
    public class CandidateProfile : CV
    {
        private DateTime postDate;
        public CandidateProfile(string cddID, string objective, string universityName, string major, string gpa, string companyName, string workPlace, string certificationName, DateTime postDate, string cddName) : base(cddID, objective, universityName, major, gpa, companyName, workPlace, certificationName, cddName)
        {
            this.postDate = postDate;
        }
        public CandidateProfile() { }
        public DateTime PostDate
        {
            get { return postDate; }
            set { postDate = value; }
        }
    }
}
