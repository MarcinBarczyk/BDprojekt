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
        //wkrótce niepotrzebne:
        public static string path_login = @"C:\Users\Rudini\source\repos\Projekt_BD\BD\BD\loginy.txt";
        public static string path_pass = @"C:\Users\Rudini\source\repos\Projekt_BD\BD\BD\hasla.txt";
        //public static string path_login = @"C:\Users\asus\source\repos\BDprojekt\BD\BD\loginy.txt";
        //public static string path_pass = @"C:\Users\asus\source\repos\BDprojekt\BD\BD\hasla.txt";
        //public static string path_login = @"C:\Users\Marcin\source\repos\BDprojekt\BD\BD\loginy.txt";
        //public static string path_login = @"C:\Users\Marcin\source\repos\BDprojekt\BD\BD\hasla.txt";
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
