﻿using System;
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
using System.Threading;

namespace BD
{
        
    public partial class Form1 : Form
    {
        public static int id_user; //do innego okna id użytkownika

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        Thread thr;

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
            textBox_haslo.MaxLength = 15;
            
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string my_login = textBox_login.Text;
            string hasło = textBox_haslo.Text;
            bool logged = false;

            con.Open();
            com.Connection = con;
            com.CommandText = "select z.hasło, u.typ_użytkownika from zaloguj z join użytkownik u on z.id_użytkownika = u.id_użytkownika where z.login='" + my_login + "'";
            using (SqlDataReader rdr = com.ExecuteReader())
            {
                while (rdr.Read())
                {
                    string db_hash_pass = rdr[0].ToString();
                    string db_user_type = rdr[1].ToString();

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
                        //flagi użytkowników do identyfikacji tożsamości
                        bool loginAdm = false;
                        bool loginKon = false;
                        bool loginUsr = false;
                        if (db_user_type.Contains("Administrator"))
                        {
                            loginAdm = true;
                        }
                        else if(db_user_type.Contains("Konserwator"))
                        {
                            loginKon = true;
                        }
                        else
                        {
                            loginUsr = true;
                        }
                        //sprawdzenie hashy haseł
                        if ((loginAdm == true) && (hash_pass == db_hash_pass))
                        {
                            MessageBox.Show("Zalogowano jako Administrator", "System.Info");
                            admin_window okno_admin = new admin_window();
                            okno_admin.Show();
                            logged = true;
                            break;
                        }
                        else if ((loginAdm == true) && (hash_pass != db_hash_pass))
                        {
                            MessageBox.Show("Podano błędne hasło dla użytkownika admin", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else if ((loginKon == true) && (hash_pass == db_hash_pass))
                        {
                            MessageBox.Show("Zalogowano jako Konserwator", "System.Info");
                            konserwator_window okno_kons = new konserwator_window();
                            okno_kons.Show();
                            logged = true;
                            break;
                        }
                        else if ((loginKon == true) && (hash_pass != db_hash_pass))
                        {
                            MessageBox.Show("Podano błędne hasło lub login dla użytkownika", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else if ((loginUsr == true) && (hash_pass == db_hash_pass))
                        {
                            MessageBox.Show("Zalogowano jako Użytkownik", "System.Info");
                            user_window okno_user = new user_window();
                            okno_user.Show();
                            logged = true;
                            break;
                        }
                        else if ((loginUsr == true) && (hash_pass != db_hash_pass))
                        {
                            MessageBox.Show("Podano błędne hasło lub login dla użytkownika", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else if ((db_hash_pass == " ")||(db_user_type == ""))
                            MessageBox.Show("Podano błędne dane logowania", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        
                    }
                }
            }
            con.Close();
            if (logged == true)
                Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
