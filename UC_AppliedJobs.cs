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
    public partial class UC_AppliedJobs : UserControl
    {
        #region Properties
        private string descriptionJob;
        private string comName;
        private DateTime timeSaved;
        private string address;
        private string timeUpdate;
        private int salary;
        private Image icon;
        private string jobId;
        private string id;
        public string DescriptionJob
        {
            get => descriptionJob;
            set { descriptionJob = value; lblDescrption.Text = value; }
        }
        public string ComName
        {
            get => comName;
            set { comName = value; lblComName.Text = $"      {value}"; }
        }
        public DateTime TimeSaved
        {
            get => timeSaved;
            set { timeSaved = value; lblTimeSaved.Text = $"Đã lưu: {value}"; }
        }
        public string Address
        {
            get => address;
            set { address = value; lblAddress.Text = $"{       value}"; }
        }
        public int Salary
        {
            get => salary;
            set { salary = value; lblSalary.Text = $"       {value.ToString()}"; }
        }
        public Image Icon
        {
            get => icon;
            set { icon = value; pictureBox1.Image = value; }
        }
        public string JobID
        {
            get { return jobId; }
            set { jobId = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        #endregion
        public Button BtnRusbish
        {
            get { return btnRusbish; }
        }
        public UC_AppliedJobs()
        {
            InitializeComponent();
        }

        public event EventHandler ButtonAddClick;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ButtonAddClick?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler<ButtonClickEventArgs> ButtonRusbishClick;
        private void btnRusbish_Click(object sender, EventArgs e)
        {
            ButtonRusbishClick?.Invoke(this, new ButtonClickEventArgs(ID,0));
        }

        private void UC_AppliedJobs_Load(object sender, EventArgs e)
        {

        }
    }
}
