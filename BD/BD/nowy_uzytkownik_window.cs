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

        public nowy_uzytkownik_window()
        {
            InitializeComponent();
            con.ConnectionString = GlobalVar.con_str;
        }

        private void add_user_Click(object sender, EventArgs e)
        {
            
            //Generowanie loginu użytkownika
            string string_imie = imię.Text;
            string string_nazwisko = nazwisko.Text;
            string string_id = id_użytkownika.Text;
            UppercaseFirst(string_imie);
            UppercaseFirst(string_nazwisko);
            string login_użytkownika = string_imie.Substring(0, 2) + string_nazwisko.Substring(0, 2) + string_id;
            login_text.AppendText(login_użytkownika);

            //Sprawdzenie czy hasło spełnia warunki mocnego hasła
            string hasło = hasło_text.Text;
            if (hasło_text.Text.Length < 6)
            {
                MessageBox.Show("Hasło jest za krótkie!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                hasło_text.Focus();
            }
            else if(string_imie.Length <3)
            {
                MessageBox.Show("Pole Imię nie zostało uzupełnione poprawnie", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (string_nazwisko.Length < 3)
            {
                MessageBox.Show("Pole Nazwisko nie zostało uzupełnione poprawnie", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (String.IsNullOrEmpty(string_id))
            {
                MessageBox.Show("Pole ID jest puste", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

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
                    try
                    {
                        if (id_najemcy.Text == "")
                        {
                            con.Open();
                            com.Connection = con;
                            com.CommandText = "insert into użytkownik(id_użytkownika, typ_użytkownika, imię, nazwisko) values('" + id_użytkownika.Text + "','" + typy_uzytkownika.Text + "','" + string_imie + "','" + string_nazwisko + "')";
                            com.ExecuteNonQuery();
                            con.Close();
                        }
                        else
                        {
                            con.Open();
                            com.Connection = con;
                            com.CommandText = "insert into użytkownik(id_użytkownika, id_najemca, typ_użytkownika, imię, nazwisko) values('" + id_użytkownika.Text + "','" + id_najemcy.Text + "','" + typy_uzytkownika.Text + "','" + string_imie + "','" + string_nazwisko + "')";
                            com.ExecuteNonQuery();
                            con.Close();
                        }

                        con.Open();
                        com2.Connection = con;
                        com2.CommandText = "insert into zaloguj(id_użytkownika, login, hasło) values('" + id_użytkownika.Text + "','" + login_użytkownika + "','" + hasło_hash + "')";
                        com2.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Nie można stworzyć użytkownika. Najemca o takim ID nie istnieje lub w bazie danych istnieje już użytkownik o tych danych", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    finally
                    {
                        con.Close();
                    }

                }
                //----------------------------------------------------------------------------------------------//

                //------------------------czyszczenie wpisanych wartosci i update tabeli------------------------//


                this.użytkownikTableAdapter.Fill(this.administracjaBudynkamiDataSet.użytkownik);

                SqlDataAdapter ada = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Open();
                com3.Connection = con;
                com3.CommandText = "SELECT u.id_użytkownika, u.id_najemca, u.typ_użytkownika, u.imię, u.nazwisko, z.login FROM dbo.użytkownik u join dbo.zaloguj z on u.id_użytkownika = z.id_użytkownika";
                ada.SelectCommand = com3;
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                imię.Clear();
                nazwisko.Clear();
                id_użytkownika.Clear();
                id_najemcy.Clear();
                hasło_text.Clear();
                //----------------------------------------------------------------------------------------------//

            }

        }

        private void nowy_uzytkownik_window_Load(object sender, EventArgs e)
        {
            // Ten wiersz kodu wczytuje dane do tabeli 'administracjaBudynkamiDataSet.użytkownik' . Możesz go przenieść lub usunąć.
            this.użytkownikTableAdapter.Fill(this.administracjaBudynkamiDataSet.użytkownik);

            // Ten wiersz kodu wczytuje dane do tabeli dataGridView1
            SqlDataAdapter ada = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Open();
            com3.Connection = con;
            com3.CommandText = "SELECT u.id_użytkownika, u.id_najemca, u.typ_użytkownika, u.imię, u.nazwisko, z.login FROM dbo.użytkownik u join dbo.zaloguj z on u.id_użytkownika = z.id_użytkownika";
            ada.SelectCommand = com3;
            ada.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            var items = typy_uzytkownika.Items;
            items.Add("Administrator");
            items.Add("Konserwator");
            items.Add("Mieszkaniec");

            login_text.ReadOnly = true;
            hasło_text.TabIndex = 1;
            id_użytkownika.TabIndex = 2;
            id_najemcy.TabIndex = 3;
            typy_uzytkownika.TabIndex = 4;
            imię.TabIndex = 5;
            nazwisko.TabIndex = 6;

        }

        private void typy_uzytkownika_SelectedIndexChanged(object sender, EventArgs e)
        {

            typy_uzytkownika.SelectionMode = SelectionMode.One;
        }

        private void login_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void hasło_text_TextChanged(object sender, EventArgs e)
        {
            hasło_text.PasswordChar = '*';
            hasło_text.MaxLength = 15;

        }
        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }


    }
}
