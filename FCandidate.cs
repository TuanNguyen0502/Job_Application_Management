using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Job_Application_Management
{
    public partial class frmCadidate_Main : KryptonForm
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        private string connStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Jobs_Management;Integrated Security=True";
        private string sqlQuery;
        public frmCadidate_Main()
        {
            InitializeComponent();
            InitializeToolTip();
            InitializeDropdownMenu();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        public void frmCandidateMain_Load(object sender, EventArgs e)
        {
            PoppulateItems();
        }
        // Create my Items
        public void PoppulateItems()
        {
            //Initialize populate at here
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                sqlQuery = "SELECT JobName, CompanyName, Salary, WorkAddress FROM Jobs";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UC_CandidateMain item = new UC_CandidateMain();
                        item = new UC_CandidateMain();
                        item.JobName = reader.GetString(0);
                        item.CompanyName1 = reader.GetString(1);
                        item.Salary = reader.GetFloat(2);
                        item.Address = reader.GetString(3);
                        //lstItems[i].Icon = 
                        if (flpScrollPane.Controls.Count < 0)
                        {
                            flpScrollPane.Controls.Clear();
                        }
                        else
                            flpScrollPane.Controls.Add(item);
                    }
                }
                else
                    MessageBox.Show("No rows found");
            }
            /*UC_CandidateMain[] lstItems = new UC_CandidateMain[50];
            int length = lstItems.Length;
            for (int i = 0; i < length; i++)
            {
                lstItems[i] = new UC_CandidateMain();
                lstItems[i].JobName = "Add job name at here";
                lstItems[i].CompanyName1 = "Add company name at here";
                lstItems[i].Salary = 500.9;
                lstItems[i].Address = "Somewhere";
                //lstItems[i].Icon = 
                if (flpScrollPane.Controls.Count < 0)
                {
                    flpScrollPane.Controls.Clear();
                }
                else
                    flpScrollPane.Controls.Add(lstItems[i]);
            }*/
        }
        private void InitializeToolTip()
        {
            ToolTip toolTipMain = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTipMain.AutoPopDelay = 5000;
            toolTipMain.InitialDelay = 1000;
            toolTipMain.ReshowDelay = 500;

            toolTipMain.ShowAlways = true;

            toolTipMain.SetToolTip(this.btnExit, "Thoát");
            toolTipMain.SetToolTip(this.btnSearchJob, "Tìm việc");
            toolTipMain.SetToolTip(this.btnJobApp, "Chuột phải để chọn chức năng");
            toolTipMain.SetToolTip(this.btnCompanies, "Chuột phải để chọn chức năng");
        }
        private void InitializeDropdownMenu()
        {
            // Dropdown menu cho Button JobApp
            ContextMenuStrip cmsButtonJobApp = new ContextMenuStrip();
            // Thêm các mục menu
            ToolStripMenuItem menuItemApplied = new ToolStripMenuItem("Những công việc đã ứng tuyển");
            ToolStripMenuItem menuItemSaved = new ToolStripMenuItem("Những công việc đã lưu");
            // Thêm các mục menu vào ContextMenuStrip
            cmsButtonJobApp.Items.Add(menuItemApplied);
            cmsButtonJobApp.Items.Add(menuItemSaved);
            btnJobApp.ContextMenuStrip = cmsButtonJobApp;

            // Dropdown menu cho Button Companies
            ContextMenuStrip cmsButtonCompanies = new ContextMenuStrip();
            ToolStripMenuItem menuItemListCompanies = new ToolStripMenuItem("Danh sách các công ty");
            ToolStripMenuItem menuItemTopCompanies = new ToolStripMenuItem("Top công ty");
            cmsButtonCompanies.Items.Add(menuItemListCompanies);
            cmsButtonCompanies.Items.Add(menuItemTopCompanies);
            btnCompanies.ContextMenuStrip = cmsButtonCompanies;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btnJobApp_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnJobApp.Height;
            pnlNav.Top = btnJobApp.Top;
            btnJobApp.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btnCompanies_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCompanies.Height;
            pnlNav.Top = btnCompanies.Top;
            btnCompanies.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLogout.Height;
            pnlNav.Top = btnLogout.Top;
            btnLogout.BackColor = Color.FromArgb(224, 224, 224);
            
            Program.MainFormManager.CurrentForm = new FLogin();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSetting.Height;
            pnlNav.Top = btnSetting.Top;
            btnSetting.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(227, 229, 234);
        }

        private void btnJobApp_Leave(object sender, EventArgs e)
        {
            btnJobApp.BackColor = Color.FromArgb(227, 229, 234);
        }

        private void btnCompanies_Leave(object sender, EventArgs e)
        {
            btnCompanies.BackColor = Color.FromArgb(227, 229, 234);
        }

        private void btnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(227, 229, 234);
        }

        private void btnSetting_Leave(object sender, EventArgs e)
        {
            btnSetting.BackColor = Color.FromArgb(227, 229, 234);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
