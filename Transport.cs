using System;
using System.Windows.Forms;

namespace Apka_do_jedzenia
{
    public partial class Transport : Form
    {
        public Transport()
        {
            InitializeComponent();
        }
        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {
            global.WybranyTransport = "";
            global.KosztTransporty = 0;

            if (checkBox1.Checked)
            {
                global.WybranyTransport = "Odbiór osobisty";
                global.KosztTransporty = 0;
            }
            else if (checkBox2.Checked)
            {
                global.WybranyTransport = "Dostawa przez kuriera";
                global.KosztTransporty = 15;
            }
            else if (checkBox3.Checked)
            {
                global.WybranyTransport = "Dostawa przez aplikację";
                global.KosztTransporty = 20;
            }
            else if (checkBox4.Checked)
            {
                global.WybranyTransport = "Jedzenie na miejscu";
                global.KosztTransporty = 0;
            }
            else
            {
                MessageBox.Show("Proszę wybrać opcję transportu.");
                return; 
            }

            this.DialogResult = DialogResult.OK; 
            this.Close();
        }
    }
}