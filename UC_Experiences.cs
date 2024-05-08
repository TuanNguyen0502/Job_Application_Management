using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Job_Application_Management
{
    public partial class UC_Experiences : UserControl
    {
        public UC_Experiences()
        {
            InitializeComponent();
        }
        public Guna2TextBox TextBox_Company { get { return textBox_Company; } }
        public Guna2TextBox TextBox_Workplace { get { return textBox_Workplace; } }
        public RichTextBox RichTextBox_Detail { get { return richTextBox_Detail; } }
        public Guna2DateTimePicker DateTimePicker_CompanyStartDate { get { return dateTimePicker_CompanyStartDate; } }
        public Guna2DateTimePicker DateTimePicker_CompanyEndDate { get { return dateTimePicker_CompanyEndDate; } }
    }
}
