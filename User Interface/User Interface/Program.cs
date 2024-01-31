using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Interface.forms;

namespace User_Interface
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new frm_main());
=======
            Application.Run(new frm_icon_firstApear());
>>>>>>> 4c42553b8b58c535e4429cd495b65226f7119174
        }
    }
}
