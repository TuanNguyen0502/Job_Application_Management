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
    public partial class UC_Resume_Education : UserControl
    {
        public UC_Resume_Education()
        {
            InitializeComponent();
        }

        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DateTimePicker_Start
        {
            get { return dateTimePicker_Start; }
        }

        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DateTimePicker_End
        {
            get { return dateTimePicker_End; }
        }

        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_School
        {
            get { return textBox_School; }
        }
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_Major
        {
            get { return textBox_Major; }
        }
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_Start
        {
            get { return textBox_School; }
        }
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox_End
        {
            get { return textBox_School; }
        }
        public System.Windows.Forms.Label Label1
        {
            get { return label1; }
        }
        public ComponentFactory.Krypton.Toolkit.KryptonRichTextBox RichTextBox_EducationDetail
        {
            get { return richTextBox_EducationDetail; }
        }
    }
}
