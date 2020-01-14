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

using GlobalVariables;


namespace BD
{
    public partial class nowe_lokale_window : Form
    {
        private string connectionString = GlobalVar.con_str;
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

            if (nr_pietra.Text.Length == 0)
                nr_pietra.Text = "0";
            cmd.Parameters.AddWithValue("@nr_p", (Convert.ToInt32(nr_pietra.Text)));

            if (powierzchnia.Text.Length == 0)
                powierzchnia.Text = "0";
            cmd.Parameters.AddWithValue("@pow", (Convert.ToInt32(powierzchnia.Text)));

            if (liczba_pokoi.Text.Length == 0)
                liczba_pokoi.Text = "0";
            cmd.Parameters.AddWithValue("@l_pok", (Convert.ToInt32(liczba_pokoi.Text)));

            if (cena_m2.Text.Length == 0)
                cena_m2.Text = "0";
            cmd.Parameters.AddWithValue("@cena", (Convert.ToInt32(cena_m2.Text)));

            try
            {
                con.Open();
            }
            catch
            {
                DialogResult _result = MessageBox.Show("Bład serwera! Nie udało się nawiązać połączenia z bazą danych!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                if (_result == DialogResult.OK)
                    Environment.Exit(0);
            }
            
            if(cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Nowy budynek został poprawnie dodany.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Nie udało sie dodać nowego rekordu!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            con.Close();
            //dodać do wszytskich dodwań poprawność insertu, żeby pokazywało messagebox po poprawnym wykonaniu działania
            //--------------------------------------------------------------------------------------//

            //---------------------------czyszczenie wpisanych wartosci i update tabeli-------------//
            nr_lokalu.Clear();
            nr_pietra.Clear();
            powierzchnia.Clear();
            liczba_pokoi.Clear();
            cena_m2.Clear();
            this.lokalTableAdapter.Fill(this.administracjaBudynkamiDataSet.lokal);
            //--------------------------------------------------------------------------------------//
        }

    }
}
