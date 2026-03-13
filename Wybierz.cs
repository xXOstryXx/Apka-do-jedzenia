using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Apka_do_jedzenia
{
    public partial class Wybierz : Form
    {
        public List<string> WybraneDaniaFormat { get; private set; } = new List<string>();
        public double SumaCen { get; private set; } = 0;
        private readonly List<MenuItemModel> _menuItems = new()
        {
            new MenuItemModel("Kebab rollo", 25.0),
            new MenuItemModel("Kebab bułka", 30.0),
            new MenuItemModel("Kebab XXL", 45.0)
        };

        public Wybierz()
        {
            InitializeComponent();
            listBoxMenu.DataSource = _menuItems;
            listBoxMenu.DisplayMember = nameof(MenuItemModel.DisplayText);
            listBoxMenu.ValueMember = nameof(MenuItemModel.Name);

            listBoxMenu.SelectionMode = SelectionMode.One;

            AcceptButton = Dodaj;
        }

        private sealed class MenuItemModel
        {
            public string Name { get; }
            public double Price { get; }
            public string DisplayText => $"{Name} - {Price} zł";
            public MenuItemModel(string name, double price)
            {
                Name = name;
                Price = price;
            }
            public override string ToString() => DisplayText;
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.SelectedItem is not MenuItemModel mi)
            {
                MessageBox.Show("Proszę wybrać danie z menu.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ilosc = (int)numericUpDownIlosc.Value;
            double cenaZaWielokrotnosc = mi.Price * ilosc;
            string TekstFormat = ilosc + "x " + mi.Name + " - " + cenaZaWielokrotnosc + " zł";
            listBoxLokalnyKoszyk.Items.Add(TekstFormat);
            WybraneDaniaFormat.Add(TekstFormat);
            SumaCen += cenaZaWielokrotnosc;
            numericUpDownIlosc.Value = 1;
        }

        private void buttonZatwierdzenie_Click(object sender, EventArgs e)
        {
            if (WybraneDaniaFormat.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnych dań. Proszę dodać dania do koszyka.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}