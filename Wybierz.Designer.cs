namespace Apka_do_jedzenia
{
    partial class Wybierz
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            listBoxMenu = new ListBox();
            Dodaj = new Button();
            listBoxLokalnyKoszyk = new ListBox();
            buttonZatwierdzenie = new Button();
            numericUpDownIlosc = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIlosc).BeginInit();
            SuspendLayout();
            // 
            // listBoxMenu
            // 
            listBoxMenu.FormattingEnabled = true;
            listBoxMenu.ItemHeight = 15;
            listBoxMenu.Location = new Point(12, 12);
            listBoxMenu.Name = "listBoxMenu";
            listBoxMenu.Size = new Size(248, 349);
            listBoxMenu.TabIndex = 0;
            // 
            // Dodaj
            // 
            Dodaj.Location = new Point(269, 157);
            Dodaj.Name = "Dodaj";
            Dodaj.Size = new Size(94, 45);
            Dodaj.TabIndex = 1;
            Dodaj.Text = "Dodaj ->";
            Dodaj.UseVisualStyleBackColor = true;
            Dodaj.Click += Dodaj_Click;
            // 
            // listBoxLokalnyKoszyk
            // 
            listBoxLokalnyKoszyk.FormattingEnabled = true;
            listBoxLokalnyKoszyk.ItemHeight = 15;
            listBoxLokalnyKoszyk.Location = new Point(369, 12);
            listBoxLokalnyKoszyk.Name = "listBoxLokalnyKoszyk";
            listBoxLokalnyKoszyk.Size = new Size(182, 349);
            listBoxLokalnyKoszyk.TabIndex = 2;
            // 
            // buttonZatwierdzenie
            // 
            buttonZatwierdzenie.Location = new Point(369, 383);
            buttonZatwierdzenie.Name = "buttonZatwierdzenie";
            buttonZatwierdzenie.Size = new Size(182, 45);
            buttonZatwierdzenie.TabIndex = 3;
            buttonZatwierdzenie.Text = "Wyślij zamówienie";
            buttonZatwierdzenie.UseVisualStyleBackColor = true;
            buttonZatwierdzenie.Click += buttonZatwierdzenie_Click;
            // 
            // numericUpDownIlosc
            // 
            numericUpDownIlosc.Location = new Point(269, 128);
            numericUpDownIlosc.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownIlosc.Name = "numericUpDownIlosc";
            numericUpDownIlosc.Size = new Size(32, 23);
            numericUpDownIlosc.TabIndex = 4;
            numericUpDownIlosc.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Wybierz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 440);
            Controls.Add(numericUpDownIlosc);
            Controls.Add(buttonZatwierdzenie);
            Controls.Add(listBoxLokalnyKoszyk);
            Controls.Add(Dodaj);
            Controls.Add(listBoxMenu);
            Name = "Wybierz";
            Text = "Zamówienie";
            ((System.ComponentModel.ISupportInitialize)numericUpDownIlosc).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.Button Dodaj;
        private ListBox listBoxLokalnyKoszyk;
        private Button buttonZatwierdzenie;
        private NumericUpDown numericUpDownIlosc;
    }
}