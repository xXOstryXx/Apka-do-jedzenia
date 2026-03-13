namespace Apka_do_jedzenia
{
    partial class Transport
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
            checkBox1 = new System.Windows.Forms.CheckBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            checkBox3 = new System.Windows.Forms.CheckBox();
            checkBox4 = new System.Windows.Forms.CheckBox();
            buttonZatwierdz = new System.Windows.Forms.Button();
            SuspendLayout();
            // checkBox1
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(31, 23);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(110, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Odbiór osobisty";
            checkBox1.UseVisualStyleBackColor = true;
            // checkBox2
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(31, 48);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(120, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Dostawa (lokalna)";
            checkBox2.UseVisualStyleBackColor = true;
            // checkBox3
            checkBox3.AutoSize = true;
            checkBox3.Location = new System.Drawing.Point(31, 73);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(128, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Dostawa (aplikacja)";
            checkBox3.UseVisualStyleBackColor = true;
            // checkBox4
            checkBox4.AutoSize = true;
            checkBox4.Location = new System.Drawing.Point(31, 98);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new System.Drawing.Size(85, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Na miejscu";
            checkBox4.UseVisualStyleBackColor = true;
            // buttonZatwierdz
            buttonZatwierdz.Location = new System.Drawing.Point(31, 133);
            buttonZatwierdz.Name = "buttonZatwierdz";
            buttonZatwierdz.Size = new System.Drawing.Size(100, 23);
            buttonZatwierdz.TabIndex = 4;
            buttonZatwierdz.Text = "Zatwierdź";
            buttonZatwierdz.UseVisualStyleBackColor = true;
            buttonZatwierdz.Click += new System.EventHandler(buttonZatwierdz_Click);
            // Transport
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(220, 180);
            Controls.Add(buttonZatwierdz);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Transport";
            Text = "Transport";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button buttonZatwierdz;
    }
}