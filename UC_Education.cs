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
    public partial class UC_Education : UserControl
    {
        public UC_Education()
        {
            InitializeComponent();
        }
        public Guna2TextBox TextBox_University { get { return textBox_University; } }
        public Guna2TextBox TextBox_Major { get { return textBox_Major; } }
        public Guna2TextBox TextBox_GPA { get { return textBox_GPA; } }
        public Guna2DateTimePicker DateTimePicker_UniversityStartDate { get { return dateTimePicker_UniversityStartDate; } }
        public Guna2DateTimePicker DateTimePicker_UniversityEndDate { get { return dateTimePicker_UniversityEndDate; } }
    }
}
