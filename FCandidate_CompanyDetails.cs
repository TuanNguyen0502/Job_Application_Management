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
        private Label lblDescriptionTitle;
        private Label lblBL;
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
                lblDescriptionTitle = new Label();
                this.lblDescriptionTitle.Size = new System.Drawing.Size(300, 30);
                this.AutoSize = false;
                this.lblDescriptionTitle.TabIndex = 1;
                this.lblDescriptionTitle.Text = (string)key["Introduction"];
                this.lblDescriptionTitle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                flp_ContainsIntro.Controls.Add(lblDescriptionTitle);

                lblCompanyName.Text = (string)key["Name"];
                lblAddress.Text = (string)key["Address"];
                lblManager.Text = (string)key["Manager"];

                lblBL = new Label();
                this.lblBL.Size = new System.Drawing.Size(300, 30);
                this.AutoSize = false;
                this.lblBL.TabIndex = 1;
                this.lblBL.Text = (string)key["Introduction"];
                this.lblBL.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                flp_ContainsIntro.Controls.Add(lblBL);

                lblBL.Text = (string)key["BusinessLicense"];
                int numEm = (int)key["NumberOfEmployee"];
                lblNumEmp.Text = numEm.ToString() + " nhân viên";
                int numFol = (int)key["NumberOfFollower"];
                lblNumberFollower.Text = numFol.ToString() + " người theo dõi";
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
