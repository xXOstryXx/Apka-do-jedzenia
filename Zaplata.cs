using System;
using System.Windows.Forms;

namespace Apka_do_jedzenia
{
    public partial class Zaplata : Form
    {
        private string WybranaMetodaPlatnosci = "Brak";

        public Zaplata(double KwotaDoZaplaty)
        {
            InitializeComponent();
            labelKwota.Text = "Do zapłaty: " + KwotaDoZaplaty + " zł"; 

            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                radioButton1.Checked = true;
            }
        }
        private void zatwierdz_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                WybranaMetodaPlatnosci = "Gotówka";
            else if (radioButton2.Checked)
                WybranaMetodaPlatnosci = "Kart płatnicza (przy odbiorze)";
            else if (radioButton3.Checked)
                WybranaMetodaPlatnosci = "Karta płatnicza (online)";
            else if (radioButton4.Checked)
                WybranaMetodaPlatnosci = "Blik (przy odbiorze)";

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        
        public string PobierzMetodePlatnosci()
        {
            return WybranaMetodaPlatnosci;
        }
    }
}