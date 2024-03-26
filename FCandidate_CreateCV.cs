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
    public partial class FCandidate_CreateCV : Form
    {
        public FCandidate_CreateCV()
        {
            InitializeComponent();
            SaveCVToDatabase();
        }
        public void SaveCVToDatabase()
        {
            CV cv = new CV(uc_AtFormCreateCV.RichTextBox_CareerObjective, uc_AtFormCreateCV.TextBox_Phone, uc_AtFormCreateCV.TextBox_Email, uc_AtFormCreateCV.TextBox_Address, uc_AtFormCreateCV.RichTextBox_EducationDetail, uc_AtFormCreateCV.TextBox_School, uc_AtFormCreateCV.TextBox_Start, uc_AtFormCreateCV.TextBox_End, uc_AtFormCreateCV.TextBox_Major, uc_AtFormCreateCV.TextBox_Compay, uc_AtFormCreateCV.TextBox_Place, uc_AtFormCreateCV.TextBox_CertificateName, uc_AtFormCreateCV.KryptonDateTimePicker1);
            Console.WriteLine(cv.CareerGoal);
        }
    }
}
