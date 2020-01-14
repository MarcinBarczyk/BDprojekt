namespace BD
{
    partial class podwykonawca_window
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
            this.firma_nazwa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.data_zlecenia = new System.Windows.Forms.DateTimePicker();
            this.do_realizacji = new System.Windows.Forms.Button();
            this.wykonywane_przez_firme = new System.Windows.Forms.CheckedListBox();
            this.data_zakonczenia = new System.Windows.Forms.DateTimePicker();
            this.zakoncz_realizacje = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._userHelp = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // firma_nazwa
            // 
            this._userHelp.SetHelpString(this.firma_nazwa, "Formularz przypisania firmie zewnetrznej zlecenia do realizacji. Nalezy wprowadzi" +
        "c potrzebne dane oraz wzisnac przycisk \"Dodaj\".");
            this.firma_nazwa.Location = new System.Drawing.Point(28, 45);
            this.firma_nazwa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firma_nazwa.Name = "firma_nazwa";
            this._userHelp.SetShowHelp(this.firma_nazwa, true);
            this.firma_nazwa.Size = new System.Drawing.Size(98, 20);
            this.firma_nazwa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this._userHelp.SetHelpString(this.label1, "Formularz przypisania firmie zewnetrznej zlecenia do realizacji. Nalezy wprowadzi" +
        "c potrzebne dane oraz wzisnac przycisk \"Dodaj\".");
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this._userHelp.SetShowHelp(this.label1, true);
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa firmy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this._userHelp.SetHelpString(this.label2, "Formularz przypisania firmie zewnetrznej zlecenia do realizacji. Nalezy wprowadzi" +
        "c potrzebne dane oraz wzisnac przycisk \"Dodaj\".");
            this.label2.Location = new System.Drawing.Point(26, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this._userHelp.SetShowHelp(this.label2, true);
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data zlecenia";
            // 
            // data_zlecenia
            // 
            this.data_zlecenia.CustomFormat = "yyyy-mm-dd hh:mm:ss.mmm";
            this._userHelp.SetHelpString(this.data_zlecenia, "Formularz przypisania firmie zewnetrznej zlecenia do realizacji. Nalezy wprowadzi" +
        "c potrzebne dane oraz wzisnac przycisk \"Dodaj\".");
            this.data_zlecenia.Location = new System.Drawing.Point(28, 110);
            this.data_zlecenia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_zlecenia.Name = "data_zlecenia";
            this._userHelp.SetShowHelp(this.data_zlecenia, true);
            this.data_zlecenia.Size = new System.Drawing.Size(209, 20);
            this.data_zlecenia.TabIndex = 3;
            this.data_zlecenia.ValueChanged += new System.EventHandler(this.data_zlecenia_ValueChanged);
            // 
            // do_realizacji
            // 
            this._userHelp.SetHelpString(this.do_realizacji, "Formularz przypisania firmie zewnetrznej zlecenia do realizacji. Nalezy wprowadzi" +
        "c potrzebne dane oraz wzisnac przycisk \"Dodaj\".");
            this.do_realizacji.Location = new System.Drawing.Point(28, 151);
            this.do_realizacji.Name = "do_realizacji";
            this._userHelp.SetShowHelp(this.do_realizacji, true);
            this.do_realizacji.Size = new System.Drawing.Size(120, 34);
            this.do_realizacji.TabIndex = 4;
            this.do_realizacji.Text = "Dodaj do realizacji";
            this.do_realizacji.UseVisualStyleBackColor = true;
            this.do_realizacji.Click += new System.EventHandler(this.do_realizacji_Click);
            // 
            // wykonywane_przez_firme
            // 
            this.wykonywane_przez_firme.FormattingEnabled = true;
            this._userHelp.SetHelpString(this.wykonywane_przez_firme, "Formularz pozwalajacy na zaraportowanie zakonczenia zlecenia. Nalezy zaznaczyc in" +
        "teresujace nas zlecenia uzupelnic pole z data zakonczenia a nastepnie nacisnac p" +
        "rzyciswk \"Zakończ\".");
            this.wykonywane_przez_firme.Location = new System.Drawing.Point(362, 45);
            this.wykonywane_przez_firme.Name = "wykonywane_przez_firme";
            this._userHelp.SetShowHelp(this.wykonywane_przez_firme, true);
            this.wykonywane_przez_firme.Size = new System.Drawing.Size(208, 49);
            this.wykonywane_przez_firme.TabIndex = 5;
            // 
            // data_zakonczenia
            // 
            this._userHelp.SetHelpString(this.data_zakonczenia, "Formularz pozwalajacy na zaraportowanie zakonczenia zlecenia. Nalezy zaznaczyc in" +
        "teresujace nas zlecenia uzupelnic pole z data zakonczenia a nastepnie nacisnac p" +
        "rzyciswk \"Zakończ\".");
            this.data_zakonczenia.Location = new System.Drawing.Point(362, 156);
            this.data_zakonczenia.Name = "data_zakonczenia";
            this._userHelp.SetShowHelp(this.data_zakonczenia, true);
            this.data_zakonczenia.Size = new System.Drawing.Size(222, 20);
            this.data_zakonczenia.TabIndex = 6;
            this.data_zakonczenia.ValueChanged += new System.EventHandler(this.data_zakonczenia_ValueChanged);
            // 
            // zakoncz_realizacje
            // 
            this._userHelp.SetHelpString(this.zakoncz_realizacje, "Formularz pozwalajacy na zaraportowanie zakonczenia zlecenia. Nalezy zaznaczyc in" +
        "teresujace nas zlecenia uzupelnic pole z data zakonczenia a nastepnie nacisnac p" +
        "rzyciswk \"Zakończ\".");
            this.zakoncz_realizacje.Location = new System.Drawing.Point(405, 191);
            this.zakoncz_realizacje.Name = "zakoncz_realizacje";
            this._userHelp.SetShowHelp(this.zakoncz_realizacje, true);
            this.zakoncz_realizacje.Size = new System.Drawing.Size(138, 36);
            this.zakoncz_realizacje.TabIndex = 7;
            this.zakoncz_realizacje.Text = "Zakończ";
            this.zakoncz_realizacje.UseVisualStyleBackColor = true;
            this.zakoncz_realizacje.Click += new System.EventHandler(this.zakoncz_realizacje_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this._userHelp.SetHelpString(this.label3, "Formularz pozwalajacy na zaraportowanie zakonczenia zlecenia. Nalezy zaznaczyc in" +
        "teresujace nas zlecenia uzupelnic pole z data zakonczenia a nastepnie nacisnac p" +
        "rzyciswk \"Zakończ\".");
            this.label3.Location = new System.Drawing.Point(359, 9);
            this.label3.Name = "label3";
            this._userHelp.SetShowHelp(this.label3, true);
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wykonywane remonty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this._userHelp.SetHelpString(this.label4, "Formularz pozwalajacy na zaraportowanie zakonczenia zlecenia. Nalezy zaznaczyc in" +
        "teresujace nas zlecenia uzupelnic pole z data zakonczenia a nastepnie nacisnac p" +
        "rzyciswk \"Zakończ\".");
            this.label4.Location = new System.Drawing.Point(359, 130);
            this.label4.Name = "label4";
            this._userHelp.SetShowHelp(this.label4, true);
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data zakończenia";
            // 
            // podwykonawca_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zakoncz_realizacje);
            this.Controls.Add(this.data_zakonczenia);
            this.Controls.Add(this.wykonywane_przez_firme);
            this.Controls.Add(this.do_realizacji);
            this.Controls.Add(this.data_zlecenia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firma_nazwa);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "podwykonawca_window";
            this.Text = "Podwykonawca";
            this.Load += new System.EventHandler(this.podwykonawca_window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firma_nazwa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker data_zlecenia;
        private System.Windows.Forms.Button do_realizacji;
        private System.Windows.Forms.CheckedListBox wykonywane_przez_firme;
        private System.Windows.Forms.DateTimePicker data_zakonczenia;
        private System.Windows.Forms.Button zakoncz_realizacje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HelpProvider _userHelp;
    }
}