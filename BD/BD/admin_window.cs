using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class admin_window : Form
    {
        public admin_window()
        {
            InitializeComponent();
        }

        private void Budynki_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = Budynki.SelectedItem.ToString();
            if(curItem=="Budynek alfa") //pobrac z jakies pliku czy jakis case zrobic 
            {
                MessageBox.Show("alfa"); //pokazanie bazy dla danego budynku. mieszkancy, platnosci, zgloszone usterki
            }
            if (curItem == "Budynek beta")
            {
                MessageBox.Show("beta");
            }
            if (curItem == "Budynek gamma")
            {
                MessageBox.Show("gamma");
            }
        }

        private void Budynek_dane_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dodanie bazy danych zeby to jakos obsluzyc
        }

        private void Zgloszenia_Click(object sender, EventArgs e)
        {
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
            if (dodawanie_uzytkownika.Checked)
            {
                add_user_window okno_add = new add_user_window();
                okno_add.Show();
            }
        }

        private void dodawanie_uzytkownika_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}


//nie wiem jak ze zgłaszeniem tego zewnętrznym firmom, trzeba to jeszcze gdzieś jakoś wcisnąć
// i jeszcze jakieś dodawanie tych meldunkow// jakies miejsce gdzie będzie się wpisywać dane i dodawać użytkownika do bazy zeby mogł sie zalogowac itp.
