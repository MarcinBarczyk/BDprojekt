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
            this.realizowane_remonty = new System.Windows.Forms.CheckedListBox();
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
            this.zgłoszenieTableAdapter = new BD.AdministracjaBudynkamiDataSetTableAdapters.zgłoszenieTableAdapter();
            this.administracjaBudynkamiDataSet1 = new BD.AdministracjaBudynkamiDataSet1();
            this.budynekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budynekTableAdapter = new BD.AdministracjaBudynkamiDataSet1TableAdapters.budynekTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.remonty_dla_admina.Location = new System.Drawing.Point(12, 286);
            this.remonty_dla_admina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remonty_dla_admina.Name = "remonty_dla_admina";
            this.remonty_dla_admina.Size = new System.Drawing.Size(253, 55);
            this.remonty_dla_admina.TabIndex = 4;
            this.remonty_dla_admina.SelectedIndexChanged += new System.EventHandler(this.W_realizacji_SelectedIndexChanged);
            // 
            // Data_poczatkowa
            // 
            this.Data_poczatkowa.Location = new System.Drawing.Point(697, 378);
            this.Data_poczatkowa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Data_poczatkowa.Name = "Data_poczatkowa";
            this.Data_poczatkowa.Size = new System.Drawing.Size(309, 22);
            this.Data_poczatkowa.TabIndex = 6;
            // 
            // Data_koncowa
            // 
            this.Data_koncowa.Location = new System.Drawing.Point(697, 453);
            this.Data_koncowa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Data_koncowa.Name = "Data_koncowa";
            this.Data_koncowa.Size = new System.Drawing.Size(309, 22);
            this.Data_koncowa.TabIndex = 7;
            // 
            // Data_p
            // 
            this.Data_p.AutoSize = true;
            this.Data_p.Location = new System.Drawing.Point(697, 358);
            this.Data_p.Name = "Data_p";
            this.Data_p.Size = new System.Drawing.Size(206, 17);
            this.Data_p.TabIndex = 8;
            this.Data_p.Text = "Wybierz datę początku zakresu";
            // 
            // Data_k
            // 
            this.Data_k.AutoSize = true;
            this.Data_k.Location = new System.Drawing.Point(695, 432);
            this.Data_k.Name = "Data_k";
            this.Data_k.Size = new System.Drawing.Size(187, 17);
            this.Data_k.TabIndex = 9;
            this.Data_k.Text = "Wybierz datę końca zakresu";
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(697, 501);
            this.Data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(91, 34);
            this.Data.TabIndex = 10;
            this.Data.Text = "Potwierdź";
            this.Data.UseVisualStyleBackColor = true;
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // do_realizacji
            // 
            this.do_realizacji.Location = new System.Drawing.Point(296, 286);
            this.do_realizacji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.do_realizacji.Name = "do_realizacji";
            this.do_realizacji.Size = new System.Drawing.Size(115, 60);
            this.do_realizacji.TabIndex = 11;
            this.do_realizacji.Text = "Dodaj do realizacji";
            this.do_realizacji.UseVisualStyleBackColor = true;
            this.do_realizacji.Click += new System.EventHandler(this.Zgloszenia_Click);
            // 
            // dodawanie
            // 
            this.dodawanie.Location = new System.Drawing.Point(752, 127);
            this.dodawanie.Margin = new System.Windows.Forms.Padding(4);
            this.dodawanie.Name = "dodawanie";
            this.dodawanie.Size = new System.Drawing.Size(184, 57);
            this.dodawanie.TabIndex = 14;
            this.dodawanie.Text = "Dodaj";
            this.dodawanie.UseVisualStyleBackColor = true;
            this.dodawanie.Click += new System.EventHandler(this.dodawanie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Wszystkie zgłoszenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Zgłoszone remonty";
            // 
            // realizowane_remonty
            // 
            this.realizowane_remonty.FormattingEnabled = true;
            this.realizowane_remonty.Location = new System.Drawing.Point(12, 401);
            this.realizowane_remonty.Margin = new System.Windows.Forms.Padding(4);
            this.realizowane_remonty.Name = "realizowane_remonty";
            this.realizowane_remonty.Size = new System.Drawing.Size(253, 55);
            this.realizowane_remonty.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 378);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Remonty w trakcie realizacji";
            // 
            // potwierdzenie_realizacji
            // 
            this.potwierdzenie_realizacji.Location = new System.Drawing.Point(296, 401);
            this.potwierdzenie_realizacji.Margin = new System.Windows.Forms.Padding(4);
            this.potwierdzenie_realizacji.Name = "potwierdzenie_realizacji";
            this.potwierdzenie_realizacji.Size = new System.Drawing.Size(115, 60);
            this.potwierdzenie_realizacji.TabIndex = 21;
            this.potwierdzenie_realizacji.Text = "Potwierdź zrealizowanie";
            this.potwierdzenie_realizacji.UseVisualStyleBackColor = true;
            this.potwierdzenie_realizacji.Click += new System.EventHandler(this.potwierdzenie_realizacji_Click);
            // 
            // dodawanie_uzytkownika
            // 
            this.dodawanie_uzytkownika.AutoSize = true;
            this.dodawanie_uzytkownika.Location = new System.Drawing.Point(752, 15);
            this.dodawanie_uzytkownika.Margin = new System.Windows.Forms.Padding(4);
            this.dodawanie_uzytkownika.Name = "dodawanie_uzytkownika";
            this.dodawanie_uzytkownika.Size = new System.Drawing.Size(146, 21);
            this.dodawanie_uzytkownika.TabIndex = 22;
            this.dodawanie_uzytkownika.TabStop = true;
            this.dodawanie_uzytkownika.Text = "Dodaj użytkownika";
            this.dodawanie_uzytkownika.UseVisualStyleBackColor = true;
            this.dodawanie_uzytkownika.CheckedChanged += new System.EventHandler(this.dodawanie_uzytkownika_CheckedChanged);
            // 
            // dodawanie_budynku
            // 
            this.dodawanie_budynku.AutoSize = true;
            this.dodawanie_budynku.Location = new System.Drawing.Point(752, 71);
            this.dodawanie_budynku.Margin = new System.Windows.Forms.Padding(4);
            this.dodawanie_budynku.Name = "dodawanie_budynku";
            this.dodawanie_budynku.Size = new System.Drawing.Size(124, 21);
            this.dodawanie_budynku.TabIndex = 23;
            this.dodawanie_budynku.TabStop = true;
            this.dodawanie_budynku.Text = "Dodaj budynek";
            this.dodawanie_budynku.UseVisualStyleBackColor = true;
            // 
            // dodawanie_umowy
            // 
            this.dodawanie_umowy.AutoSize = true;
            this.dodawanie_umowy.Location = new System.Drawing.Point(752, 43);
            this.dodawanie_umowy.Margin = new System.Windows.Forms.Padding(4);
            this.dodawanie_umowy.Name = "dodawanie_umowy";
            this.dodawanie_umowy.Size = new System.Drawing.Size(114, 21);
            this.dodawanie_umowy.TabIndex = 24;
            this.dodawanie_umowy.TabStop = true;
            this.dodawanie_umowy.Text = "Dodaj umowę";
            this.dodawanie_umowy.UseVisualStyleBackColor = true;
            this.dodawanie_umowy.CheckedChanged += new System.EventHandler(this.dodawanie_umowy_CheckedChanged);
            // 
            // dodawanie_lokali
            // 
            this.dodawanie_lokali.AutoSize = true;
            this.dodawanie_lokali.Location = new System.Drawing.Point(752, 100);
            this.dodawanie_lokali.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodawanie_lokali.Name = "dodawanie_lokali";
            this.dodawanie_lokali.Size = new System.Drawing.Size(99, 21);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(399, 140);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(11, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 52);
            this.listBox1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 25);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // administracjaBudynkamiDataSet2
            // 
            this.administracjaBudynkamiDataSet2.DataSetName = "AdministracjaBudynkamiDataSet";
            this.administracjaBudynkamiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admin_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 549);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dodawanie_lokali);
            this.Controls.Add(this.dodawanie_umowy);
            this.Controls.Add(this.dodawanie_budynku);
            this.Controls.Add(this.dodawanie_uzytkownika);
            this.Controls.Add(this.potwierdzenie_realizacji);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.realizowane_remonty);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.CheckedListBox realizowane_remonty;
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
        private AdministracjaBudynkamiDataSet1 administracjaBudynkamiDataSet1;
        private System.Windows.Forms.BindingSource budynekBindingSource;
        private AdministracjaBudynkamiDataSet1TableAdapters.budynekTableAdapter budynekTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private AdministracjaBudynkamiDataSet administracjaBudynkamiDataSet2;
    }
}