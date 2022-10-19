using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using business_application.DL;

namespace business_application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Alumni_DL.Read_file();
            Muser_DL.Read_user_file();
            Admin_DL.Read_file();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Candidate_main_menu());
        }
    }
}
