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

namespace BD
{
    public partial class nowe_budynki_window : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();


        public nowe_budynki_window()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=DESKTOP-CL91JDT\\SQLEXPRESS;Initial Catalog=AdministracjaBudynkami;Integrated Security=True;";

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
            con.Open();
            com.Connection = con;
            com.CommandText = "insert into budynek(id_budynku, miejscowość, ulica, nr_budynku, liczba_pięter) values('" + nazwa.Text + "','" + miejscowosc.Text + "','" + ulica.Text + "','" + nr_budynku.Text + "','" + liczba_pieter.Text + "')";
            com.ExecuteNonQuery();
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

