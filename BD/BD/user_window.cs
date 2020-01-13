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
    public partial class user_window : Form
    {
        private string connectionString = GlobalVar.con_str;
        public static List<string> list = new List<string>();
        public static int id_u;
        public static int id_wyn;
        public user_window()
        {
            InitializeComponent();
        }

        private void user_window_Load(object sender, EventArgs e)
        {
            id_u = Convert.ToInt32(Form1.id_user);// identyfikator użytkownika zalogowanego

            //---------------------------pobranie id budynkow do wyboru-------------------------------------//
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

            //-------------------pobór id najemcy na podstawie id użytkownika-------------------------------//
            SQL = "SELECT n.id_wynajmu FROM najemca n, użytkownik u WHERE u.id_użytkownika=@user_id AND u.id_najemca=n.id_najemca";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@user_id", id_u);
            r = null;
            con.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                id_wyn = Convert.ToInt32(r[0]);
            }
            con.Close();
            //----------------------------------------------------------------------------------------------//

        }

        private void potw_zgloszenia_Click(object sender, EventArgs e)
        {
            string zg;
            string id_b;
            string checkedItem = string.Empty;

            //---------------------------------pobranie jaki budynek jest wybrany---------------------------//
            foreach (object Item in lista_budynkow.CheckedItems)
            {
                checkedItem += Item.ToString();
            }
            id_b = checkedItem.Substring(0, 1);// identyfikator budynku
            zg = zgloszenie.Text;
            //----------------------------------------------------------------------------------------------//


            //-------------dodanie do złoszeń aktualnie zgłaszanego zgłoszenia przez użytkownika------------//
            String SQL = "INSERT INTO zgłoszenie (typ_zgłoszenia, data_zgłoszenia, id_budynku, id_użytkownika) VALUES (@typ, @data, @id_b, @id_u)";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@typ", zg);
            cmd.Parameters.AddWithValue("@data", SqlDbType.DateTime).Value = data_zgloszenia.Value.Date;
            cmd.Parameters.AddWithValue("@id_b", id_b);
            cmd.Parameters.AddWithValue("@id_u", id_u);
            cmd.ExecuteScalar();
            con.Close();
            zgloszenie.Clear();
            //----------------------------------------------------------------------------------------------//
        }

        private void potwierdzenie_platnosci_Click(object sender, EventArgs e)
        {
            int id_zob=0;
            //---------------------przy potwierdzaniu platnosci aktualizuja sie zobowiazania----------------//
            String SQL = "UPDATE zobowiązania SET kwota = @kwota, data_płatności = @data, zaksięgowane = 'Tak' WHERE id_wynajmu=@id AND zaksięgowane='Nie'";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", id_wyn);
            cmd.Parameters.AddWithValue("@kwota", kwota_przelew.Text);
            cmd.Parameters.AddWithValue("@data", SqlDbType.DateTime).Value = data_przelew.Value.Date;
            cmd.ExecuteScalar();
            con.Close();
            zgloszenie.Clear();
            //----------------------------------------------------------------------------------------------//

            //----------------------pobór id zobowiązania żeby później dać do płatności---------------------//
            SQL = "SELECT id_zobowiązania FROM zobowiązania WHERE id_wynajmu=@id_w";
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id_w", id_wyn);
            SqlDataReader r = null;
            con.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                id_zob = Convert.ToInt32(r[0]);
            }
            con.Close();
            //----------------------------------------------------------------------------------------------//

            //---do płatności dodajemy aktualnie potwierdzaną płatnośc przez użytkownika--------------------//
            SQL = "INSERT INTO płatności(kwota, data_płatności, id_zobowiązania) VALUES (@kwota, @data, @id_z)";
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id_z", id_zob);
            cmd.Parameters.AddWithValue("@kwota", kwota_przelew.Text);
            cmd.Parameters.AddWithValue("@data", SqlDbType.DateTime).Value = data_przelew.Value.Date;
            cmd.ExecuteNonQuery();
            con.Close();
            kwota_przelew.Clear();
            //----------------------------------------------------------------------------------------------//
        }

        private void data_zgloszenia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void kwota_przelew_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
