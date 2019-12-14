using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class Form1 : Form
    {
        bool login = false;
        bool loginAdmin = false;
        bool loginKons = false;
        bool password = false;
        int counterLogin;
        //string pathLoginy = @"C:\Users\asus\source\repos\BDprojekt\BD\BD\loginy.txt";
        //string pathhasla = @"C:\Users\asus\source\repos\BDprojekt\BD\BD\hasla.txt";
        string pathLoginy = @"C:\Users\Marcin\source\repos\BDprojekt\BD\BD\loginy.txt";
        string pathhasla = @"C:\Users\Marcin\source\repos\BDprojekt\BD\BD\hasla.txt";
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox_haslo_TextChanged(object sender, EventArgs e)
        {
            textBox_haslo.PasswordChar = '*';
            textBox_haslo.MaxLength = 10;
            
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            String loginOkno;
            String loginPlik;
            String line;
            int counter = 0;

            loginOkno = textBox_login.Text;

            System.IO.StreamReader file = new System.IO.StreamReader(pathLoginy);
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                loginPlik = line;
                if ((loginOkno == loginPlik) && (loginPlik == "admin"))
                {
                    loginAdmin = true;
                    break;
                }
                else if ((loginOkno == loginPlik) && (loginPlik == "konserwator"))
                {
                    loginKons = true;
                    break;
                }
                else if (loginOkno == loginPlik)
                {
                    login = true;
                    break;
                }
                counter++;
            }
            counterLogin = counter;
            file.Close();

            counter = 0;
            String PasswordOkno;
            String PasswordPlik;
            String linehaslo;
            PasswordOkno = textBox_haslo.Text.ToString();
            System.IO.StreamReader filehasla = new System.IO.StreamReader(pathhasla);
            while ((linehaslo = filehasla.ReadLine()) != null)
            {
                if (counter == counterLogin)
                {
                    System.Console.WriteLine(linehaslo);
                    PasswordPlik = linehaslo;
                    if ((PasswordOkno == PasswordPlik))
                    {
                        password = true;
                    }

                }
                counter++;
            }
            filehasla.Close();


            if ((loginAdmin == true) && (password == true))
            {
                MessageBox.Show("zalogowany admin");
                admin_window okno_admin = new admin_window();
                okno_admin.Show();
                login = false;
                loginAdmin = false;
                loginKons = false;
                password = false;

            }
            else if ((loginKons == true) && (password == true))
            {
                //trzeba by wychwycić jaki konserwator do pozniejszych zadan//chyba ze przyjmiemy ze jest jeden
                MessageBox.Show("zalogowany konserwator");
                konserwator_window okno_kons = new konserwator_window();
                okno_kons.Show();
                login = false;
                loginAdmin = false;
                loginKons = false;
                password = false;
            }
            else if ((login == true) && (password == true))
            {
                MessageBox.Show("zalogowany");
                user_window okno_user = new user_window();
                okno_user.Show();
                login = false;
                loginAdmin = false;
                loginKons = false;
                password = false;
                //zwykły użytkownik
                //dodać błędne hasło lub login
            }
            
            else
            {
                MessageBox.Show("błędne dane, proszę wpisać ponownie");
                login = false;
                loginAdmin = false;
                loginKons = false;
                password = false;
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
