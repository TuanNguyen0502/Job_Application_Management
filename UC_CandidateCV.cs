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
    public partial class UC_CandidateCV : UserControl
    {
        public KryptonButton Button_detail { get => button_detail; set => button_detail = value; }
        public KryptonButton Button_delete { get => button_delete; set => button_delete = value; }

        public UC_CandidateCV()
        {
            InitializeComponent();
        }
    }
}
