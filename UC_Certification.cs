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
    public partial class UC_Certification : UserControl
    {
        public UC_Certification()
        {
            InitializeComponent();
        }
        public Guna2TextBox TextBox_Certification { get => textBox_Certification; set => textBox_Certification = value; }
        public Guna2DateTimePicker DateTimePicker_Certification { get => dateTimePicker_Certification; set => dateTimePicker_Certification = value; }
    }
}
