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
            this.components = new System.ComponentModel.Container();
            this.remonty_dla_admina = new System.Windows.Forms.CheckedListBox();
            this.Data_poczatkowa = new System.Windows.Forms.DateTimePicker();
            this.Data_koncowa = new System.Windows.Forms.DateTimePicker();
            this.Data_p = new System.Windows.Forms.Label();
            this.Data_k = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Button();
            this.do_realizacji = new System.Windows.Forms.Button();
            this.dodawanie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.potwierdzenie_realizacji = new System.Windows.Forms.Button();
            this.dodawanie_uzytkownika = new System.Windows.Forms.RadioButton();
            this.dodawanie_budynku = new System.Windows.Forms.RadioButton();
            this.dodawanie_umowy = new System.Windows.Forms.RadioButton();
            this.dodawanie_lokali = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idzgłoszeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typzgłoszeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datazgłoszeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datarealizacjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbudynkuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlokaluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idużytkownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zgłoszenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administracjaBudynkamiDataSet = new BD.AdministracjaBudynkamiDataSet();
            this.lista_budynkow = new System.Windows.Forms.ListBox();
            this.wyswietl_budynki = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.w_realizacji = new System.Windows.Forms.ListBox();
            this.zgłoszenieTableAdapter = new BD.AdministracjaBudynkamiDataSetTableAdapters.zgłoszenieTableAdapter();
            this.administracjaBudynkamiDataSet1 = new BD.AdministracjaBudynkamiDataSet();
            this.budynekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budynekTableAdapter = new BD.AdministracjaBudynkamiDataSetTableAdapters.budynekTableAdapter();
            this.administracjaBudynkamiDataSet2 = new BD.AdministracjaBudynkamiDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgłoszenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budynekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // remonty_dla_admina
            // 
            this.remonty_dla_admina.FormattingEnabled = true;
            this.remonty_dla_admina.Location = new System.Drawing.Point(9, 266);
            this.remonty_dla_admina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.remonty_dla_admina.Name = "remonty_dla_admina";
            this.remonty_dla_admina.Size = new System.Drawing.Size(266, 49);
            this.remonty_dla_admina.TabIndex = 4;
            this.remonty_dla_admina.SelectedIndexChanged += new System.EventHandler(this.W_realizacji_SelectedIndexChanged);
            // 
            // Data_poczatkowa
            // 
            this.Data_poczatkowa.Location = new System.Drawing.Point(523, 307);
            this.Data_poczatkowa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Data_poczatkowa.Name = "Data_poczatkowa";
            this.Data_poczatkowa.Size = new System.Drawing.Size(233, 20);
            this.Data_poczatkowa.TabIndex = 6;
            this.Data_poczatkowa.ValueChanged += new System.EventHandler(this.Data_poczatkowa_ValueChanged);
            // 
            // Data_koncowa
            // 
            this.Data_koncowa.Location = new System.Drawing.Point(523, 368);
            this.Data_koncowa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Data_koncowa.Name = "Data_koncowa";
            this.Data_koncowa.Size = new System.Drawing.Size(233, 20);
            this.Data_koncowa.TabIndex = 7;
            // 
            // Data_p
            // 
            this.Data_p.AutoSize = true;
            this.Data_p.Location = new System.Drawing.Point(523, 291);
            this.Data_p.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Data_p.Name = "Data_p";
            this.Data_p.Size = new System.Drawing.Size(156, 13);
            this.Data_p.TabIndex = 8;
            this.Data_p.Text = "Wybierz datę początku zakresu";
            // 
            // Data_k
            // 
            this.Data_k.AutoSize = true;
            this.Data_k.Location = new System.Drawing.Point(521, 351);
            this.Data_k.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Data_k.Name = "Data_k";
            this.Data_k.Size = new System.Drawing.Size(142, 13);
            this.Data_k.TabIndex = 9;
            this.Data_k.Text = "Wybierz datę końca zakresu";
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(523, 407);
            this.Data.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(68, 28);
            this.Data.TabIndex = 10;
            this.Data.Text = "Potwierdź";
            this.Data.UseVisualStyleBackColor = true;
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // do_realizacji
            // 
            this.do_realizacji.Location = new System.Drawing.Point(297, 266);
            this.do_realizacji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.do_realizacji.Name = "do_realizacji";
            this.do_realizacji.Size = new System.Drawing.Size(86, 58);
            this.do_realizacji.TabIndex = 11;
            this.do_realizacji.Text = "Dodaj do realizacji";
            this.do_realizacji.UseVisualStyleBackColor = true;
            this.do_realizacji.Click += new System.EventHandler(this.Zgloszenia_Click);
            // 
            // dodawanie
            // 
            this.dodawanie.Location = new System.Drawing.Point(616, 98);
            this.dodawanie.Name = "dodawanie";
            this.dodawanie.Size = new System.Drawing.Size(138, 46);
            this.dodawanie.TabIndex = 14;
            this.dodawanie.Text = "Dodaj";
            this.dodawanie.UseVisualStyleBackColor = true;
            this.dodawanie.Click += new System.EventHandler(this.dodawanie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Wszystkie zgłoszenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Zgłoszone remonty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Remonty w trakcie realizacji";
            // 
            // potwierdzenie_realizacji
            // 
            this.potwierdzenie_realizacji.Location = new System.Drawing.Point(297, 378);
            this.potwierdzenie_realizacji.Name = "potwierdzenie_realizacji";
            this.potwierdzenie_realizacji.Size = new System.Drawing.Size(86, 57);
            this.potwierdzenie_realizacji.TabIndex = 21;
            this.potwierdzenie_realizacji.Text = "Potwierdź zrealizowanie";
            this.potwierdzenie_realizacji.UseVisualStyleBackColor = true;
            this.potwierdzenie_realizacji.Click += new System.EventHandler(this.potwierdzenie_realizacji_Click);
            // 
            // dodawanie_uzytkownika
            // 
            this.dodawanie_uzytkownika.AutoSize = true;
            this.dodawanie_uzytkownika.Location = new System.Drawing.Point(616, 6);
            this.dodawanie_uzytkownika.Name = "dodawanie_uzytkownika";
            this.dodawanie_uzytkownika.Size = new System.Drawing.Size(115, 17);
            this.dodawanie_uzytkownika.TabIndex = 22;
            this.dodawanie_uzytkownika.TabStop = true;
            this.dodawanie_uzytkownika.Text = "Dodaj użytkownika";
            this.dodawanie_uzytkownika.UseVisualStyleBackColor = true;
            this.dodawanie_uzytkownika.CheckedChanged += new System.EventHandler(this.dodawanie_uzytkownika_CheckedChanged);
            // 
            // dodawanie_budynku
            // 
            this.dodawanie_budynku.AutoSize = true;
            this.dodawanie_budynku.Location = new System.Drawing.Point(616, 52);
            this.dodawanie_budynku.Name = "dodawanie_budynku";
            this.dodawanie_budynku.Size = new System.Drawing.Size(97, 17);
            this.dodawanie_budynku.TabIndex = 23;
            this.dodawanie_budynku.TabStop = true;
            this.dodawanie_budynku.Text = "Dodaj budynek";
            this.dodawanie_budynku.UseVisualStyleBackColor = true;
            // 
            // dodawanie_umowy
            // 
            this.dodawanie_umowy.AutoSize = true;
            this.dodawanie_umowy.Location = new System.Drawing.Point(616, 29);
            this.dodawanie_umowy.Name = "dodawanie_umowy";
            this.dodawanie_umowy.Size = new System.Drawing.Size(135, 17);
            this.dodawanie_umowy.TabIndex = 24;
            this.dodawanie_umowy.TabStop = true;
            this.dodawanie_umowy.Text = "Dodaj umowę/najemcę";
            this.dodawanie_umowy.UseVisualStyleBackColor = true;
            this.dodawanie_umowy.CheckedChanged += new System.EventHandler(this.dodawanie_umowy_CheckedChanged);
            // 
            // dodawanie_lokali
            // 
            this.dodawanie_lokali.AutoSize = true;
            this.dodawanie_lokali.Location = new System.Drawing.Point(616, 76);
            this.dodawanie_lokali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dodawanie_lokali.Name = "dodawanie_lokali";
            this.dodawanie_lokali.Size = new System.Drawing.Size(78, 17);
            this.dodawanie_lokali.TabIndex = 25;
            this.dodawanie_lokali.TabStop = true;
            this.dodawanie_lokali.Text = "Dodaj lokal";
            this.dodawanie_lokali.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzgłoszeniaDataGridViewTextBoxColumn,
            this.typzgłoszeniaDataGridViewTextBoxColumn,
            this.datazgłoszeniaDataGridViewTextBoxColumn,
            this.datarealizacjiDataGridViewTextBoxColumn,
            this.idbudynkuDataGridViewTextBoxColumn,
            this.idlokaluDataGridViewTextBoxColumn,
            this.idużytkownikaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zgłoszenieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(581, 137);
            this.dataGridView1.TabIndex = 26;
            // 
            // idzgłoszeniaDataGridViewTextBoxColumn
            // 
            this.idzgłoszeniaDataGridViewTextBoxColumn.DataPropertyName = "id_zgłoszenia";
            this.idzgłoszeniaDataGridViewTextBoxColumn.HeaderText = "id_zgłoszenia";
            this.idzgłoszeniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idzgłoszeniaDataGridViewTextBoxColumn.Name = "idzgłoszeniaDataGridViewTextBoxColumn";
            this.idzgłoszeniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // typzgłoszeniaDataGridViewTextBoxColumn
            // 
            this.typzgłoszeniaDataGridViewTextBoxColumn.DataPropertyName = "typ_zgłoszenia";
            this.typzgłoszeniaDataGridViewTextBoxColumn.HeaderText = "typ_zgłoszenia";
            this.typzgłoszeniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typzgłoszeniaDataGridViewTextBoxColumn.Name = "typzgłoszeniaDataGridViewTextBoxColumn";
            this.typzgłoszeniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datazgłoszeniaDataGridViewTextBoxColumn
            // 
            this.datazgłoszeniaDataGridViewTextBoxColumn.DataPropertyName = "data_zgłoszenia";
            this.datazgłoszeniaDataGridViewTextBoxColumn.HeaderText = "data_zgłoszenia";
            this.datazgłoszeniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datazgłoszeniaDataGridViewTextBoxColumn.Name = "datazgłoszeniaDataGridViewTextBoxColumn";
            this.datazgłoszeniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datarealizacjiDataGridViewTextBoxColumn
            // 
            this.datarealizacjiDataGridViewTextBoxColumn.DataPropertyName = "data_realizacji";
            this.datarealizacjiDataGridViewTextBoxColumn.HeaderText = "data_realizacji";
            this.datarealizacjiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datarealizacjiDataGridViewTextBoxColumn.Name = "datarealizacjiDataGridViewTextBoxColumn";
            this.datarealizacjiDataGridViewTextBoxColumn.Width = 125;
            // 
            // idbudynkuDataGridViewTextBoxColumn
            // 
            this.idbudynkuDataGridViewTextBoxColumn.DataPropertyName = "id_budynku";
            this.idbudynkuDataGridViewTextBoxColumn.HeaderText = "id_budynku";
            this.idbudynkuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbudynkuDataGridViewTextBoxColumn.Name = "idbudynkuDataGridViewTextBoxColumn";
            this.idbudynkuDataGridViewTextBoxColumn.Width = 125;
            // 
            // idlokaluDataGridViewTextBoxColumn
            // 
            this.idlokaluDataGridViewTextBoxColumn.DataPropertyName = "id_lokalu";
            this.idlokaluDataGridViewTextBoxColumn.HeaderText = "id_lokalu";
            this.idlokaluDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idlokaluDataGridViewTextBoxColumn.Name = "idlokaluDataGridViewTextBoxColumn";
            this.idlokaluDataGridViewTextBoxColumn.Width = 125;
            // 
            // idużytkownikaDataGridViewTextBoxColumn
            // 
            this.idużytkownikaDataGridViewTextBoxColumn.DataPropertyName = "id_użytkownika";
            this.idużytkownikaDataGridViewTextBoxColumn.HeaderText = "id_użytkownika";
            this.idużytkownikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idużytkownikaDataGridViewTextBoxColumn.Name = "idużytkownikaDataGridViewTextBoxColumn";
            this.idużytkownikaDataGridViewTextBoxColumn.Width = 125;
            // 
            // zgłoszenieBindingSource
            // 
            this.zgłoszenieBindingSource.DataMember = "zgłoszenie";
            this.zgłoszenieBindingSource.DataSource = this.administracjaBudynkamiDataSet;
            // 
            // administracjaBudynkamiDataSet
            // 
            this.administracjaBudynkamiDataSet.DataSetName = "AdministracjaBudynkamiDataSet";
            this.administracjaBudynkamiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lista_budynkow
            // 
            this.lista_budynkow.FormattingEnabled = true;
            this.lista_budynkow.Location = new System.Drawing.Point(8, 24);
            this.lista_budynkow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lista_budynkow.Name = "lista_budynkow";
            this.lista_budynkow.Size = new System.Drawing.Size(97, 56);
            this.lista_budynkow.TabIndex = 27;
            this.lista_budynkow.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // wyswietl_budynki
            // 
            this.wyswietl_budynki.Location = new System.Drawing.Point(136, 27);
            this.wyswietl_budynki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wyswietl_budynki.Name = "wyswietl_budynki";
            this.wyswietl_budynki.Size = new System.Drawing.Size(100, 55);
            this.wyswietl_budynki.TabIndex = 28;
            this.wyswietl_budynki.Text = "Wyświetl identyfokatory budynków";
            this.wyswietl_budynki.UseVisualStyleBackColor = true;
            this.wyswietl_budynki.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Identyfikator budynku";
            // 
            // w_realizacji
            // 
            this.w_realizacji.FormattingEnabled = true;
            this.w_realizacji.Location = new System.Drawing.Point(8, 378);
            this.w_realizacji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.w_realizacji.Name = "w_realizacji";
            this.w_realizacji.Size = new System.Drawing.Size(266, 56);
            this.w_realizacji.TabIndex = 30;
            this.w_realizacji.SelectedIndexChanged += new System.EventHandler(this.w_realizacji_SelectedIndexChanged_1);
            // 
            // zgłoszenieTableAdapter
            // 
            this.zgłoszenieTableAdapter.ClearBeforeFill = true;
            // 
            // administracjaBudynkamiDataSet1
            // 
            this.administracjaBudynkamiDataSet1.DataSetName = "AdministracjaBudynkamiDataSet1";
            this.administracjaBudynkamiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budynekBindingSource
            // 
            this.budynekBindingSource.DataMember = "budynek";
            this.budynekBindingSource.DataSource = this.administracjaBudynkamiDataSet1;
            // 
            // budynekTableAdapter
            // 
            this.budynekTableAdapter.ClearBeforeFill = true;
            // 
            // administracjaBudynkamiDataSet2
            // 
            this.administracjaBudynkamiDataSet2.DataSetName = "AdministracjaBudynkamiDataSet";
            this.administracjaBudynkamiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admin_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 446);
            this.Controls.Add(this.w_realizacji);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wyswietl_budynki);
            this.Controls.Add(this.lista_budynkow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dodawanie_lokali);
            this.Controls.Add(this.dodawanie_umowy);
            this.Controls.Add(this.dodawanie_budynku);
            this.Controls.Add(this.dodawanie_uzytkownika);
            this.Controls.Add(this.potwierdzenie_realizacji);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodawanie);
            this.Controls.Add(this.do_realizacji);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Data_k);
            this.Controls.Add(this.Data_p);
            this.Controls.Add(this.Data_koncowa);
            this.Controls.Add(this.Data_poczatkowa);
            this.Controls.Add(this.remonty_dla_admina);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "admin_window";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.admin_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgłoszenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budynekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox remonty_dla_admina;
        private System.Windows.Forms.DateTimePicker Data_poczatkowa;
        private System.Windows.Forms.DateTimePicker Data_koncowa;
        private System.Windows.Forms.Label Data_p;
        private System.Windows.Forms.Label Data_k;
        private System.Windows.Forms.Button Data;
        private System.Windows.Forms.Button do_realizacji;
        private System.Windows.Forms.Button dodawanie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button potwierdzenie_realizacji;
        private System.Windows.Forms.RadioButton dodawanie_uzytkownika;
        private System.Windows.Forms.RadioButton dodawanie_budynku;
        private System.Windows.Forms.RadioButton dodawanie_umowy;
        private System.Windows.Forms.RadioButton dodawanie_lokali;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AdministracjaBudynkamiDataSet administracjaBudynkamiDataSet;
        private System.Windows.Forms.BindingSource zgłoszenieBindingSource;
        private AdministracjaBudynkamiDataSetTableAdapters.zgłoszenieTableAdapter zgłoszenieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzgłoszeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typzgłoszeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazgłoszeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datarealizacjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbudynkuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlokaluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idużytkownikaDataGridViewTextBoxColumn;
        private AdministracjaBudynkamiDataSet administracjaBudynkamiDataSet1;
        private System.Windows.Forms.BindingSource budynekBindingSource;
        private AdministracjaBudynkamiDataSetTableAdapters.budynekTableAdapter budynekTableAdapter;
        private System.Windows.Forms.ListBox lista_budynkow;
        private System.Windows.Forms.Button wyswietl_budynki;
        private AdministracjaBudynkamiDataSet administracjaBudynkamiDataSet2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox w_realizacji;
    }
}