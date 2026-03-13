namespace Apka_do_jedzenia
{
    partial class Zaplata
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            Zatwierdz = new Button();
            labelKwota = new Label();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(17, 24);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Gotówka";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(17, 49);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(143, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Karta płatnicza (kurier)";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(17, 74);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(143, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Karta płatnicza(online)";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(17, 99);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(48, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "BLIK";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // Zatwierdz
            // 
            Zatwierdz.Location = new Point(70, 155);
            Zatwierdz.Name = "Zatwierdz";
            Zatwierdz.Size = new Size(75, 23);
            Zatwierdz.TabIndex = 4;
            Zatwierdz.Text = "Zatwierdź";
            Zatwierdz.UseVisualStyleBackColor = true;
            Zatwierdz.Click += zatwierdz_Click;
            // 
            // labelKwota
            // 
            labelKwota.AutoSize = true;
            labelKwota.Font = new Font("Segoe UI", 12F);
            labelKwota.Location = new Point(17, 121);
            labelKwota.Name = "labelKwota";
            labelKwota.Size = new Size(86, 21);
            labelKwota.TabIndex = 5;
            labelKwota.Text = "Do zapłaty:";
            // 
            // Zaplata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 190);
            Controls.Add(labelKwota);
            Controls.Add(Zatwierdz);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Zaplata";
            Text = "Opcje płatności";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button Zatwierdz;
        private Label labelKwota;
    }
}