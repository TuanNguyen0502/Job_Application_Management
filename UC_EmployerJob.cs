using ComponentFactory.Krypton.Toolkit;
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
    public partial class UC_EmployerJob : UserControl
    {
        public Label Label_PostedTime { get => label_PostedTime; set => label_PostedTime = value; }
        public Label Label_JobName { get => label_JobName; set => label_JobName = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public KryptonLabel Label_language { get => label_language; set => label_language = value; }
        public KryptonLabel KryptonLabel2 { get => kryptonLabel2; set => kryptonLabel2 = value; }
        public KryptonButton Button_Post { get => button_Post; set => button_Post = value; }
        public KryptonButton Button_delete { get => button_delete; set => button_delete = value; }
        public UC_EmployerJob()
        {
            InitializeComponent();
        }
    }
}
