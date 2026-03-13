using System;
using System.Windows.Forms;

namespace Apka_do_jedzenia
{
    public partial class Main : Form
    {
        double sumaTotalna = 0;

        double ostatniKosztTransportu = 0;
        ListViewItem pozycjaTransportuNaLiscie = null;
        public Main()
        {
            InitializeComponent();
            Koszyk.View = View.List; 
        }
        private void buttonWybierz_Click(object sender, EventArgs e)
        {
            Wybierz oknoSzamy = new Wybierz();

            if (oknoSzamy.ShowDialog() == DialogResult.OK)
            {
                foreach(string pozycja in oknoSzamy.WybraneDaniaFormat)
                {
                    Koszyk.Items.Add(pozycja);
                }
                sumaTotalna += oknoSzamy.SumaCen;
                Cena.Text = sumaTotalna.ToString() + " z³";
            }
        }
        private void buttonTransport_Click(object sender, EventArgs e)
        {
            Transport oknoTransportu = new Transport();

            if (oknoTransportu.ShowDialog() == DialogResult.OK)
            {
                sumaTotalna -= ostatniKosztTransportu;
                if (pozycjaTransportuNaLiscie != null)
                {
                    Koszyk.Items.Remove(pozycjaTransportuNaLiscie);
                }
                ostatniKosztTransportu = global.KosztTransporty;
                sumaTotalna += ostatniKosztTransportu;
                Cena.Text = sumaTotalna.ToString() + " z³";

                pozycjaTransportuNaLiscie = new ListViewItem("Transport: " + global.WybranyTransport + " - " + global.KosztTransporty + " z³");
                Koszyk.Items.Add(pozycjaTransportuNaLiscie);
            }
        }
        private void buttonZaplac_Click(object sender, EventArgs e)
        {
            Zaplata oknoPlatnosci = new Zaplata(sumaTotalna);

            if (oknoPlatnosci.ShowDialog() == DialogResult.OK)
            {
                string platnosc = oknoPlatnosci.PobierzMetodePlatnosci();
                MessageBox.Show("Zamówienie przyjête!\nKwota do zap³aty: " + sumaTotalna + " z³\nMetoda: " + platnosc, "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Koszyk.Items.Clear();
                sumaTotalna = 0;
                Cena.Text = "0 z³";
            }
        }
    }
}