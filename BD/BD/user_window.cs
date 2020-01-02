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
    public partial class user_window : Form
    {
        private string connectionString = "Data Source=DESKTOP-CL91JDT\\SQLEXPRESS;Initial Catalog=AdministracjaBudynkami;Integrated Security=True";
        public static List<string> list = new List<string>();
        public static int id_u;
        public user_window()
        {
            InitializeComponent();
        }

        private void user_window_Load(object sender, EventArgs e)
        {
            id_u = Form1.id_user;// identyfikator użytkownika zalogowanego

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
        }

        private void potw_zgloszenia_Click(object sender, EventArgs e)
        {
            string zg;
            string id_b;
            string checkedItem = string.Empty;
            foreach (object Item in lista_budynkow.CheckedItems)
            {
                checkedItem += Item.ToString();
            }
            id_b = checkedItem.Substring(0, 1);// identyfikator budynku
            zg = zgloszenie.Text;

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

        }
    }
}
