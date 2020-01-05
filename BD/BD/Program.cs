using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalVariables
{
    static class GlobalVar
    {
        public static string con_str = "Data Source=RUDY\\SQLEXPRESS;Initial Catalog=AdministracjaBudynkami;Integrated Security=True;";
        //public static string con_str = "Data Source=DESKTOP-CL91JDT\\SQLEXPRESS;Initial Catalog=AdministracjaBudynkami;Integrated Security=True";
    }
}

namespace BD
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
