namespace BD
{
    partial class user_window
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
            this.zgloszenie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.potw_zgloszenia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kwota_przelew = new System.Windows.Forms.TextBox();
            this.data_przelew = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.potwierdzenie_platnosci = new System.Windows.Forms.Button();
            this.data_zgloszenia = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lista_budynkow = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // zgloszenie
            // 
            this.zgloszenie.Location = new System.Drawing.Point(12, 42);
            this.zgloszenie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zgloszenie.Name = "zgloszenie";
            this.zgloszenie.Size = new System.Drawing.Size(215, 22);
            this.zgloszenie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zgłoś usterkę/remont";
            // 
            // potw_zgloszenia
            // 
            this.potw_zgloszenia.Location = new System.Drawing.Point(16, 385);
            this.potw_zgloszenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.potw_zgloszenia.Name = "potw_zgloszenia";
            this.potw_zgloszenia.Size = new System.Drawing.Size(123, 33);
            this.potw_zgloszenia.TabIndex = 2;
            this.potw_zgloszenia.Text = "Dodaj";
            this.potw_zgloszenia.UseVisualStyleBackColor = true;
            this.potw_zgloszenia.Click += new System.EventHandler(this.potw_zgloszenia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Płatności";
            // 
            // kwota_przelew
            // 
            this.kwota_przelew.Location = new System.Drawing.Point(593, 62);
            this.kwota_przelew.Margin = new System.Windows.Forms.Padding(4);
            this.kwota_przelew.Name = "kwota_przelew";
            this.kwota_przelew.Size = new System.Drawing.Size(135, 22);
            this.kwota_przelew.TabIndex = 6;
            // 
            // data_przelew
            // 
            this.data_przelew.Location = new System.Drawing.Point(593, 118);
            this.data_przelew.Margin = new System.Windows.Forms.Padding(4);
            this.data_przelew.Name = "data_przelew";
            this.data_przelew.Size = new System.Drawing.Size(135, 22);
            this.data_przelew.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kwota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data przelewu";
            // 
            // potwierdzenie_platnosci
            // 
            this.potwierdzenie_platnosci.Location = new System.Drawing.Point(593, 188);
            this.potwierdzenie_platnosci.Margin = new System.Windows.Forms.Padding(4);
            this.potwierdzenie_platnosci.Name = "potwierdzenie_platnosci";
            this.potwierdzenie_platnosci.Size = new System.Drawing.Size(136, 37);
            this.potwierdzenie_platnosci.TabIndex = 12;
            this.potwierdzenie_platnosci.Text = "Potwierdź";
            this.potwierdzenie_platnosci.UseVisualStyleBackColor = true;
            this.potwierdzenie_platnosci.Click += new System.EventHandler(this.potwierdzenie_platnosci_Click);
            // 
            // data_zgloszenia
            // 
            this.data_zgloszenia.Location = new System.Drawing.Point(12, 208);
            this.data_zgloszenia.Name = "data_zgloszenia";
            this.data_zgloszenia.Size = new System.Drawing.Size(261, 22);
            this.data_zgloszenia.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Data zgłoszenia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(13, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "(Np. Naprawa okna, remont klatki)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Wybierz budynek";
            // 
            // lista_budynkow
            // 
            this.lista_budynkow.FormattingEnabled = true;
            this.lista_budynkow.Location = new System.Drawing.Point(12, 118);
            this.lista_budynkow.Name = "lista_budynkow";
            this.lista_budynkow.Size = new System.Drawing.Size(240, 55);
            this.lista_budynkow.TabIndex = 18;
            // 
            // user_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lista_budynkow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.data_zgloszenia);
            this.Controls.Add(this.potwierdzenie_platnosci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data_przelew);
            this.Controls.Add(this.kwota_przelew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.potw_zgloszenia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zgloszenie);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "user_window";
            this.Text = "Użytkownik";
            this.Load += new System.EventHandler(this.user_window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zgloszenie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button potw_zgloszenia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kwota_przelew;
        private System.Windows.Forms.DateTimePicker data_przelew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button potwierdzenie_platnosci;
        private System.Windows.Forms.DateTimePicker data_zgloszenia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox lista_budynkow;
    }
}