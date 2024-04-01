using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public partial class FCandidate_CompanyDetails : Form
    {
        private string companyName;
        CandidateDAO canDAO = new CandidateDAO();
        public FCandidate_CompanyDetails(string companyName)
        {
            InitializeComponent();
            this.companyName = companyName;
            GetCompanyFromDB();
        }
        public void GetCompanyFromDB()
        {
            List<Dictionary<string,object>> key_values = canDAO.GetCompanyFromDB(companyName);
            foreach(var key in key_values)
            {
                lblCompanyName.Text = (string)key["Name"];
                lblAddress.Text = (string)key["Address"];
                lblManager.Text = (string)key["Manager"];
                lblBL.Text = (string)key["BusinessLicense"];
                int numEm = (int)key["NumberOfEmployee"];
                lblNumberEmp.Text = numEm.ToString() + " nhân viên";
                int numFol = (int)key["NumberOfFollower"];
                lblNumberFollower.Text = numFol.ToString() + " người theo dõi";
                lblIntroduction.Text = (string)key["Introduction"];
            }
        }
    }
}
