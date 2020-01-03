using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

using GlobalVariables;
using System.Security.Cryptography;

namespace BD
{
        
    public partial class Form1 : Form
    {
        public static int id_user; //do innego okna id użytkownika
        bool login = false;
        bool loginAdmin = false;
        bool loginKons = false;
        bool password = false;
        int counterLogin;

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();

        //int counterLogin;

        //string pathLoginy = GlobalVar.path_login;
        //string pathhasla = GlobalVar.path_pass;
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = GlobalVar.con_str;
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
            string my_login = textBox_login.Text;
            string hasło = textBox_haslo.Text;

            con.Open();
            com.Connection = con;
            com.CommandText = "select hasło from zaloguj where login='" + my_login + "'";
            using (SqlDataReader rdr = com.ExecuteReader())
            {
                while (rdr.Read())
                {
                    string db_hash_pass = rdr[0].ToString();
                    //----------------------------hash hasła---------------------------------------//
                    using (SHA256 sha256Hash = SHA256.Create())
                    {
                        byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(hasło));

                        StringBuilder builder = new StringBuilder();
                        for (int i = 0; i < bytes.Length; i++)
                        {
                            builder.Append(bytes[i].ToString("x2"));
                        }
                        string hash_pass = builder.ToString();
                        //----------------------------------------------------------------------------------------------//

                        if ((my_login == "admin") && (hash_pass == db_hash_pass))
                        {
                            MessageBox.Show("zalogowany admin");
                            admin_window okno_admin = new admin_window();
                            okno_admin.Show();
                        }
                    }
                }


                /*
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
                */

            }

            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
