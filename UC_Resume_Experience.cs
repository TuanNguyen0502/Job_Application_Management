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
    public partial class UC_Resume_Experience : UserControl
    {
        public UC_Resume_Experience()
        {
            InitializeComponent();
        }
        public System.Windows.Forms.Label Label1
        {
            get { return label1; }
        }
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_Place
        {
            get { return textBox_Place; }
        }
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_Compay
        {
            get { return textBox_Compay; }
        }
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_JobID
        {
            get { return textBox_JobID; }
        }
        public ComponentFactory.Krypton.Toolkit.KryptonRichTextBox RichTextBox_JobDetail
        {
            get { return richTextBox_JobDetail; }
        }
    }
}
