namespace BD
{
    partial class nowe_umowy_window
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
            this.data_zawarcia_umowy = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imie_najemca = new System.Windows.Forms.TextBox();
            this.nazwisko_najemca = new System.Windows.Forms.TextBox();
            this.pesel_najemca = new System.Windows.Forms.TextBox();
            this.nr_dokumentu_najemca = new System.Windows.Forms.TextBox();
            this.typ_dokumentu_najemca = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dodaj_wynajem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cena_miesiac = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbudynkuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlokaluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrlokaluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrpiętraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powierzchniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczbapokoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenazam2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administracjaBudynkamiDataSet = new BD.AdministracjaBudynkamiDataSet();
            this.lokalTableAdapter = new BD.AdministracjaBudynkamiDataSetTableAdapters.lokalTableAdapter();
            this.id_lokalu_do_wynajecia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.data_zamieszkania = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.data_konca_umowy = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.data_konca_zamieszkania = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idwynajmuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnajemcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imięDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrdokumentuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typdokumentuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.najemcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.najemcaTableAdapter = new BD.AdministracjaBudynkamiDataSetTableAdapters.najemcaTableAdapter();
            this.potwierdz_lokal = new System.Windows.Forms.Button();
            this.dodaj_najemce = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.czynsz_msc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.termin_platnosci = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.wynajemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wynajemTableAdapter = new BD.AdministracjaBudynkamiDataSetTableAdapters.wynajemTableAdapter();
            this.idlokaluDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idwynajmuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenamiesiącDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datazawarciaumowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminpłatnościDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datazamieszkaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datakońcaumowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datakońcazamieszkaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.najemcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynajemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // data_zawarcia_umowy
            // 
            this.data_zawarcia_umowy.Location = new System.Drawing.Point(15, 195);
            this.data_zawarcia_umowy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_zawarcia_umowy.Name = "data_zawarcia_umowy";
            this.data_zawarcia_umowy.Size = new System.Drawing.Size(306, 22);
            this.data_zawarcia_umowy.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data zawarcia umowy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Najemca";
            // 
            // imie_najemca
            // 
            this.imie_najemca.Location = new System.Drawing.Point(473, 49);
            this.imie_najemca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imie_najemca.Name = "imie_najemca";
            this.imie_najemca.Size = new System.Drawing.Size(163, 22);
            this.imie_najemca.TabIndex = 5;
            // 
            // nazwisko_najemca
            // 
            this.nazwisko_najemca.Location = new System.Drawing.Point(473, 93);
            this.nazwisko_najemca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazwisko_najemca.Name = "nazwisko_najemca";
            this.nazwisko_najemca.Size = new System.Drawing.Size(163, 22);
            this.nazwisko_najemca.TabIndex = 6;
            // 
            // pesel_najemca
            // 
            this.pesel_najemca.Location = new System.Drawing.Point(473, 136);
            this.pesel_najemca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pesel_najemca.Name = "pesel_najemca";
            this.pesel_najemca.Size = new System.Drawing.Size(163, 22);
            this.pesel_najemca.TabIndex = 7;
            // 
            // nr_dokumentu_najemca
            // 
            this.nr_dokumentu_najemca.Location = new System.Drawing.Point(473, 184);
            this.nr_dokumentu_najemca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nr_dokumentu_najemca.Name = "nr_dokumentu_najemca";
            this.nr_dokumentu_najemca.Size = new System.Drawing.Size(163, 22);
            this.nr_dokumentu_najemca.TabIndex = 8;
            // 
            // typ_dokumentu_najemca
            // 
            this.typ_dokumentu_najemca.FormattingEnabled = true;
            this.typ_dokumentu_najemca.Location = new System.Drawing.Point(473, 224);
            this.typ_dokumentu_najemca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typ_dokumentu_najemca.Name = "typ_dokumentu_najemca";
            this.typ_dokumentu_najemca.Size = new System.Drawing.Size(208, 72);
            this.typ_dokumentu_najemca.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Imię";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nazwisko";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "PESEL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Numer dokumentu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Typ dokumentu";
            // 
            // dodaj_wynajem
            // 
            this.dodaj_wynajem.Location = new System.Drawing.Point(15, 491);
            this.dodaj_wynajem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodaj_wynajem.Name = "dodaj_wynajem";
            this.dodaj_wynajem.Size = new System.Drawing.Size(141, 46);
            this.dodaj_wynajem.TabIndex = 15;
            this.dodaj_wynajem.Text = "Dodaj wynajem";
            this.dodaj_wynajem.UseVisualStyleBackColor = true;
            this.dodaj_wynajem.Click += new System.EventHandler(this.dodaj_wynajem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cena za mieszkanie";
            // 
            // cena_miesiac
            // 
            this.cena_miesiac.AutoSize = true;
            this.cena_miesiac.Location = new System.Drawing.Point(55, 26);
            this.cena_miesiac.Name = "cena_miesiac";
            this.cena_miesiac.Size = new System.Drawing.Size(0, 17);
            this.cena_miesiac.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbudynkuDataGridViewTextBoxColumn,
            this.idlokaluDataGridViewTextBoxColumn,
            this.nrlokaluDataGridViewTextBoxColumn,
            this.nrpiętraDataGridViewTextBoxColumn,
            this.powierzchniaDataGridViewTextBoxColumn,
            this.liczbapokoiDataGridViewTextBoxColumn,
            this.cenazam2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lokalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(697, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(515, 141);
            this.dataGridView1.TabIndex = 17;
            // 
            // idbudynkuDataGridViewTextBoxColumn
            // 
            this.idbudynkuDataGridViewTextBoxColumn.DataPropertyName = "id_budynku";
            this.idbudynkuDataGridViewTextBoxColumn.HeaderText = "id_budynku";
            this.idbudynkuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbudynkuDataGridViewTextBoxColumn.Name = "idbudynkuDataGridViewTextBoxColumn";
            this.idbudynkuDataGridViewTextBoxColumn.ReadOnly = true;
            this.idbudynkuDataGridViewTextBoxColumn.Width = 125;
            // 
            // idlokaluDataGridViewTextBoxColumn
            // 
            this.idlokaluDataGridViewTextBoxColumn.DataPropertyName = "id_lokalu";
            this.idlokaluDataGridViewTextBoxColumn.HeaderText = "id_lokalu";
            this.idlokaluDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idlokaluDataGridViewTextBoxColumn.Name = "idlokaluDataGridViewTextBoxColumn";
            this.idlokaluDataGridViewTextBoxColumn.ReadOnly = true;
            this.idlokaluDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrlokaluDataGridViewTextBoxColumn
            // 
            this.nrlokaluDataGridViewTextBoxColumn.DataPropertyName = "nr_lokalu";
            this.nrlokaluDataGridViewTextBoxColumn.HeaderText = "nr_lokalu";
            this.nrlokaluDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrlokaluDataGridViewTextBoxColumn.Name = "nrlokaluDataGridViewTextBoxColumn";
            this.nrlokaluDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrlokaluDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrpiętraDataGridViewTextBoxColumn
            // 
            this.nrpiętraDataGridViewTextBoxColumn.DataPropertyName = "nr_piętra";
            this.nrpiętraDataGridViewTextBoxColumn.HeaderText = "nr_piętra";
            this.nrpiętraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrpiętraDataGridViewTextBoxColumn.Name = "nrpiętraDataGridViewTextBoxColumn";
            this.nrpiętraDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrpiętraDataGridViewTextBoxColumn.Width = 125;
            // 
            // powierzchniaDataGridViewTextBoxColumn
            // 
            this.powierzchniaDataGridViewTextBoxColumn.DataPropertyName = "powierzchnia";
            this.powierzchniaDataGridViewTextBoxColumn.HeaderText = "powierzchnia";
            this.powierzchniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.powierzchniaDataGridViewTextBoxColumn.Name = "powierzchniaDataGridViewTextBoxColumn";
            this.powierzchniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.powierzchniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // liczbapokoiDataGridViewTextBoxColumn
            // 
            this.liczbapokoiDataGridViewTextBoxColumn.DataPropertyName = "liczba_pokoi";
            this.liczbapokoiDataGridViewTextBoxColumn.HeaderText = "liczba_pokoi";
            this.liczbapokoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.liczbapokoiDataGridViewTextBoxColumn.Name = "liczbapokoiDataGridViewTextBoxColumn";
            this.liczbapokoiDataGridViewTextBoxColumn.ReadOnly = true;
            this.liczbapokoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // cenazam2DataGridViewTextBoxColumn
            // 
            this.cenazam2DataGridViewTextBoxColumn.DataPropertyName = "cena_za_m2";
            this.cenazam2DataGridViewTextBoxColumn.HeaderText = "cena_za_m2";
            this.cenazam2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenazam2DataGridViewTextBoxColumn.Name = "cenazam2DataGridViewTextBoxColumn";
            this.cenazam2DataGridViewTextBoxColumn.ReadOnly = true;
            this.cenazam2DataGridViewTextBoxColumn.Width = 125;
            // 
            // lokalBindingSource
            // 
            this.lokalBindingSource.DataMember = "lokal";
            this.lokalBindingSource.DataSource = this.administracjaBudynkamiDataSet;
            // 
            // administracjaBudynkamiDataSet
            // 
            this.administracjaBudynkamiDataSet.DataSetName = "AdministracjaBudynkamiDataSet";
            this.administracjaBudynkamiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lokalTableAdapter
            // 
            this.lokalTableAdapter.ClearBeforeFill = true;
            // 
            // id_lokalu_do_wynajecia
            // 
            this.id_lokalu_do_wynajecia.Location = new System.Drawing.Point(15, 26);
            this.id_lokalu_do_wynajecia.Name = "id_lokalu_do_wynajecia";
            this.id_lokalu_do_wynajecia.Size = new System.Drawing.Size(208, 22);
            this.id_lokalu_do_wynajecia.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Identyfikator lokalu do wynajęcia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Data zamieszkania";
            // 
            // data_zamieszkania
            // 
            this.data_zamieszkania.Location = new System.Drawing.Point(15, 316);
            this.data_zamieszkania.Name = "data_zamieszkania";
            this.data_zamieszkania.Size = new System.Drawing.Size(306, 22);
            this.data_zamieszkania.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Data końca umowy";
            // 
            // data_konca_umowy
            // 
            this.data_konca_umowy.Location = new System.Drawing.Point(15, 376);
            this.data_konca_umowy.Name = "data_konca_umowy";
            this.data_konca_umowy.Size = new System.Drawing.Size(306, 22);
            this.data_konca_umowy.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 414);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Data końca zamieszkania";
            // 
            // data_konca_zamieszkania
            // 
            this.data_konca_zamieszkania.Location = new System.Drawing.Point(15, 434);
            this.data_konca_zamieszkania.Name = "data_konca_zamieszkania";
            this.data_konca_zamieszkania.Size = new System.Drawing.Size(306, 22);
            this.data_konca_zamieszkania.TabIndex = 26;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idwynajmuDataGridViewTextBoxColumn,
            this.idnajemcaDataGridViewTextBoxColumn,
            this.imięDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.peselDataGridViewTextBoxColumn,
            this.nrdokumentuDataGridViewTextBoxColumn,
            this.typdokumentuDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.najemcaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(697, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(515, 137);
            this.dataGridView2.TabIndex = 27;
            // 
            // idwynajmuDataGridViewTextBoxColumn
            // 
            this.idwynajmuDataGridViewTextBoxColumn.DataPropertyName = "id_wynajmu";
            this.idwynajmuDataGridViewTextBoxColumn.HeaderText = "id_wynajmu";
            this.idwynajmuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idwynajmuDataGridViewTextBoxColumn.Name = "idwynajmuDataGridViewTextBoxColumn";
            this.idwynajmuDataGridViewTextBoxColumn.ReadOnly = true;
            this.idwynajmuDataGridViewTextBoxColumn.Width = 125;
            // 
            // idnajemcaDataGridViewTextBoxColumn
            // 
            this.idnajemcaDataGridViewTextBoxColumn.DataPropertyName = "id_najemca";
            this.idnajemcaDataGridViewTextBoxColumn.HeaderText = "id_najemca";
            this.idnajemcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idnajemcaDataGridViewTextBoxColumn.Name = "idnajemcaDataGridViewTextBoxColumn";
            this.idnajemcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idnajemcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // imięDataGridViewTextBoxColumn
            // 
            this.imięDataGridViewTextBoxColumn.DataPropertyName = "imię";
            this.imięDataGridViewTextBoxColumn.HeaderText = "imię";
            this.imięDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imięDataGridViewTextBoxColumn.Name = "imięDataGridViewTextBoxColumn";
            this.imięDataGridViewTextBoxColumn.ReadOnly = true;
            this.imięDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwiskoDataGridViewTextBoxColumn.Width = 125;
            // 
            // peselDataGridViewTextBoxColumn
            // 
            this.peselDataGridViewTextBoxColumn.DataPropertyName = "pesel";
            this.peselDataGridViewTextBoxColumn.HeaderText = "pesel";
            this.peselDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peselDataGridViewTextBoxColumn.Name = "peselDataGridViewTextBoxColumn";
            this.peselDataGridViewTextBoxColumn.ReadOnly = true;
            this.peselDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrdokumentuDataGridViewTextBoxColumn
            // 
            this.nrdokumentuDataGridViewTextBoxColumn.DataPropertyName = "nr_dokumentu";
            this.nrdokumentuDataGridViewTextBoxColumn.HeaderText = "nr_dokumentu";
            this.nrdokumentuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrdokumentuDataGridViewTextBoxColumn.Name = "nrdokumentuDataGridViewTextBoxColumn";
            this.nrdokumentuDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrdokumentuDataGridViewTextBoxColumn.Width = 125;
            // 
            // typdokumentuDataGridViewTextBoxColumn
            // 
            this.typdokumentuDataGridViewTextBoxColumn.DataPropertyName = "typ_dokumentu";
            this.typdokumentuDataGridViewTextBoxColumn.HeaderText = "typ_dokumentu";
            this.typdokumentuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typdokumentuDataGridViewTextBoxColumn.Name = "typdokumentuDataGridViewTextBoxColumn";
            this.typdokumentuDataGridViewTextBoxColumn.ReadOnly = true;
            this.typdokumentuDataGridViewTextBoxColumn.Width = 125;
            // 
            // najemcaBindingSource
            // 
            this.najemcaBindingSource.DataMember = "najemca";
            this.najemcaBindingSource.DataSource = this.administracjaBudynkamiDataSet;
            // 
            // najemcaTableAdapter
            // 
            this.najemcaTableAdapter.ClearBeforeFill = true;
            // 
            // potwierdz_lokal
            // 
            this.potwierdz_lokal.Location = new System.Drawing.Point(246, 26);
            this.potwierdz_lokal.Name = "potwierdz_lokal";
            this.potwierdz_lokal.Size = new System.Drawing.Size(98, 23);
            this.potwierdz_lokal.TabIndex = 28;
            this.potwierdz_lokal.Text = "Potwierdź";
            this.potwierdz_lokal.UseVisualStyleBackColor = true;
            this.potwierdz_lokal.Click += new System.EventHandler(this.potwierdz_lokal_Click);
            // 
            // dodaj_najemce
            // 
            this.dodaj_najemce.Location = new System.Drawing.Point(473, 389);
            this.dodaj_najemce.Name = "dodaj_najemce";
            this.dodaj_najemce.Size = new System.Drawing.Size(141, 46);
            this.dodaj_najemce.TabIndex = 29;
            this.dodaj_najemce.Text = "Dodaj najemcę";
            this.dodaj_najemce.UseVisualStyleBackColor = true;
            this.dodaj_najemce.Click += new System.EventHandler(this.dodaj_najemce_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(694, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "Najemcy";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(694, 176);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Lokale";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 17);
            this.label16.TabIndex = 32;
            this.label16.Text = "Czynsz miesięczny";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // czynsz_msc
            // 
            this.czynsz_msc.Location = new System.Drawing.Point(15, 141);
            this.czynsz_msc.Name = "czynsz_msc";
            this.czynsz_msc.Size = new System.Drawing.Size(208, 22);
            this.czynsz_msc.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 233);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 17);
            this.label17.TabIndex = 34;
            this.label17.Text = "Termin płatności";
            // 
            // termin_platnosci
            // 
            this.termin_platnosci.Location = new System.Drawing.Point(15, 260);
            this.termin_platnosci.Name = "termin_platnosci";
            this.termin_platnosci.Size = new System.Drawing.Size(306, 22);
            this.termin_platnosci.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(694, 356);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 17);
            this.label18.TabIndex = 36;
            this.label18.Text = "Wynajem";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlokaluDataGridViewTextBoxColumn1,
            this.idwynajmuDataGridViewTextBoxColumn1,
            this.cenamiesiącDataGridViewTextBoxColumn,
            this.datazawarciaumowyDataGridViewTextBoxColumn,
            this.terminpłatnościDataGridViewTextBoxColumn,
            this.datazamieszkaniaDataGridViewTextBoxColumn,
            this.datakońcaumowyDataGridViewTextBoxColumn,
            this.datakońcazamieszkaniaDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.wynajemBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(697, 395);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(515, 157);
            this.dataGridView3.TabIndex = 37;
            // 
            // wynajemBindingSource
            // 
            this.wynajemBindingSource.DataMember = "wynajem";
            this.wynajemBindingSource.DataSource = this.administracjaBudynkamiDataSet;
            // 
            // wynajemTableAdapter
            // 
            this.wynajemTableAdapter.ClearBeforeFill = true;
            // 
            // idlokaluDataGridViewTextBoxColumn1
            // 
            this.idlokaluDataGridViewTextBoxColumn1.DataPropertyName = "id_lokalu";
            this.idlokaluDataGridViewTextBoxColumn1.HeaderText = "id_lokalu";
            this.idlokaluDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idlokaluDataGridViewTextBoxColumn1.Name = "idlokaluDataGridViewTextBoxColumn1";
            this.idlokaluDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idwynajmuDataGridViewTextBoxColumn1
            // 
            this.idwynajmuDataGridViewTextBoxColumn1.DataPropertyName = "id_wynajmu";
            this.idwynajmuDataGridViewTextBoxColumn1.HeaderText = "id_wynajmu";
            this.idwynajmuDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idwynajmuDataGridViewTextBoxColumn1.Name = "idwynajmuDataGridViewTextBoxColumn1";
            this.idwynajmuDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idwynajmuDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cenamiesiącDataGridViewTextBoxColumn
            // 
            this.cenamiesiącDataGridViewTextBoxColumn.DataPropertyName = "cena_miesiąc";
            this.cenamiesiącDataGridViewTextBoxColumn.HeaderText = "cena_miesiąc";
            this.cenamiesiącDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenamiesiącDataGridViewTextBoxColumn.Name = "cenamiesiącDataGridViewTextBoxColumn";
            this.cenamiesiącDataGridViewTextBoxColumn.Width = 125;
            // 
            // datazawarciaumowyDataGridViewTextBoxColumn
            // 
            this.datazawarciaumowyDataGridViewTextBoxColumn.DataPropertyName = "data_zawarcia_umowy";
            this.datazawarciaumowyDataGridViewTextBoxColumn.HeaderText = "data_zawarcia_umowy";
            this.datazawarciaumowyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datazawarciaumowyDataGridViewTextBoxColumn.Name = "datazawarciaumowyDataGridViewTextBoxColumn";
            this.datazawarciaumowyDataGridViewTextBoxColumn.Width = 125;
            // 
            // terminpłatnościDataGridViewTextBoxColumn
            // 
            this.terminpłatnościDataGridViewTextBoxColumn.DataPropertyName = "termin_płatności";
            this.terminpłatnościDataGridViewTextBoxColumn.HeaderText = "termin_płatności";
            this.terminpłatnościDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.terminpłatnościDataGridViewTextBoxColumn.Name = "terminpłatnościDataGridViewTextBoxColumn";
            this.terminpłatnościDataGridViewTextBoxColumn.Width = 125;
            // 
            // datazamieszkaniaDataGridViewTextBoxColumn
            // 
            this.datazamieszkaniaDataGridViewTextBoxColumn.DataPropertyName = "data_zamieszkania";
            this.datazamieszkaniaDataGridViewTextBoxColumn.HeaderText = "data_zamieszkania";
            this.datazamieszkaniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datazamieszkaniaDataGridViewTextBoxColumn.Name = "datazamieszkaniaDataGridViewTextBoxColumn";
            this.datazamieszkaniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datakońcaumowyDataGridViewTextBoxColumn
            // 
            this.datakońcaumowyDataGridViewTextBoxColumn.DataPropertyName = "data_końca_umowy";
            this.datakońcaumowyDataGridViewTextBoxColumn.HeaderText = "data_końca_umowy";
            this.datakońcaumowyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datakońcaumowyDataGridViewTextBoxColumn.Name = "datakońcaumowyDataGridViewTextBoxColumn";
            this.datakońcaumowyDataGridViewTextBoxColumn.Width = 125;
            // 
            // datakońcazamieszkaniaDataGridViewTextBoxColumn
            // 
            this.datakońcazamieszkaniaDataGridViewTextBoxColumn.DataPropertyName = "data_końca_zamieszkania";
            this.datakońcazamieszkaniaDataGridViewTextBoxColumn.HeaderText = "data_końca_zamieszkania";
            this.datakońcazamieszkaniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datakońcazamieszkaniaDataGridViewTextBoxColumn.Name = "datakońcazamieszkaniaDataGridViewTextBoxColumn";
            this.datakońcazamieszkaniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nowe_umowy_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 564);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.termin_platnosci);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.czynsz_msc);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dodaj_najemce);
            this.Controls.Add(this.potwierdz_lokal);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.data_konca_zamieszkania);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.data_konca_umowy);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.data_zamieszkania);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.id_lokalu_do_wynajecia);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cena_miesiac);
            this.Controls.Add(this.dodaj_wynajem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typ_dokumentu_najemca);
            this.Controls.Add(this.nr_dokumentu_najemca);
            this.Controls.Add(this.pesel_najemca);
            this.Controls.Add(this.nazwisko_najemca);
            this.Controls.Add(this.imie_najemca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_zawarcia_umowy);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "nowe_umowy_window";
            this.Text = "Umowy";
            this.Load += new System.EventHandler(this.nowe_umowy_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.najemcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynajemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker data_zawarcia_umowy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imie_najemca;
        private System.Windows.Forms.TextBox nazwisko_najemca;
        private System.Windows.Forms.TextBox pesel_najemca;
        private System.Windows.Forms.TextBox nr_dokumentu_najemca;
        private System.Windows.Forms.CheckedListBox typ_dokumentu_najemca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button dodaj_wynajem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cena_miesiac;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AdministracjaBudynkamiDataSet administracjaBudynkamiDataSet;
        private System.Windows.Forms.BindingSource lokalBindingSource;
        private AdministracjaBudynkamiDataSetTableAdapters.lokalTableAdapter lokalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbudynkuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlokaluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrlokaluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrpiętraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powierzchniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczbapokoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenazam2DataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox id_lokalu_do_wynajecia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker data_zamieszkania;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker data_konca_umowy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker data_konca_zamieszkania;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource najemcaBindingSource;
        private AdministracjaBudynkamiDataSetTableAdapters.najemcaTableAdapter najemcaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idwynajmuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnajemcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imięDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrdokumentuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typdokumentuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button potwierdz_lokal;
        private System.Windows.Forms.Button dodaj_najemce;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox czynsz_msc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker termin_platnosci;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource wynajemBindingSource;
        private AdministracjaBudynkamiDataSetTableAdapters.wynajemTableAdapter wynajemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlokaluDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idwynajmuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenamiesiącDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazawarciaumowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminpłatnościDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazamieszkaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datakońcaumowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datakońcazamieszkaniaDataGridViewTextBoxColumn;
    }
}