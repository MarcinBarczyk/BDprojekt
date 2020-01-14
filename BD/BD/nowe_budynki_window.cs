using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

using GlobalVariables;

namespace BD
{
    public partial class nowe_budynki_window : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();


        public nowe_budynki_window()
        {
            InitializeComponent();
            con.ConnectionString = GlobalVar.con_str;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nowe_budynki_window_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'administracjaBudynkamiDataSet.budynek' table. You can move, or remove it, as needed.
            this.budynekTableAdapter.Fill(this.administracjaBudynkamiDataSet.budynek);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dodaj_budynek_Click(object sender, EventArgs e)
        {
            //-------------------dodawanie budynku przez insert-------------------------------------//
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
            
            com.Connection = con;

            if (nazwa.Text.Length == 0)
                nazwa.Text = "nazwa";
            else if (miejscowosc.Text.Length == 0)
                miejscowosc.Text = "miejscowosc";
            else if (ulica.Text.Length == 0)
                ulica.Text = "ulica";
            else if (nr_budynku.Text.Length == 0)
                nr_budynku.Text = "0";
            else if (liczba_pieter.Text.Length == 0)
                liczba_pieter.Text = "0";

            com.CommandText = "insert into budynek(id_budynku, miejscowość, ulica, nr_budynku, liczba_pięter) values('" + nazwa.Text + "','" + miejscowosc.Text + "','" + ulica.Text + "','" + nr_budynku.Text + "','" + liczba_pieter.Text + "')";

            if (com.ExecuteNonQuery() > 0)
                MessageBox.Show("Nowy budynek został poprawnie dodany.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Nie udało sie dodać nowego rekordu!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            con.Close();
            //--------------------------------------------------------------------------------------//

            //-------------------czyszczenie wpisanych wartosci i update tabeli---------------------//
            nazwa.Clear();
            miejscowosc.Clear();
            ulica.Clear();
            nr_budynku.Clear();
            liczba_pieter.Clear();
            this.budynekTableAdapter.Fill(this.administracjaBudynkamiDataSet.budynek);
            //--------------------------------------------------------------------------------------//
            //this.dataGridView1.DataBindings();
        }
    }
}

