﻿using System;
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
        public static string zgloszenie;
        public static int id_zg;
        private string connectionString = "Data Source=DESKTOP-CL91JDT\\SQLEXPRESS;Initial Catalog=AdministracjaBudynkami;Integrated Security=True";
        List<string> list = new List<string>();
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
            if (remonty_dla_admina.CheckedItems.Count != 0)
            {
                //--------------------otwarcie nowego okna i czyszczenie małych okienek-------------------------//
                podwykonawca_window okno_podw = new podwykonawca_window();
                okno_podw.Show();
                lista_budynkow.Items.Clear();
                remonty_dla_admina.Items.Clear();
                w_realizacji.Items.Clear();
                //----------------------------------------------------------------------------------------------//
            }


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
            //------------------------wybór jakie okno mi się otworzyć-------------------------------//
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
            //--------------------------------------------------------------------------------------//
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
            this.budynekTableAdapter.Fill(this.administracjaBudynkamiDataSet.budynek);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'administracjaBudynkamiDataSet.zgłoszenie' . Możesz go przenieść lub usunąć.
            this.zgłoszenieTableAdapter.Fill(this.administracjaBudynkamiDataSet.zgłoszenie);

        }

        private void potwierdzenie_realizacji_Click(object sender, EventArgs e)
        {
            podwykonawca_window okno_podw = new podwykonawca_window();
            okno_podw.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //----------------------------wypisanie aktualnych numerów budynków do listy--------------------//
            lista_budynkow.Items.Clear();
            String SQL = "SELECT id_budynku FROM budynek";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader r = null;
            con.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                lista_budynkow.Items.Add(r["id_budynku"]);
            }
            foreach (var item in lista_budynkow.Items)
            {
                list.Add(item.ToString());
            }
            con.Close();
            //----------------------------------------------------------------------------------------------//
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //-------------------------sprawdzanie wyboru budynku-------------------------------------------//
            remonty_dla_admina.Items.Clear();
            w_realizacji.Items.Clear();
            string wartosci;
            int i = 0;
            string text = lista_budynkow.GetItemText(lista_budynkow.SelectedItem);
            foreach (var item in lista_budynkow.Items)
            {
                if (text == list[i])
                {
                    MessageBox.Show("Wybrano budynek " + list[i]);
                }
                i++;
            }
            //----------------------------------------------------------------------------------------------//

            //------------------------załadowanie aktualnych zgłoszeń przeznaczonych dla admina-------------//
            String SQL = "SELECT zgłoszenie.id_zgłoszenia, zgłoszenie.typ_zgłoszenia, zgłoszenie.id_użytkownika FROM zgłoszenie, budynek WHERE zgłoszenie.id_budynku=budynek.id_budynku AND zgłoszenie.data_realizacji IS NULL AND zgłoszenie.typ_zgłoszenia LIKE 'R%' AND budynek.id_budynku ='" + text + "'AND zgłoszenie.id_zgłoszenia NOT IN(select u2.id_zgłoszenia from usterka u2 where u2.id_zgłoszenia=zgłoszenie.id_zgłoszenia)";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader r;
            con.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                wartosci = r[1] + " Użytkownik:" + r[2];
                remonty_dla_admina.Items.Add(wartosci, false);
                zgloszenie = Convert.ToString(r[1]);
                id_zg = Convert.ToInt32(r[0]);
            }
            con.Close();
            //----------------------------------------------------------------------------------------------//

            //----------------------------załadowanie aktualnie wykonywanych remontów-----------------------//
            SQL = "SELECT usterka.typ_usterki, podwykonawca.data_zlecenia FROM zgłoszenie, usterka, podwykonawca  WHERE zgłoszenie.id_budynku='" + text + "' AND zgłoszenie.id_zgłoszenia=usterka.id_zgłoszenia AND  usterka.id_usterki=podwykonawca.id_usterki AND podwykonawca.data_wykonania IS NULL";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(SQL, con);
            r = null;
            con.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                wartosci = r[0] + " Data zlecenia :" + r[1];
                w_realizacji.Items.Add(wartosci);
            }
            con.Close();
            //----------------------------------------------------------------------------------------------//

            
        }
    }
}