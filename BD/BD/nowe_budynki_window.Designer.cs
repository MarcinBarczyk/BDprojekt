namespace BD
{
    partial class nowe_budynki_window
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
            this.miejscowosc = new System.Windows.Forms.TextBox();
            this.ulica = new System.Windows.Forms.TextBox();
            this.liczba_pieter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nr_budynku = new System.Windows.Forms.TextBox();
            this.nazwa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dodaj_budynek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // miejscowosc
            // 
            this.miejscowosc.Location = new System.Drawing.Point(13, 86);
            this.miejscowosc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.miejscowosc.Name = "miejscowosc";
            this.miejscowosc.Size = new System.Drawing.Size(148, 20);
            this.miejscowosc.TabIndex = 0;
            // 
            // ulica
            // 
            this.ulica.Location = new System.Drawing.Point(11, 135);
            this.ulica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ulica.Name = "ulica";
            this.ulica.Size = new System.Drawing.Size(148, 20);
            this.ulica.TabIndex = 1;
            // 
            // liczba_pieter
            // 
            this.liczba_pieter.Location = new System.Drawing.Point(11, 238);
            this.liczba_pieter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.liczba_pieter.Name = "liczba_pieter";
            this.liczba_pieter.Size = new System.Drawing.Size(76, 20);
            this.liczba_pieter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Miejscowość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ulica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liczba pięter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numer budynku";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nr_budynku
            // 
            this.nr_budynku.Location = new System.Drawing.Point(12, 183);
            this.nr_budynku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nr_budynku.Name = "nr_budynku";
            this.nr_budynku.Size = new System.Drawing.Size(148, 20);
            this.nr_budynku.TabIndex = 7;
            // 
            // nazwa
            // 
            this.nazwa.Location = new System.Drawing.Point(12, 32);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(149, 20);
            this.nazwa.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nazwa budynku";
            // 
            // dodaj_budynek
            // 
            this.dodaj_budynek.Location = new System.Drawing.Point(12, 290);
            this.dodaj_budynek.Name = "dodaj_budynek";
            this.dodaj_budynek.Size = new System.Drawing.Size(147, 30);
            this.dodaj_budynek.TabIndex = 10;
            this.dodaj_budynek.Text = "Dodaj";
            this.dodaj_budynek.UseVisualStyleBackColor = true;
            // 
            // nowe_budynki_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 366);
            this.Controls.Add(this.dodaj_budynek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nazwa);
            this.Controls.Add(this.nr_budynku);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liczba_pieter);
            this.Controls.Add(this.ulica);
            this.Controls.Add(this.miejscowosc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "nowe_budynki_window";
            this.Text = "Budynki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox miejscowosc;
        private System.Windows.Forms.TextBox ulica;
        private System.Windows.Forms.TextBox liczba_pieter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nr_budynku;
        private System.Windows.Forms.TextBox nazwa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button dodaj_budynek;
    }
}