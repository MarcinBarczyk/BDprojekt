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
    public partial class podwykonawca_window : Form
    {
        private string connectionString = "Data Source=DESKTOP-CL91JDT\\SQLEXPRESS;Initial Catalog=AdministracjaBudynkami;Integrated Security=True";
        public podwykonawca_window()
        {
            InitializeComponent();
        }

        private void podwykonawca_window_Load(object sender, EventArgs e)
        {

        }

        private void do_realizacji_Click(object sender, EventArgs e)
        {

            //-------------------------załadowanie wybranego zgłoszenia do usterek--------------------------//
            String SQL = null;
            SQL = "INSERT INTO usterka (id_zgłoszenia, typ_usterki, data_zlecenia) VALUES (@id_z, @zgloszenie, @data)";
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
            //----------------------------------------------------------------------------------------------//
        }

        private void data_zlecenia_ValueChanged(object sender, EventArgs e)
        {
            data_zlecenia.ShowUpDown = true;
            data_zlecenia.CustomFormat = "YYYY-MM-DD hh:mm:ss[.nnn]";
            
        }
    }
}