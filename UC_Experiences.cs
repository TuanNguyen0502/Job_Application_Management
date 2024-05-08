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
        public Guna2TextBox TextBox_Company { get => textBox_Company; set => textBox_Company = value; }
        public Guna2TextBox TextBox_Workplace { get => textBox_Workplace; set => textBox_Workplace = value; }
        public RichTextBox RichTextBox_Detail { get => richTextBox_Detail; set => richTextBox_Detail = value; }
        public Guna2DateTimePicker DateTimePicker_CompanyStartDate { get => dateTimePicker_CompanyStartDate; set => dateTimePicker_CompanyStartDate = value; }
        public Guna2DateTimePicker DateTimePicker_CompanyEndDate { get => dateTimePicker_CompanyEndDate; set => dateTimePicker_CompanyEndDate = value; }
    }
}
