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
    public partial class konserwator_window : Form
    {
        public static int id_bud;
        public static int numerek;
        public static int id_zg;
        public static string zgloszenie;
        public static string text;

        private string connectionString = GlobalVar.con_str;
        public static List<string> list = new List<string>();
        public konserwator_window()
        {
            InitializeComponent();
        }

        private void konserwator_window_Load(object sender, EventArgs e)
        {
            //-------------------------załadowanie dostępnych budynków--------------------------------------//
            budynki.Items.Clear();
            String SQL = "SELECT id_budynku FROM budynek";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader r = null;
            con.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                budynki.Items.Add(r["id_budynku"]);
            }
            foreach (var item in budynki.Items)
            {
                list.Add(item.ToString());
            }
            con.Close();
            //----------------------------------------------------------------------------------------------//
        }

        private void budynki_SelectedIndexChanged(object sender, EventArgs e)
        {
            //----------------------------sprawdzenie wyboru budynku----------------------------------------//
            
            string wartosci;
            do_konserwacji.Items.Clear();
            w_konserwacji.Items.Clear();
            int i = 0;
            text = budynki.GetItemText(budynki.SelectedItem);
            foreach (var item in budynki.Items)
            {
                if (text == list[i])
                {
                    MessageBox.Show("Wybrano budynek " + list[i]);
                    id_bud = Convert.ToInt32(list[i]);
                    break;
                }
                i++;
            }
            numerek = i;
            //----------------------------------------------------------------------------------------------//




            //------------------------załadowanie złoszeń dla konserwatora----------------------------------//
            String SQL = "SELECT zgłoszenie.id_zgłoszenia, zgłoszenie.typ_zgłoszenia, zgłoszenie.id_użytkownika FROM zgłoszenie, budynek WHERE zgłoszenie.id_budynku=budynek.id_budynku AND zgłoszenie.data_realizacji IS NULL AND zgłoszenie.typ_zgłoszenia LIKE 'Nap%' AND budynek.id_budynku ='" + text + "'AND zgłoszenie.id_zgłoszenia NOT IN(select u2.id_zgłoszenia from usterka u2 where u2.id_zgłoszenia=zgłoszenie.id_zgłoszenia)";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SQL, con);
            con.Open();
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                wartosci = r[0] + " " + r[1] + " Użytkownik:" + r[2];
                do_konserwacji.Items.Add(wartosci, false);
                
            }
            con.Close();
            //----------------------------------------------------------------------------------------------//




            //-----------------załadowanie wykonywanych konserwacji-----------------------------------------//
            SQL = "SELECT usterka.id_usterki, usterka.typ_usterki, usterka.data_zlecenia, usterka.id_zgłoszenia FROM zgłoszenie, usterka  WHERE zgłoszenie.id_budynku='" + text + "' AND zgłoszenie.id_zgłoszenia=usterka.id_zgłoszenia  AND usterka.data_wykonania IS NULL";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(SQL, con);
            r = null;
            con.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                wartosci = r[0] + " " + r[1] + " Data zlecenia :" + r[2];
                w_konserwacji.Items.Add(wartosci);
            }
            con.Close();
            //----------------------------------------------------------------------------------------------//
        }

        private void dodaj_do_konserwacji_Click(object sender, EventArgs e)
        {
            //----------------------pobranie informacji z wybranego zgłoszenia------------------------------//
            string wartosci;
            string checkedItem = string.Empty;
            foreach (object item in do_konserwacji.CheckedItems)
            {
                checkedItem = item.ToString();
            }
            if (do_konserwacji.CheckedItems.Count == 1)
            {
                id_zg = Convert.ToInt32(checkedItem.Substring(0, 2));
                zgloszenie = Convert.ToString(checkedItem.Substring(2, 20));
            }
            //----------------------------------------------------------------------------------------------//


            if (do_konserwacji.CheckedItems.Count != 0)
            {
                //-------------------------załadowanie wybranego zgłoszenia do usterek--------------------------//
                String SQL = "INSERT INTO usterka (id_zgłoszenia, typ_usterki, data_zlecenia) VALUES (@id_z, @zgloszenie, @data)";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.Parameters.AddWithValue("@id_z", id_zg);
                cmd.Parameters.AddWithValue("@zgloszenie", zgloszenie);
                cmd.Parameters.AddWithValue("@data", SqlDbType.DateTime).Value = data_rozpoczecia.Value.Date;
                cmd.ExecuteScalar();
                con.Close();
                //----------------------------------------------------------------------------------------------//
            }


            //---------wyczyszczenie i ponowne załadowanie aktualnych konserwacji---------------------------//
            w_konserwacji.Items.Clear();
            String SQL1= "SELECT usterka.id_usterki, usterka.typ_usterki, usterka.data_zlecenia, usterka.id_zgłoszenia  FROM zgłoszenie, usterka  WHERE zgłoszenie.id_budynku='" + text + "' AND zgłoszenie.id_zgłoszenia=usterka.id_zgłoszenia  AND usterka.data_wykonania IS NULL";
            SqlConnection con1 = new SqlConnection(connectionString);
            SqlCommand cmd1  = new SqlCommand(SQL1, con1);
            SqlDataReader r = null;
            con1.Open();
            r = cmd1.ExecuteReader();
            while (r.Read())
            {
                wartosci = r[0] +" "+r[1] + " Data zlecenia :" + r[2];
                w_konserwacji.Items.Add(wartosci);
            }
            con1.Close();
            //----------------------------------------------------------------------------------------------//




            //-----------------wyczyszczenie i ponowne załadowanie zgłoszeń---------------------------------//
            do_konserwacji.Items.Clear();
            SQL1 = "SELECT zgłoszenie.id_zgłoszenia, zgłoszenie.typ_zgłoszenia, zgłoszenie.id_użytkownika FROM zgłoszenie, budynek WHERE zgłoszenie.id_budynku=budynek.id_budynku AND zgłoszenie.data_realizacji IS NULL AND zgłoszenie.typ_zgłoszenia LIKE 'Nap%' AND budynek.id_budynku ='" + text + "'AND zgłoszenie.id_zgłoszenia NOT IN(select u2.id_zgłoszenia from usterka u2 where u2.id_zgłoszenia=zgłoszenie.id_zgłoszenia)";
            con1 = new SqlConnection(connectionString);
            cmd1 = new SqlCommand(SQL1, con1);
            con1.Open();
            r = cmd1.ExecuteReader();
            while (r.Read())
            {
                wartosci = r[0] + " " + r[1] + " Użytkownik:" + r[2];
                do_konserwacji.Items.Add(wartosci, false);

            }
            con1.Close();
            //----------------------------------------------------------------------------------------------//



        }

        private void do_konserwacji_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void potwierdz_konserwacje_Click(object sender, EventArgs e)
        {
            //-------------------------pobranie informacji i wybranej konserwacji---------------------------//
            string wartosci;
            string checkedItem = string.Empty;
            foreach (object Item in w_konserwacji.CheckedItems)
            {
                checkedItem += Item.ToString();
            }

            string id_u = checkedItem.Substring(0, 2); //numer usterki
            string typ_zg = checkedItem.Substring(2, 20);
            string id_z = string.Empty; //numer zgłoszenia
            //----------------------------------------------------------------------------------------------//




            //------------------------pobranie id zgłoszenia------------------------------------------------//
            String SQL = "SELECT id_zgłoszenia FROM usterka WHERE id_usterki='" + id_u + "' ";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader r = null;
            con.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                id_z = Convert.ToString(r[0]);
            }
            //----------------------------------------------------------------------------------------------//



            //-------------------------uzupełnienie konserwacji---------------------------------------------//
            SQL = "INSERT INTO konserwacja (id_zgłoszenia, typ_konserwacji, data_wykonania, os_odpowiedzialna) VALUES (@id_z, @zgloszenie, @data, @osoba)";
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id_z", id_z);
            cmd.Parameters.AddWithValue("@zgloszenie", typ_zg);
            cmd.Parameters.AddWithValue("@data", SqlDbType.DateTime).Value = data_wykonania.Value.Date;
            cmd.Parameters.AddWithValue("@osoba", osoba_odpowiedzialna.Text);
            cmd.ExecuteScalar();
            con.Close();
            //----------------------------------------------------------------------------------------------//




            //---------------------------uzupełnienie usterki o datę wykonania------------------------------//
            SQL = "UPDATE usterka SET data_wykonania = @data WHERE id_usterki = @id ";
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", id_u);
            cmd.Parameters.AddWithValue("@data", SqlDbType.DateTime).Value = data_wykonania.Value.Date;
            cmd.ExecuteNonQuery();
            con.Close();
            osoba_odpowiedzialna.Clear();
            //----------------------------------------------------------------------------------------------//




            //-----------------------------uzupełnienie zgłoszenia o datę realizacji------------------------//
            SQL = "UPDATE zgłoszenie SET data_realizacji = @data WHERE id_zgłoszenia = @id ";
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", id_z);
            cmd.Parameters.AddWithValue("@data", SqlDbType.DateTime).Value = data_wykonania.Value.Date;
            cmd.ExecuteNonQuery();
            con.Close();
            //----------------------------------------------------------------------------------------------//



            //--------------------------wyczyszczenie i ponowne załadowanie konserwacji---------------------//
            w_konserwacji.Items.Clear();
            SQL = "SELECT usterka.id_usterki, usterka.typ_usterki, usterka.data_zlecenia, usterka.id_zgłoszenia  FROM zgłoszenie, usterka  WHERE zgłoszenie.id_budynku='" + text + "' AND zgłoszenie.id_zgłoszenia=usterka.id_zgłoszenia  AND usterka.data_wykonania IS NULL";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(SQL, con);
            r = null;
            con.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                wartosci = r[0] + " " + r[1] + " Data zlecenia :" + r[2];
                w_konserwacji.Items.Add(wartosci);
            }
            con.Close();
            //----------------------------------------------------------------------------------------------//
        }
    }
}
