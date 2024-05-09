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
    public partial class FCandidate_ListCVOfCandidate : Form
    {
        CandidateDAO canDAO = new CandidateDAO();
        private string cddid;
        public FCandidate_ListCVOfCandidate(string cddid)
        {
            InitializeComponent();
            this.cddid=cddid;
        }


        public void GetCVOfCandidateByCddID()
        {
            List<UC_DescribesCV> lstItems = canDAO.GetListDescribesCV(cddid);
            flp_ContainsCV.Controls.Clear();
            foreach (var item in lstItems)
            {
                flp_ContainsCV.Controls.Add(item);
            }
        }

        private void FCandidate_ListCVOfCandidate_Load(object sender, EventArgs e)
        {
            GetCVOfCandidateByCddID();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            FCandidate_CreateCV createCV = new FCandidate_CreateCV(cddid);
            createCV.ShowDialog();
        }
    }
}
