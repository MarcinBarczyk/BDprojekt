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
    public partial class nowe_umowy_window : Form
    {

        string lokal;
        string id_wyn;
        string typ;
        private string connectionString = GlobalVar.con_str;
        public nowe_umowy_window()
        {
            InitializeComponent();
        }

        private void nowe_umowy_window_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'administracjaBudynkamiDataSet.wynajem' . Możesz go przenieść lub usunąć.
            this.wynajemTableAdapter.Fill(this.administracjaBudynkamiDataSet.wynajem);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'administracjaBudynkamiDataSet.najemca' . Możesz go przenieść lub usunąć.
            this.najemcaTableAdapter.Fill(this.administracjaBudynkamiDataSet.najemca);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'administracjaBudynkamiDataSet.lokal' . Możesz go przenieść lub usunąć.
            this.lokalTableAdapter.Fill(this.administracjaBudynkamiDataSet.lokal);

           
            //------------------------możliwe dokumenty do wyboru-----------------------------------//
            var items = typ_dokumentu_najemca.Items;
            items.Add("Paszport");
            items.Add("Dowód osobisty");
            items.Add("Inne");
            //--------------------------------------------------------------------------------------//
        }

        private void potwierdz_lokal_Click(object sender, EventArgs e)
        {
            //-------------------pobieranie wartości mieszkania z lokalu----------------------------//
            if (id_lokalu_do_wynajecia.Text.Length == 0)
                MessageBox.Show("Pole id budynku mie moze być puste!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                lokal = id_lokalu_do_wynajecia.Text;
                String SQL = "SELECT (powierzchnia*cena_za_m2) FROM lokal WHERE id_lokalu=@lokal";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.Parameters.AddWithValue("@lokal", lokal);
                SqlDataReader r = null;

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

                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    label10.Text = Convert.ToString(r[0]) + " zł";
                }
                con.Close();
                //--------------------------------------------------------------------------------------//
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dodaj_wynajem_Click(object sender, EventArgs e)
        {
            //-------------------------dodawanie nowych wynajmów------------------------------------//
            String SQL = "INSERT INTO wynajem (id_lokalu, cena_miesiąc, data_zawarcia_umowy, termin_płatności, data_zamieszkania, data_końca_umowy, data_końca_zamieszkania) " +
                "VALUES (@id_lok, @cena, @zawarcie, @platnosc, @pocz_zam, @kon_umowy, @kon_zam)";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id_lok",lokal);

            if (czynsz_msc.Text.Length == 0)
                MessageBox.Show("Pole id budynku mie moze być puste!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                cmd.Parameters.AddWithValue("@cena", czynsz_msc.Text);
                cmd.Parameters.AddWithValue("@zawarcie", SqlDbType.DateTime).Value = data_zawarcia_umowy.Value.Date;
                cmd.Parameters.AddWithValue("@platnosc", SqlDbType.DateTime).Value = termin_platnosci.Value.Date;
                cmd.Parameters.AddWithValue("@pocz_zam", SqlDbType.DateTime).Value = data_zamieszkania.Value.Date;
                cmd.Parameters.AddWithValue("@kon_umowy", SqlDbType.DateTime).Value = data_konca_umowy.Value.Date;
                cmd.Parameters.AddWithValue("@kon_zam", SqlDbType.DateTime).Value = data_konca_zamieszkania.Value.Date;

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

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Nowy wynajem został poprawnie dodany.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Nie udało sie dodać nowego rekordu!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                con.Close();
                //--------------------------------------------------------------------------------------//
            }

            //--------------------czyszczenie wartości i update tabeli------------------------------//
            czynsz_msc.Clear();
            id_lokalu_do_wynajecia.Clear();
            this.wynajemTableAdapter.Fill(this.administracjaBudynkamiDataSet.wynajem);
            //--------------------------------------------------------------------------------------//

        }

        private void dodaj_najemce_Click(object sender, EventArgs e)
        {
            //--------pobieranie ostatniego rekordu z wynajmu aby dodac do najemcy-----------------//
            String SQL = "SELECT TOP 1 id_wynajmu FROM wynajem ORDER BY id_wynajmu DESC";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader r = null;

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

            r = cmd.ExecuteReader();
            while (r.Read())
            {
                id_wyn = Convert.ToString(r[0]);
            }
            con.Close();
            //--------------------------------------------------------------------------------------//

            //------sprawdzenie ilości wynajmów i najemców aby później insert był poprawny----------//
            Int32 count_wynajem, count_najemca; ;
            SQL = "SELECT COUNT(id_wynajmu) FROM wynajem";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(SQL, con);

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

            count_wynajem = (Int32)cmd.ExecuteScalar();
            SQL = "SELECT COUNT(id_najemca) FROM najemca";
            cmd = new SqlCommand(SQL, con);
            count_najemca = (Int32)cmd.ExecuteScalar();
            con.Close();
            //--------------------------------------------------------------------------------------//


            //---jeśli rodzaj dokumentu jest wybrany i liczby sie zgadzają to dodaj najemce---------//
            if ((typ_dokumentu_najemca.CheckedItems.Count == 1) && (count_wynajem>count_najemca))
            {
                foreach (object itemchecked in typ_dokumentu_najemca.CheckedItems)
                {
                    typ = itemchecked.ToString();
                }
                SQL = "INSERT INTO najemca (id_wynajmu, imię, nazwisko, pesel, nr_dokumentu, typ_dokumentu) VALUES (@id, @imie, @nazwisko, @pesel,@nr_dok, @typ)";
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand(SQL, con);
                cmd.Parameters.AddWithValue("@id", id_wyn);
                cmd.Parameters.AddWithValue("@imie", imie_najemca.Text);
                cmd.Parameters.AddWithValue("@nazwisko", nazwisko_najemca.Text);
                cmd.Parameters.AddWithValue("@pesel", pesel_najemca.Text);
                cmd.Parameters.AddWithValue("@nr_dok", nr_dokumentu_najemca.Text);
                cmd.Parameters.AddWithValue("@typ", typ);

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

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Nowy najemca został poprawnie dodany.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Nie udało sie dodać nowego rekordu!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                con.Close();
            }
            else
            {
                MessageBox.Show("Za mało wynajmów lub nie wybrano typu dokumentu");
            }
            //--------------------------------------------------------------------------------------//

            //--------------------czyszczenie wpisów i update tabeli--------------------------------//
            imie_najemca.Clear();
            nazwisko_najemca.Clear();
            pesel_najemca.Clear();
            nr_dokumentu_najemca.Clear();
            this.najemcaTableAdapter.Fill(this.administracjaBudynkamiDataSet.najemca);
            //--------------------------------------------------------------------------------------//
        }
    }
}
