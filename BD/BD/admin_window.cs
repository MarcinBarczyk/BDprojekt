using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BD
{
    public partial class admin_window : Form
    {
        private string connectionString = "Data Source=157.158.161.178,1433;Initial Catalog=AdministracjaBudynkami;Persist Security Info=True;User ID=admin007;Password=qwerty123";
        public admin_window()
        {
            InitializeComponent();
        }

        private void Budynki_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Budynek_dane_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dodanie bazy danych zeby to jakos obsluzyc
        }

        private void Zgloszenia_Click(object sender, EventArgs e)
        {
            podwykonawca_window okno_podw = new podwykonawca_window();
            okno_podw.Show();
            //po wybraniu z checkboxa zgłoszonych usterek i remontow dodaje je do listy "w realizacji" oraz pokazuje okno gdzie mozna uzupelnic jaka firma bedzie sie tym zajmowac
        }

        private void Realizacja_Click(object sender, EventArgs e)
        {
            //po wybraniu z checkboxa realizowanych usterek i remontów usuwa je i kończy ich żywot
        }

        private void Data_Click(object sender, EventArgs e)
        {
            //po wybraniu dat pokazuje zyski z tych okresow
        }

        private void Usterki_remonty_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pobranie z bazy zgloszonych usterek i remontow
        }

        private void W_realizacji_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dodawane są po wybraniu z wyższego checkboxa
        }

        private void dodawanie_Click(object sender, EventArgs e)
        {
            if (dodawanie_uzytkownika.Checked)
            {
                nowy_uzytkownik_window okno_add = new nowy_uzytkownik_window();
                okno_add.Show();
            }
            if (dodawanie_umowy.Checked)
            {
                nowe_umowy_window okno_umo = new nowe_umowy_window();
                okno_umo.Show();
            }
            if (dodawanie_budynku.Checked)
            {
                nowe_budynki_window okno_budo = new nowe_budynki_window();
                okno_budo.Show();
            }
            if (dodawanie_lokali.Checked)
            {
                nowe_lokale_window okno_lokal = new nowe_lokale_window();
                okno_lokal.Show();
            }
        }

        private void dodawanie_uzytkownika_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dodawanie_umowy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void admin_window_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'administracjaBudynkamiDataSet1.budynek' . Możesz go przenieść lub usunąć.
            this.budynekTableAdapter.Fill(this.administracjaBudynkamiDataSet1.budynek);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'administracjaBudynkamiDataSet.zgłoszenie' . Możesz go przenieść lub usunąć.
            this.zgłoszenieTableAdapter.Fill(this.administracjaBudynkamiDataSet.zgłoszenie);

        }

        private void potwierdzenie_realizacji_Click(object sender, EventArgs e)
        {
            podwykonawca_window okno_podw = new podwykonawca_window();
            okno_podw.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT id_budynku FROM budynek";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader r = null;
            con.Open();
            r = cmd.ExecuteReader();
            while(r.Read())
            {
                listBox1.Items.Add(r["id_budynku"]);
            }
            con.Close();
        }
    }
}


//nie wiem jak ze zgłaszeniem tego zewnętrznym firmom, trzeba to jeszcze gdzieś jakoś wcisnąć
// i jeszcze jakieś dodawanie tych meldunkow// jakies miejsce gdzie będzie się wpisywać dane i dodawać użytkownika do bazy zeby mogł sie zalogowac itp.
