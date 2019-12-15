﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BD
{
   
    public partial class nowy_uzytkownik_window : Form
    {
        string pathLoginy = @"C:\Users\Marcin\source\repos\BDprojekt\BD\BD\loginy.txt";
        string pathhasla = @"C:\Users\Marcin\source\repos\BDprojekt\BD\BD\hasla.txt";
        public nowy_uzytkownik_window()
        {
            InitializeComponent();
        }

        private void new_login_TextChanged(object sender, EventArgs e)
        {
            String line;
            String okno;
            String login_plik;
            System.IO.StreamReader file = new System.IO.StreamReader(pathLoginy);
            okno = new_login.Text;
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                login_plik = line;
                if (okno == login_plik)
                {
                    MessageBox.Show("Podana nazwa już istanieje");
                }
            }
            file.Close();
        }

        private void new_pass_TextChanged(object sender, EventArgs e)
        {
            new_pass.PasswordChar = '*';
            new_pass.MaxLength = 10;
        }

        private void add_user_Click(object sender, EventArgs e)
        {
            String login_okno;
            login_okno = new_login.Text;
            File.AppendAllText(pathLoginy, login_okno + Environment.NewLine);
          

            String haslo_okno;
            haslo_okno = new_pass.Text;
            File.AppendAllText(pathhasla, haslo_okno + Environment.NewLine);
           
        }
    }
}