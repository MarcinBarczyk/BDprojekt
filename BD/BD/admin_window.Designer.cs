namespace BD
{
    partial class admin_window
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
            this.Budynki = new System.Windows.Forms.ListBox();
            this.Usterki_remonty = new System.Windows.Forms.CheckedListBox();
            this.W_realizacji = new System.Windows.Forms.CheckedListBox();
            this.Data_poczatkowa = new System.Windows.Forms.DateTimePicker();
            this.Data_koncowa = new System.Windows.Forms.DateTimePicker();
            this.Data_p = new System.Windows.Forms.Label();
            this.Data_k = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Button();
            this.Zgloszenia = new System.Windows.Forms.Button();
            this.Realizacja = new System.Windows.Forms.Button();
            this.dodawanie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Budynki
            // 
            this.Budynki.FormattingEnabled = true;
            this.Budynki.Items.AddRange(new object[] {
            "Budynek alfa",
            "Budynek beta",
            "Budynek gamma"});
            this.Budynki.Location = new System.Drawing.Point(9, 10);
            this.Budynki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Budynki.Name = "Budynki";
            this.Budynki.Size = new System.Drawing.Size(175, 30);
            this.Budynki.TabIndex = 0;
            this.Budynki.SelectedIndexChanged += new System.EventHandler(this.Budynki_SelectedIndexChanged);
            // 
            // Usterki_remonty
            // 
            this.Usterki_remonty.FormattingEnabled = true;
            this.Usterki_remonty.Location = new System.Drawing.Point(9, 82);
            this.Usterki_remonty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Usterki_remonty.Name = "Usterki_remonty";
            this.Usterki_remonty.Size = new System.Drawing.Size(191, 49);
            this.Usterki_remonty.TabIndex = 2;
            this.Usterki_remonty.SelectedIndexChanged += new System.EventHandler(this.Usterki_remonty_SelectedIndexChanged);
            // 
            // W_realizacji
            // 
            this.W_realizacji.FormattingEnabled = true;
            this.W_realizacji.Location = new System.Drawing.Point(9, 144);
            this.W_realizacji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W_realizacji.Name = "W_realizacji";
            this.W_realizacji.Size = new System.Drawing.Size(191, 49);
            this.W_realizacji.TabIndex = 4;
            this.W_realizacji.SelectedIndexChanged += new System.EventHandler(this.W_realizacji_SelectedIndexChanged);
            // 
            // Data_poczatkowa
            // 
            this.Data_poczatkowa.Location = new System.Drawing.Point(9, 270);
            this.Data_poczatkowa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Data_poczatkowa.Name = "Data_poczatkowa";
            this.Data_poczatkowa.Size = new System.Drawing.Size(191, 20);
            this.Data_poczatkowa.TabIndex = 6;
            // 
            // Data_koncowa
            // 
            this.Data_koncowa.Location = new System.Drawing.Point(9, 331);
            this.Data_koncowa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Data_koncowa.Name = "Data_koncowa";
            this.Data_koncowa.Size = new System.Drawing.Size(191, 20);
            this.Data_koncowa.TabIndex = 7;
            // 
            // Data_p
            // 
            this.Data_p.AutoSize = true;
            this.Data_p.Location = new System.Drawing.Point(9, 254);
            this.Data_p.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Data_p.Name = "Data_p";
            this.Data_p.Size = new System.Drawing.Size(156, 13);
            this.Data_p.TabIndex = 8;
            this.Data_p.Text = "Wybierz datę początku zakresu";
            // 
            // Data_k
            // 
            this.Data_k.AutoSize = true;
            this.Data_k.Location = new System.Drawing.Point(7, 314);
            this.Data_k.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Data_k.Name = "Data_k";
            this.Data_k.Size = new System.Drawing.Size(142, 13);
            this.Data_k.TabIndex = 9;
            this.Data_k.Text = "Wybierz datę końca zakresu";
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(9, 370);
            this.Data.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(68, 28);
            this.Data.TabIndex = 10;
            this.Data.Text = "Potwierdź";
            this.Data.UseVisualStyleBackColor = true;
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // Zgloszenia
            // 
            this.Zgloszenia.Location = new System.Drawing.Point(222, 82);
            this.Zgloszenia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Zgloszenia.Name = "Zgloszenia";
            this.Zgloszenia.Size = new System.Drawing.Size(86, 49);
            this.Zgloszenia.TabIndex = 11;
            this.Zgloszenia.Text = "Dodaj do realizacji";
            this.Zgloszenia.UseVisualStyleBackColor = true;
            this.Zgloszenia.Click += new System.EventHandler(this.Zgloszenia_Click);
            // 
            // Realizacja
            // 
            this.Realizacja.Location = new System.Drawing.Point(222, 144);
            this.Realizacja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Realizacja.Name = "Realizacja";
            this.Realizacja.Size = new System.Drawing.Size(86, 49);
            this.Realizacja.TabIndex = 12;
            this.Realizacja.Text = "Potwierdź zrealizowanie";
            this.Realizacja.UseVisualStyleBackColor = true;
            this.Realizacja.Click += new System.EventHandler(this.Realizacja_Click);
            // 
            // dodawanie
            // 
            this.dodawanie.Location = new System.Drawing.Point(865, 12);
            this.dodawanie.Name = "dodawanie";
            this.dodawanie.Size = new System.Drawing.Size(138, 46);
            this.dodawanie.TabIndex = 14;
            this.dodawanie.Text = "Dodaj użytkownika";
            this.dodawanie.UseVisualStyleBackColor = true;
            this.dodawanie.Click += new System.EventHandler(this.dodawanie_Click);
            // 
            // admin_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 446);
            this.Controls.Add(this.dodawanie);
            this.Controls.Add(this.Realizacja);
            this.Controls.Add(this.Zgloszenia);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Data_k);
            this.Controls.Add(this.Data_p);
            this.Controls.Add(this.Data_koncowa);
            this.Controls.Add(this.Data_poczatkowa);
            this.Controls.Add(this.W_realizacji);
            this.Controls.Add(this.Usterki_remonty);
            this.Controls.Add(this.Budynki);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "admin_window";
            this.Text = "admin_window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Budynki;
        private System.Windows.Forms.CheckedListBox Usterki_remonty;
        private System.Windows.Forms.CheckedListBox W_realizacji;
        private System.Windows.Forms.DateTimePicker Data_poczatkowa;
        private System.Windows.Forms.DateTimePicker Data_koncowa;
        private System.Windows.Forms.Label Data_p;
        private System.Windows.Forms.Label Data_k;
        private System.Windows.Forms.Button Data;
        private System.Windows.Forms.Button Zgloszenia;
        private System.Windows.Forms.Button Realizacja;
        private System.Windows.Forms.Button dodawanie;
    }
}