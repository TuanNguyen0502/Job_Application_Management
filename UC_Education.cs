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
        public Guna2TextBox TextBox_University { get => textBox_University; set => textBox_University = value;  }
        public Guna2TextBox TextBox_Major { get => textBox_Major; set => textBox_Major = value; }
        public Guna2TextBox TextBox_GPA { get => textBox_GPA; set => textBox_GPA = value; }
        public Guna2DateTimePicker DateTimePicker_UniversityStartDate { get => dateTimePicker_UniversityStartDate; set => dateTimePicker_UniversityStartDate = value; }
        public Guna2DateTimePicker DateTimePicker_UniversityEndDate { get => dateTimePicker_UniversityEndDate; set => dateTimePicker_UniversityEndDate = value; }
    }
}
