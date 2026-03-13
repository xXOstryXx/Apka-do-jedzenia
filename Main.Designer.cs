namespace Apka_do_jedzenia
{
    partial class Main
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
            Koszyk = new ListView();
            Cena = new TextBox();
            buttonWybierz = new Button();
            buttonTransport = new Button();
            buttonZaplac = new Button();
            SuspendLayout();
            // 
            // Koszyk
            // 
            Koszyk.Location = new Point(12, 12);
            Koszyk.Name = "Koszyk";
            Koszyk.Size = new Size(235, 426);
            Koszyk.TabIndex = 0;
            Koszyk.UseCompatibleStateImageBehavior = false;
            // 
            // Cena
            // 
            Cena.Location = new Point(385, 35);
            Cena.Name = "Cena";
            Cena.ReadOnly = true;
            Cena.Size = new Size(100, 23);
            Cena.TabIndex = 1;
            Cena.Text = "0 zł";
            // 
            // buttonWybierz
            // 
            buttonWybierz.Location = new Point(404, 251);
            buttonWybierz.Name = "buttonWybierz";
            buttonWybierz.Size = new Size(106, 47);
            buttonWybierz.TabIndex = 2;
            buttonWybierz.Text = "Wybierz";
            buttonWybierz.UseVisualStyleBackColor = true;
            buttonWybierz.Click += buttonWybierz_Click;
            // 
            // buttonTransport
            // 
            buttonTransport.Location = new Point(404, 321);
            buttonTransport.Name = "buttonTransport";
            buttonTransport.Size = new Size(106, 48);
            buttonTransport.TabIndex = 3;
            buttonTransport.Text = "Transport";
            buttonTransport.UseVisualStyleBackColor = true;
            buttonTransport.Click += buttonTransport_Click;
            // 
            // buttonZaplac
            // 
            buttonZaplac.Location = new Point(404, 389);
            buttonZaplac.Name = "buttonZaplac";
            buttonZaplac.Size = new Size(106, 49);
            buttonZaplac.TabIndex = 4;
            buttonZaplac.Text = "Zapłać";
            buttonZaplac.UseVisualStyleBackColor = true;
            buttonZaplac.Click += buttonZaplac_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 450);
            Controls.Add(buttonZaplac);
            Controls.Add(buttonTransport);
            Controls.Add(buttonWybierz);
            Controls.Add(Cena);
            Controls.Add(Koszyk);
            Name = "Main";
            Text = "Aplikacja do zamawiania jedzenia";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.ListView Koszyk;
        private System.Windows.Forms.TextBox Cena;
        private System.Windows.Forms.Button buttonWybierz;
        private System.Windows.Forms.Button buttonTransport;
        private System.Windows.Forms.Button buttonZaplac;
    }
}