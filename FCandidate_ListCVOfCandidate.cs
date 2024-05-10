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


        public void LoadCvs()
        {
            List<UC_DescribesCV> lstItems = canDAO.GetListDescribesCV(cddid);
            flp_ContainsCV.Controls.Clear();
            foreach (var item in lstItems)
            {
                item.Remove_DescribeCV += btn_RemoveDescibesCV_Click;
                item.Describe_Click += btn_Describe_Click;
                item.Select_Click += btn_Select_Click;
                flp_ContainsCV.Controls.Add(item);
            }
        }
        private void btn_Describe_Click(object sender, ButtonClickEventArgs e)
        {
            
            FCandidate_CreateCV create = new FCandidate_CreateCV(cddid, "Read", e.Cv);
            create.ShowDialog();
        }

        private void btn_RemoveDescibesCV_Click(object sender, ButtonClickEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn xóa CV hiện tại?", "Xóa CV", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                canDAO.RemoveCVValid(e.Cv.ID);
                LoadCvs();
            }
        }
        public event EventHandler<ButtonClickEventArgs> SelectCV_Click;
        private void btn_Select_Click(object sender, ButtonClickEventArgs e)
        {
            this.Close();
            SelectCV_Click?.Invoke(this, new ButtonClickEventArgs(e.Cv));
        }

        public void SetEmpty()
        {
            Panel panel = new Panel();

            if (canDAO.CheckCandidateExistsInDatabase(cddid))
            {
                UC_Empty empty = new UC_Empty();
                flp_ContainsCV.Controls.Clear();
                flp_ContainsCV.Controls.Add(empty);
            }
        }

        private void FCandidate_ListCVOfCandidate_Load(object sender, EventArgs e)
        {
            LoadCvs();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            FCandidate_CreateCV createCV = new FCandidate_CreateCV(cddid, "Write", null);
            createCV.ShowDialog();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadCvs(); 
        }
    }
}
