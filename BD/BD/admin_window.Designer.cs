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
            this.Budynek_dane = new System.Windows.Forms.DataGridView();
            this.Usterki_remonty = new System.Windows.Forms.CheckedListBox();
            this.W_realizacji = new System.Windows.Forms.CheckedListBox();
            this.Data_poczatkowa = new System.Windows.Forms.DateTimePicker();
            this.Data_koncowa = new System.Windows.Forms.DateTimePicker();
            this.Data_p = new System.Windows.Forms.Label();
            this.Data_k = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Button();
            this.Zgloszenia = new System.Windows.Forms.Button();
            this.Realizacja = new System.Windows.Forms.Button();
            this.zyski_zakres = new System.Windows.Forms.DataGridView();
            this.zyski = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Budynek_dane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zyski_zakres)).BeginInit();
            this.SuspendLayout();
            // 
            // Budynki
            // 
            this.Budynki.FormattingEnabled = true;
            this.Budynki.ItemHeight = 16;
            this.Budynki.Items.AddRange(new object[] {
            "Budynek alfa",
            "Budynek beta",
            "Budynek gamma"});
            this.Budynki.Location = new System.Drawing.Point(12, 12);
            this.Budynki.Name = "Budynki";
            this.Budynki.Size = new System.Drawing.Size(232, 36);
            this.Budynki.TabIndex = 0;
            this.Budynki.SelectedIndexChanged += new System.EventHandler(this.Budynki_SelectedIndexChanged);
            // 
            // Budynek_dane
            // 
            this.Budynek_dane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Budynek_dane.Location = new System.Drawing.Point(481, 19);
            this.Budynek_dane.Name = "Budynek_dane";
            this.Budynek_dane.RowHeadersWidth = 51;
            this.Budynek_dane.RowTemplate.Height = 24;
            this.Budynek_dane.Size = new System.Drawing.Size(834, 258);
            this.Budynek_dane.TabIndex = 1;
            this.Budynek_dane.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Budynek_dane_CellContentClick);
            // 
            // Usterki_remonty
            // 
            this.Usterki_remonty.FormattingEnabled = true;
            this.Usterki_remonty.Location = new System.Drawing.Point(12, 137);
            this.Usterki_remonty.Name = "Usterki_remonty";
            this.Usterki_remonty.Size = new System.Drawing.Size(253, 55);
            this.Usterki_remonty.TabIndex = 2;
            this.Usterki_remonty.SelectedIndexChanged += new System.EventHandler(this.Usterki_remonty_SelectedIndexChanged);
            // 
            // W_realizacji
            // 
            this.W_realizacji.FormattingEnabled = true;
            this.W_realizacji.Location = new System.Drawing.Point(12, 222);
            this.W_realizacji.Name = "W_realizacji";
            this.W_realizacji.Size = new System.Drawing.Size(253, 55);
            this.W_realizacji.TabIndex = 4;
            this.W_realizacji.SelectedIndexChanged += new System.EventHandler(this.W_realizacji_SelectedIndexChanged);
            // 
            // Data_poczatkowa
            // 
            this.Data_poczatkowa.Location = new System.Drawing.Point(12, 332);
            this.Data_poczatkowa.Name = "Data_poczatkowa";
            this.Data_poczatkowa.Size = new System.Drawing.Size(253, 22);
            this.Data_poczatkowa.TabIndex = 6;
            // 
            // Data_koncowa
            // 
            this.Data_koncowa.Location = new System.Drawing.Point(12, 407);
            this.Data_koncowa.Name = "Data_koncowa";
            this.Data_koncowa.Size = new System.Drawing.Size(253, 22);
            this.Data_koncowa.TabIndex = 7;
            // 
            // Data_p
            // 
            this.Data_p.AutoSize = true;
            this.Data_p.Location = new System.Drawing.Point(12, 312);
            this.Data_p.Name = "Data_p";
            this.Data_p.Size = new System.Drawing.Size(206, 17);
            this.Data_p.TabIndex = 8;
            this.Data_p.Text = "Wybierz datę początku zakresu";
            // 
            // Data_k
            // 
            this.Data_k.AutoSize = true;
            this.Data_k.Location = new System.Drawing.Point(9, 387);
            this.Data_k.Name = "Data_k";
            this.Data_k.Size = new System.Drawing.Size(187, 17);
            this.Data_k.TabIndex = 9;
            this.Data_k.Text = "Wybierz datę końca zakresu";
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(12, 455);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(91, 34);
            this.Data.TabIndex = 10;
            this.Data.Text = "Potwierdź";
            this.Data.UseVisualStyleBackColor = true;
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // Zgloszenia
            // 
            this.Zgloszenia.Location = new System.Drawing.Point(296, 137);
            this.Zgloszenia.Name = "Zgloszenia";
            this.Zgloszenia.Size = new System.Drawing.Size(114, 55);
            this.Zgloszenia.TabIndex = 11;
            this.Zgloszenia.Text = "Dodaj do realizacji";
            this.Zgloszenia.UseVisualStyleBackColor = true;
            this.Zgloszenia.Click += new System.EventHandler(this.Zgloszenia_Click);
            // 
            // Realizacja
            // 
            this.Realizacja.Location = new System.Drawing.Point(296, 222);
            this.Realizacja.Name = "Realizacja";
            this.Realizacja.Size = new System.Drawing.Size(114, 55);
            this.Realizacja.TabIndex = 12;
            this.Realizacja.Text = "Potwierdź zrealizowanie";
            this.Realizacja.UseVisualStyleBackColor = true;
            this.Realizacja.Click += new System.EventHandler(this.Realizacja_Click);
            // 
            // zyski_zakres
            // 
            this.zyski_zakres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zyski_zakres.Location = new System.Drawing.Point(296, 387);
            this.zyski_zakres.Name = "zyski_zakres";
            this.zyski_zakres.RowHeadersWidth = 51;
            this.zyski_zakres.RowTemplate.Height = 24;
            this.zyski_zakres.Size = new System.Drawing.Size(313, 148);
            this.zyski_zakres.TabIndex = 13;
            // 
            // zyski
            // 
            this.zyski.AutoSize = true;
            this.zyski.Location = new System.Drawing.Point(364, 356);
            this.zyski.Name = "zyski";
            this.zyski.Size = new System.Drawing.Size(173, 17);
            this.zyski.TabIndex = 14;
            this.zyski.Text = "Zyski w podanym zakresie";
            // 
            // admin_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 549);
            this.Controls.Add(this.zyski);
            this.Controls.Add(this.zyski_zakres);
            this.Controls.Add(this.Realizacja);
            this.Controls.Add(this.Zgloszenia);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Data_k);
            this.Controls.Add(this.Data_p);
            this.Controls.Add(this.Data_koncowa);
            this.Controls.Add(this.Data_poczatkowa);
            this.Controls.Add(this.W_realizacji);
            this.Controls.Add(this.Usterki_remonty);
            this.Controls.Add(this.Budynek_dane);
            this.Controls.Add(this.Budynki);
            this.Name = "admin_window";
            this.Text = "admin_window";
            ((System.ComponentModel.ISupportInitialize)(this.Budynek_dane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zyski_zakres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Budynki;
        private System.Windows.Forms.DataGridView Budynek_dane;
        private System.Windows.Forms.CheckedListBox Usterki_remonty;
        private System.Windows.Forms.CheckedListBox W_realizacji;
        private System.Windows.Forms.DateTimePicker Data_poczatkowa;
        private System.Windows.Forms.DateTimePicker Data_koncowa;
        private System.Windows.Forms.Label Data_p;
        private System.Windows.Forms.Label Data_k;
        private System.Windows.Forms.Button Data;
        private System.Windows.Forms.Button Zgloszenia;
        private System.Windows.Forms.Button Realizacja;
        private System.Windows.Forms.DataGridView zyski_zakres;
        private System.Windows.Forms.Label zyski;
    }
}