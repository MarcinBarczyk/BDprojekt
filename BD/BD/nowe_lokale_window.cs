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
    public partial class nowe_lokale_window : Form
    {
        private string connectionString = "Data Source=DESKTOP-CL91JDT\\SQLEXPRESS;Initial Catalog=AdministracjaBudynkami;Integrated Security=True";
        public nowe_lokale_window()
        {
            InitializeComponent();
        }

        private void nowe_lokale_window_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'administracjaBudynkamiDataSet.lokal' . Możesz go przenieść lub usunąć.
            this.lokalTableAdapter.Fill(this.administracjaBudynkamiDataSet.lokal);
        }

        private void dodaj_lokal_Click(object sender, EventArgs e)
        {
            //-----------------dodawanie lokalu po naciśnięciu----------------------------------//
            int id_lok;
            int nr_lok;
            id_lok = ((admin_window.id_bud) * 1000 )+ ((Convert.ToInt32(nr_pietra.Text)) * 100 )+ (Convert.ToInt32(nr_lokalu.Text));
            nr_lok = (Convert.ToInt32(nr_pietra.Text)) * 100 + Convert.ToInt32(nr_lokalu.Text);
            
            String SQL = "INSERT INTO lokal (id_budynku, id_lokalu, nr_lokalu, nr_piętra, powierzchnia, liczba_pokoi, cena_za_m2) VALUES (@id_b, @id_l, @nr_l, @nr_p, @pow, @l_pok, @cena)";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id_b", admin_window.id_bud);
            cmd.Parameters.AddWithValue("@id_l", id_lok);
            cmd.Parameters.AddWithValue("@nr_l", (Convert.ToInt32(nr_lokalu.Text)));
            cmd.Parameters.AddWithValue("@nr_p", (Convert.ToInt32(nr_pietra.Text)));
            cmd.Parameters.AddWithValue("@pow", (Convert.ToInt32(powierzchnia.Text)));
            cmd.Parameters.AddWithValue("@l_pok", (Convert.ToInt32(liczba_pokoi.Text)));
            cmd.Parameters.AddWithValue("@cena", (Convert.ToInt32(cena_m2.Text)));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //dodać do wszytskich dodwań poprawność insertu, żeby pokazywało messagebox po poprawnym wykonaniu działania
        }
        //--------------------------------------------------------------------------------------//
    }
}
