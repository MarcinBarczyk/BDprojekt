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


namespace BD
{
   
    public partial class nowy_uzytkownik_window : Form
    {
        private string connectionString = "Data Source=DESKTOP-CL91JDT\\SQLEXPRESS;Initial Catalog=AdministracjaBudynkami;Integrated Security=True";
        string pathLoginy = @"C:\Users\asus\source\repos\BDprojekt\BD\BD\loginy.txt";
        string pathhasla = @"C:\Users\asus\source\repos\BDprojekt\BD\BD\hasla.txt";
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

            //----------------------------dodawanie użytkownika do bazy---------------------------------------//
            //ale trzeba przerobić. ponieważ żeby się zgadzało najpierw trzeba wypełnić wynajem poźniej najemce i na koniec użytkownika
            // także zrobić przy oknie do wynajmu i najmcy . I przy najemcy wpisywać od razu do użytkownika i powinno być git :)
            String imie, nazwisko, typ;
            imie = nowy_imie.Text;
            nazwisko = nowy_nazwisko.Text;
            int id_naje;
            id_naje = Convert.ToInt32(nowy_id.Text);
            typ = String.Empty;
            if (typy_uzytkownika.CheckedItems.Count == 1)
            {
                foreach (object itemchecked in typy_uzytkownika.CheckedItems)
                {
                    typ = itemchecked.ToString();
                }
                String SQL = "INSERT INTO użytkownik (id_najemca, typ_użytkownika, imię, nazwisko) VALUES (@id, @typ, @imie, @nazwisko)";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.Parameters.AddWithValue("@id", id_naje);
                cmd.Parameters.AddWithValue("@typ",typ);
                cmd.Parameters.AddWithValue("@imie", imie);
                cmd.Parameters.AddWithValue("@nazwisko", nazwisko);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //----------------------------------------------------------------------------------------------//
        }

        private void nowy_uzytkownik_window_Load(object sender, EventArgs e)
        {
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
    }
}
