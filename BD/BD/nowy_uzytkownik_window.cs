using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

using GlobalVariables;
using System.Security.Cryptography;


namespace BD
{

    public partial class nowy_uzytkownik_window : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlCommand com2 = new SqlCommand();

        string pathLoginy = GlobalVar.path_login;
        string pathhasla = GlobalVar.path_pass;

        public nowy_uzytkownik_window()
        {
            InitializeComponent();
            con.ConnectionString = GlobalVar.con_str;
        }

        private void add_user_Click(object sender, EventArgs e)
        {
            string hasło = hasło_text.Text;

            //----------------------------hash hasła---------------------------------------//
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(hasło));
                //byte[] hasło_hash = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(hasło));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                string hasło_hash = builder.ToString();
                //----------------------------------------------------------------------------------------------//

                //----------------------------dodawanie użytkownika do bazy---------------------------------------//
                if (id_najemcy.Text == "")
                {
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "insert into użytkownik(id_użytkownika, typ_użytkownika, imię, nazwisko) values('" + id_użytkownika.Text + "','" + typy_uzytkownika.Text + "','" + imię.Text + "','" + nazwisko.Text + "')";
                    com.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "insert into użytkownik(id_użytkownika, id_najemca, typ_użytkownika, imię, nazwisko) values('" + id_użytkownika.Text + "','" + id_najemcy + "','" + typy_uzytkownika.Text + "','" + imię.Text + "','" + nazwisko.Text + "')";
                    com.ExecuteNonQuery();
                    con.Close();
                }
                con.Open();
                com2.Connection = con;
                com2.CommandText = "insert into zaloguj(id_użytkownika, login, hasło) values('" + id_użytkownika.Text + "','" + login_text.Text + "','" + hasło_hash + "')";
                com2.ExecuteNonQuery();
                con.Close();
                //----------------------------------------------------------------------------------------------//

                //------------------------czyszczenie wpisanych wartosci i update tabeli------------------------//
                //new_login.Clear();

                this.użytkownikTableAdapter.Fill(this.administracjaBudynkamiDataSet.użytkownik);
                //----------------------------------------------------------------------------------------------//

            }

        }

        private void nowy_uzytkownik_window_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'administracjaBudynkamiDataSet.najemca' . Możesz go przenieść lub usunąć.
            this.najemcaTableAdapter.Fill(this.administracjaBudynkamiDataSet.najemca);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'administracjaBudynkamiDataSet.użytkownik' . Możesz go przenieść lub usunąć.
            this.użytkownikTableAdapter.Fill(this.administracjaBudynkamiDataSet.użytkownik);


            var items = typy_uzytkownika.Items;
            items.Add("Administrator");
            items.Add("Konserwator");
            items.Add("Sprzątacz");
            items.Add("Mieszkaniec");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void typy_uzytkownika_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void login_text_TextChanged(object sender, EventArgs e)
        {
            String line;
            String okno;
            String login_plik;
            System.IO.StreamReader file = new System.IO.StreamReader(pathLoginy);
            okno = login_text.Text;
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

        private void hasło_text_TextChanged(object sender, EventArgs e)
        {
            hasło_text.PasswordChar = '*';
            hasło_text.MaxLength = 10;
        }
    }
}
