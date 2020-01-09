namespace BD
{
    partial class konserwator_window
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
            this.do_konserwacji = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dodaj_do_konserwacji = new System.Windows.Forms.Button();
            this.w_konserwacji = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.data_wykonania = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.potwierdz_konserwacje = new System.Windows.Forms.Button();
            this.budynki = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.data_rozpoczecia = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.osoba_odpowiedzialna = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // do_konserwacji
            // 
            this.do_konserwacji.FormattingEnabled = true;
            this.do_konserwacji.Location = new System.Drawing.Point(15, 192);
            this.do_konserwacji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.do_konserwacji.Name = "do_konserwacji";
            this.do_konserwacji.Size = new System.Drawing.Size(339, 89);
            this.do_konserwacji.TabIndex = 0;
            this.do_konserwacji.SelectedIndexChanged += new System.EventHandler(this.do_konserwacji_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podlegają konserwacji";
            // 
            // dodaj_do_konserwacji
            // 
            this.dodaj_do_konserwacji.Location = new System.Drawing.Point(12, 390);
            this.dodaj_do_konserwacji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodaj_do_konserwacji.Name = "dodaj_do_konserwacji";
            this.dodaj_do_konserwacji.Size = new System.Drawing.Size(151, 49);
            this.dodaj_do_konserwacji.TabIndex = 2;
            this.dodaj_do_konserwacji.Text = "Dodaj do realizacji";
            this.dodaj_do_konserwacji.UseVisualStyleBackColor = true;
            this.dodaj_do_konserwacji.Click += new System.EventHandler(this.dodaj_do_konserwacji_Click);
            // 
            // w_konserwacji
            // 
            this.w_konserwacji.FormattingEnabled = true;
            this.w_konserwacji.Location = new System.Drawing.Point(319, 39);
            this.w_konserwacji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.w_konserwacji.Name = "w_konserwacji";
            this.w_konserwacji.Size = new System.Drawing.Size(455, 89);
            this.w_konserwacji.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aktualnie w konserwacji";
            // 
            // data_wykonania
            // 
            this.data_wykonania.Location = new System.Drawing.Point(419, 192);
            this.data_wykonania.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_wykonania.Name = "data_wykonania";
            this.data_wykonania.Size = new System.Drawing.Size(283, 22);
            this.data_wykonania.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data wykonania konserwacji";
            // 
            // potwierdz_konserwacje
            // 
            this.potwierdz_konserwacje.Location = new System.Drawing.Point(419, 332);
            this.potwierdz_konserwacje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.potwierdz_konserwacje.Name = "potwierdz_konserwacje";
            this.potwierdz_konserwacje.Size = new System.Drawing.Size(151, 49);
            this.potwierdz_konserwacje.TabIndex = 7;
            this.potwierdz_konserwacje.Text = "Potwierdź wykonanie";
            this.potwierdz_konserwacje.UseVisualStyleBackColor = true;
            this.potwierdz_konserwacje.Click += new System.EventHandler(this.potwierdz_konserwacje_Click);
            // 
            // budynki
            // 
            this.budynki.FormattingEnabled = true;
            this.budynki.ItemHeight = 16;
            this.budynki.Location = new System.Drawing.Point(15, 39);
            this.budynki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.budynki.Name = "budynki";
            this.budynki.Size = new System.Drawing.Size(114, 68);
            this.budynki.TabIndex = 8;
            this.budynki.SelectedIndexChanged += new System.EventHandler(this.budynki_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wybierz budynek";
            // 
            // data_rozpoczecia
            // 
            this.data_rozpoczecia.Location = new System.Drawing.Point(15, 315);
            this.data_rozpoczecia.Name = "data_rozpoczecia";
            this.data_rozpoczecia.Size = new System.Drawing.Size(339, 22);
            this.data_rozpoczecia.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data rozpoczęcia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Osoba odpowiedzialna";
            // 
            // osoba_odpowiedzialna
            // 
            this.osoba_odpowiedzialna.Location = new System.Drawing.Point(419, 259);
            this.osoba_odpowiedzialna.Name = "osoba_odpowiedzialna";
            this.osoba_odpowiedzialna.Size = new System.Drawing.Size(252, 22);
            this.osoba_odpowiedzialna.TabIndex = 13;
            // 
            // konserwator_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.osoba_odpowiedzialna);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.data_rozpoczecia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.budynki);
            this.Controls.Add(this.potwierdz_konserwacje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data_wykonania);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.w_konserwacji);
            this.Controls.Add(this.dodaj_do_konserwacji);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.do_konserwacji);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "konserwator_window";
            this.Text = "Konserwator";
            this.Load += new System.EventHandler(this.konserwator_window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox do_konserwacji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodaj_do_konserwacji;
        private System.Windows.Forms.CheckedListBox w_konserwacji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker data_wykonania;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button potwierdz_konserwacje;
        private System.Windows.Forms.ListBox budynki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker data_rozpoczecia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox osoba_odpowiedzialna;
    }
}