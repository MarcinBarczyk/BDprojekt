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
using System.Configuration;

using GlobalVariables;
using System.Security.Cryptography;


namespace BD
{

    public partial class nowy_uzytkownik_window : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlCommand com2 = new SqlCommand();
        SqlCommand com3 = new SqlCommand();
        SqlDataAdapter ada = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public nowy_uzytkownik_window()
        {
            InitializeComponent();
            con.ConnectionString = GlobalVar.con_str;
        }

        private void add_user_Click(object sender, EventArgs e)
        {
            //Generowanie loginu użytkownika
            string cz1 = imię.Text;
            string cz2 = nazwisko.Text;
            string cz3 = id_użytkownika.Text;
            string login_użytkownika = cz1.Substring(0, 2) + cz2.Substring(0, 2) + cz3;

            login_text.AppendText(login_użytkownika);

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
                    com.CommandText = "insert into użytkownik(id_użytkownika, id_najemca, typ_użytkownika, imię, nazwisko) values('" + id_użytkownika.Text + "','" + id_najemcy.Text + "','" + typy_uzytkownika.Text + "','" + imię.Text + "','" + nazwisko.Text + "')";
                    com.ExecuteNonQuery();
                    con.Close();
                }
                con.Open();
                com2.Connection = con;
                com2.CommandText = "insert into zaloguj(id_użytkownika, login, hasło) values('" + id_użytkownika.Text + "','" + login_użytkownika + "','" + hasło_hash + "')";
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
            // TODO: This line of code loads data into the 'administracjaBudynkamiDataSet.zaloguj' table. You can move, or remove it, as needed.
            this.zalogujTableAdapter.Fill(this.administracjaBudynkamiDataSet.zaloguj);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'administracjaBudynkamiDataSet.użytkownik' . Możesz go przenieść lub usunąć.
            this.użytkownikTableAdapter.Fill(this.administracjaBudynkamiDataSet.użytkownik);


            var items = typy_uzytkownika.Items;
            items.Add("Administrator");
            items.Add("Konserwator");
            //items.Add("Sprzątacz");
            items.Add("Mieszkaniec");

            con.Open();
            com3.Connection = con;
            com3.CommandText = "SELECT u.id_użytkownika, u.id_najemca, u.typ_użytkownika, u.imię, u.nazwisko, z.login FROM dbo.użytkownik u join dbo.zaloguj z on u.id_użytkownika = z.id_użytkownika";
            com3.ExecuteNonQuery();
            ada.SelectCommand = com3;
            ada.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            login_text.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void typy_uzytkownika_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void login_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void hasło_text_TextChanged(object sender, EventArgs e)
        {
            hasło_text.PasswordChar = '*';
            hasło_text.MaxLength = 15;
        }

    }
}
