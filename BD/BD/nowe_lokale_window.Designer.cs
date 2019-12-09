namespace BD
{
    partial class nowe_lokale_window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nr_mieszkania = new System.Windows.Forms.TextBox();
            this.nr_pietra = new System.Windows.Forms.TextBox();
            this.powierzchnia = new System.Windows.Forms.TextBox();
            this.liczba_pokoi = new System.Windows.Forms.TextBox();
            this.cena_m2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lista_budynkow = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dodaj_lokal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer mieszkania";
            // 
            // nr_mieszkania
            // 
            this.nr_mieszkania.Location = new System.Drawing.Point(369, 45);
            this.nr_mieszkania.Name = "nr_mieszkania";
            this.nr_mieszkania.Size = new System.Drawing.Size(100, 22);
            this.nr_mieszkania.TabIndex = 1;
            // 
            // nr_pietra
            // 
            this.nr_pietra.Location = new System.Drawing.Point(369, 104);
            this.nr_pietra.Name = "nr_pietra";
            this.nr_pietra.Size = new System.Drawing.Size(100, 22);
            this.nr_pietra.TabIndex = 2;
            // 
            // powierzchnia
            // 
            this.powierzchnia.Location = new System.Drawing.Point(369, 160);
            this.powierzchnia.Name = "powierzchnia";
            this.powierzchnia.Size = new System.Drawing.Size(100, 22);
            this.powierzchnia.TabIndex = 3;
            // 
            // liczba_pokoi
            // 
            this.liczba_pokoi.Location = new System.Drawing.Point(369, 227);
            this.liczba_pokoi.Name = "liczba_pokoi";
            this.liczba_pokoi.Size = new System.Drawing.Size(100, 22);
            this.liczba_pokoi.TabIndex = 4;
            // 
            // cena_m2
            // 
            this.cena_m2.Location = new System.Drawing.Point(369, 291);
            this.cena_m2.Name = "cena_m2";
            this.cena_m2.Size = new System.Drawing.Size(100, 22);
            this.cena_m2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numer piętra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Powierzchnia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Liczba pokoi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cena za m2";
            // 
            // lista_budynkow
            // 
            this.lista_budynkow.FormattingEnabled = true;
            this.lista_budynkow.Location = new System.Drawing.Point(12, 45);
            this.lista_budynkow.Name = "lista_budynkow";
            this.lista_budynkow.Size = new System.Drawing.Size(223, 55);
            this.lista_budynkow.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wybierz budynek";
            // 
            // dodaj_lokal
            // 
            this.dodaj_lokal.Location = new System.Drawing.Point(266, 397);
            this.dodaj_lokal.Name = "dodaj_lokal";
            this.dodaj_lokal.Size = new System.Drawing.Size(203, 41);
            this.dodaj_lokal.TabIndex = 12;
            this.dodaj_lokal.Text = "Dodaj";
            this.dodaj_lokal.UseVisualStyleBackColor = true;
            // 
            // nowe_lokale_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dodaj_lokal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lista_budynkow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cena_m2);
            this.Controls.Add(this.liczba_pokoi);
            this.Controls.Add(this.powierzchnia);
            this.Controls.Add(this.nr_pietra);
            this.Controls.Add(this.nr_mieszkania);
            this.Controls.Add(this.label1);
            this.Name = "nowe_lokale_window";
            this.Text = "Nowy lokal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nr_mieszkania;
        private System.Windows.Forms.TextBox nr_pietra;
        private System.Windows.Forms.TextBox powierzchnia;
        private System.Windows.Forms.TextBox liczba_pokoi;
        private System.Windows.Forms.TextBox cena_m2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox lista_budynkow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dodaj_lokal;
    }
}