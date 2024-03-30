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

namespace Job_Application_Management
{
    public partial class UC_Resume_Certificate : UserControl
    {
        public UC_Resume_Certificate()
        {
            InitializeComponent();
        }
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DateTimePicker_Start
        {
            get { return dateTimePicker; }
        }

        public KryptonTextBox TextBox_CertificateName
        {
            get { return textBox_CertificateName; }
        }
        public KryptonDateTimePicker KryptonDateTimePicker1
        {
            get { return dateTimePicker; }
        }
    }
}
