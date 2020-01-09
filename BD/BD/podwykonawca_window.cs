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
    public partial class podwykonawca_window : Form
    {
        private string connectionString = GlobalVar.con_str;
        public podwykonawca_window()
        {
            InitializeComponent();
        }


        //----------------------------------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------//
        //-----------------------------dodawanie firm do realizacji-------------------------------------//
        //----------------------------------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------//
        private void do_realizacji_Click(object sender, EventArgs e)
        {

            //-------------------------załadowanie wybranego zgłoszenia do usterek--------------------------//
            String SQL = "INSERT INTO usterka (id_zgłoszenia, typ_usterki, data_zlecenia) VALUES (@id_z, @zgloszenie, @data)";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id_z", admin_window.id_zg);
            cmd.Parameters.AddWithValue("@zgloszenie", admin_window.zgloszenie);
            cmd.Parameters.AddWithValue("@data", SqlDbType.DateTime).Value = data_zlecenia.Value.Date;
            cmd.ExecuteScalar();
            con.Close();
            //----------------------------------------------------------------------------------------------//

            //--------------------------przekazanie usterki dla firmy odpowiedzialnej-----------------------//
            string nazwa_firmy = firma_nazwa.Text.ToString();
            SQL= "INSERT INTO podwykonawca (id_usterki, nazwa_firmy,data_zlecenia) VALUES ((SELECT id_usterki FROM usterka WHERE id_zgłoszenia='"+admin_window.id_zg+"'),@firma,@data) ";
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@firma",firma_nazwa.Text);
            cmd.Parameters.AddWithValue("@data", SqlDbType.DateTime).Value = data_zlecenia.Value.Date;
            cmd.ExecuteScalar();
            con.Close();
            firma_nazwa.Clear();
            //----------------------------------------------------------------------------------------------//
        }

        private void data_zlecenia_ValueChanged(object sender, EventArgs e)
        {
            data_zlecenia.ShowUpDown = true;
            data_zlecenia.CustomFormat = "YYYY-MM-DD hh:mm:ss[.nnn]";
            
        }
        //----------------------------------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------//
        //-----------------------------kończenie realizacji---------------------------------------------//
        //----------------------------------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------//

        private void podwykonawca_window_Load(object sender, EventArgs e)
        {
            string num = admin_window.list[admin_window.numerek];
            wykonywane_przez_firme.Items.Clear();
            //------------------------załadowanie wykonywanych remontów itp---------------------------------//
            string wartosci;
            String SQL = "SELECT p.id_usterki, u.typ_usterki, p.nazwa_firmy FROM podwykonawca p, usterka u , zgłoszenie z WHERE z.id_budynku= " + num + " AND z.id_zgłoszenia=u.id_zgłoszenia AND u.id_usterki=p.id_usterki AND p.data_wykonania IS NULL ";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader r = null;
            con.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                wartosci = r[0] + " " + r[1] + " Firma: " + r[2];
                wykonywane_przez_firme.Items.Add(wartosci);
            }
            //----------------------------------------------------------------------------------------------//
        }
        private void zakoncz_realizacje_Click(object sender, EventArgs e)
        {
            //-------------------------------sprawdzenie zaznaczonego remontu-------------------------------//
            string checkedItem = string.Empty;
            foreach (object Item in wykonywane_przez_firme.CheckedItems)
            {
                checkedItem += Item.ToString();
            }

            string id_u = checkedItem.Substring(0, 2); //numer usterki
            string id_z = string.Empty; //numer zgłoszenia
            //----------------------------------------------------------------------------------------------//

            //-------------------------------pobranie numeru zgłoszenia potrzebne pozniej-------------------//
            String SQL = "SELECT id_zgłoszenia FROM usterka WHERE id_usterki='"+id_u+"' ";
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

            //-------------------------------dodanie daty zakonczenia---------------------------------------//
            SQL = "UPDATE podwykonawca SET data_wykonania=@data WHERE id_usterki = @id " ;
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", id_u);
            cmd.Parameters.AddWithValue("@data", SqlDbType.DateTime).Value = data_zakonczenia.Value.Date;
            cmd.ExecuteNonQuery();
            con.Close();
            //----------------------------------------------------------------------------------------------//

            //-------------------------------dodanie daty zakonczenia---------------------------------------//
            SQL = "UPDATE usterka SET data_wykonania = @data WHERE id_usterki = @id ";
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", id_u);
            cmd.Parameters.AddWithValue("@data", SqlDbType.DateTime).Value = data_zakonczenia.Value.Date;
            cmd.ExecuteNonQuery();
            con.Close();
            //----------------------------------------------------------------------------------------------//

            //-------------------------------dodanie daty zakonczenia---------------------------------------//
            SQL = "UPDATE zgłoszenie SET data_realizacji = @data WHERE id_zgłoszenia = @id ";
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", id_z);
            cmd.Parameters.AddWithValue("@data", SqlDbType.DateTime).Value = data_zakonczenia.Value.Date;
            cmd.ExecuteNonQuery();
            con.Close();
            //----------------------------------------------------------------------------------------------//
        }

        private void data_zakonczenia_ValueChanged(object sender, EventArgs e)
        {
            data_zlecenia.ShowUpDown = true;
            data_zlecenia.CustomFormat = "YYYY-MM-DD hh:mm:ss[.nnn]";
        }
    }
}