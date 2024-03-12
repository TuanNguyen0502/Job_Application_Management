using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public class Program
    {
        private static MainFormManager mainFormManager;

        public static MainFormManager MainFormManager
        {
            get { return mainFormManager; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainFormManager = new MainFormManager();

            // Chỉnh cái bên dưới để mở form đi Hiếu
            // Chỉnh phía sau cái new là được rồi á
            mainFormManager.CurrentForm = new FLogin();
            Application.Run(mainFormManager);
        }
    }
}
