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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nowe_budynki_window));
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbudynkuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrbudynkuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczbapięterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budynekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administracjaBudynkamiDataSet = new BD.AdministracjaBudynkamiDataSet();
            this.budynekTableAdapter = new BD.AdministracjaBudynkamiDataSetTableAdapters.budynekTableAdapter();
            this._userHelp = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budynekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // miejscowosc
            // 
            this._userHelp.SetHelpString(this.miejscowosc, resources.GetString("miejscowosc.HelpString"));
            this.miejscowosc.Location = new System.Drawing.Point(461, 94);
            this.miejscowosc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.miejscowosc.Name = "miejscowosc";
            this._userHelp.SetShowHelp(this.miejscowosc, true);
            this.miejscowosc.Size = new System.Drawing.Size(148, 20);
            this.miejscowosc.TabIndex = 0;
            // 
            // ulica
            // 
            this._userHelp.SetHelpString(this.ulica, resources.GetString("ulica.HelpString"));
            this.ulica.Location = new System.Drawing.Point(462, 141);
            this.ulica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ulica.Name = "ulica";
            this._userHelp.SetShowHelp(this.ulica, true);
            this.ulica.Size = new System.Drawing.Size(148, 20);
            this.ulica.TabIndex = 1;
            // 
            // liczba_pieter
            // 
            this._userHelp.SetHelpString(this.liczba_pieter, resources.GetString("liczba_pieter.HelpString"));
            this.liczba_pieter.Location = new System.Drawing.Point(461, 244);
            this.liczba_pieter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.liczba_pieter.Name = "liczba_pieter";
            this._userHelp.SetShowHelp(this.liczba_pieter, true);
            this.liczba_pieter.Size = new System.Drawing.Size(76, 20);
            this.liczba_pieter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this._userHelp.SetHelpString(this.label1, resources.GetString("label1.HelpString"));
            this.label1.Location = new System.Drawing.Point(459, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this._userHelp.SetShowHelp(this.label1, true);
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Miejscowość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this._userHelp.SetHelpString(this.label2, resources.GetString("label2.HelpString"));
            this.label2.Location = new System.Drawing.Point(459, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this._userHelp.SetShowHelp(this.label2, true);
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ulica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this._userHelp.SetHelpString(this.label3, resources.GetString("label3.HelpString"));
            this.label3.Location = new System.Drawing.Point(459, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this._userHelp.SetShowHelp(this.label3, true);
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liczba pięter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this._userHelp.SetHelpString(this.label4, resources.GetString("label4.HelpString"));
            this.label4.Location = new System.Drawing.Point(459, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this._userHelp.SetShowHelp(this.label4, true);
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numer budynku";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nr_budynku
            // 
            this._userHelp.SetHelpString(this.nr_budynku, resources.GetString("nr_budynku.HelpString"));
            this.nr_budynku.Location = new System.Drawing.Point(461, 189);
            this.nr_budynku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nr_budynku.Name = "nr_budynku";
            this._userHelp.SetShowHelp(this.nr_budynku, true);
            this.nr_budynku.Size = new System.Drawing.Size(148, 20);
            this.nr_budynku.TabIndex = 7;
            // 
            // nazwa
            // 
            this._userHelp.SetHelpString(this.nazwa, resources.GetString("nazwa.HelpString"));
            this.nazwa.Location = new System.Drawing.Point(461, 39);
            this.nazwa.Name = "nazwa";
            this._userHelp.SetShowHelp(this.nazwa, true);
            this.nazwa.Size = new System.Drawing.Size(149, 20);
            this.nazwa.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this._userHelp.SetHelpString(this.label5, resources.GetString("label5.HelpString"));
            this.label5.Location = new System.Drawing.Point(459, 22);
            this.label5.Name = "label5";
            this._userHelp.SetShowHelp(this.label5, true);
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Identyfikator budynku";
            // 
            // dodaj_budynek
            // 
            this._userHelp.SetHelpString(this.dodaj_budynek, resources.GetString("dodaj_budynek.HelpString"));
            this.dodaj_budynek.Location = new System.Drawing.Point(463, 296);
            this.dodaj_budynek.Name = "dodaj_budynek";
            this._userHelp.SetShowHelp(this.dodaj_budynek, true);
            this.dodaj_budynek.Size = new System.Drawing.Size(147, 30);
            this.dodaj_budynek.TabIndex = 10;
            this.dodaj_budynek.Text = "Dodaj";
            this.dodaj_budynek.UseVisualStyleBackColor = true;
            this.dodaj_budynek.Click += new System.EventHandler(this.dodaj_budynek_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbudynkuDataGridViewTextBoxColumn,
            this.miejscowośćDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.nrbudynkuDataGridViewTextBoxColumn,
            this.liczbapięterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.budynekBindingSource;
            this._userHelp.SetHelpString(this.dataGridView1, "Lista przedstawiajaca budynki istniejace juz w bazie.");
            this.dataGridView1.Location = new System.Drawing.Point(9, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this._userHelp.SetShowHelp(this.dataGridView1, true);
            this.dataGridView1.Size = new System.Drawing.Size(408, 304);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // miejscowośćDataGridViewTextBoxColumn
            // 
            this.miejscowośćDataGridViewTextBoxColumn.DataPropertyName = "miejscowość";
            this.miejscowośćDataGridViewTextBoxColumn.HeaderText = "miejscowość";
            this.miejscowośćDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.miejscowośćDataGridViewTextBoxColumn.Name = "miejscowośćDataGridViewTextBoxColumn";
            this.miejscowośćDataGridViewTextBoxColumn.ReadOnly = true;
            this.miejscowośćDataGridViewTextBoxColumn.Width = 125;
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "ulica";
            this.ulicaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            this.ulicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ulicaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrbudynkuDataGridViewTextBoxColumn
            // 
            this.nrbudynkuDataGridViewTextBoxColumn.DataPropertyName = "nr_budynku";
            this.nrbudynkuDataGridViewTextBoxColumn.HeaderText = "nr_budynku";
            this.nrbudynkuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrbudynkuDataGridViewTextBoxColumn.Name = "nrbudynkuDataGridViewTextBoxColumn";
            this.nrbudynkuDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrbudynkuDataGridViewTextBoxColumn.Width = 125;
            // 
            // liczbapięterDataGridViewTextBoxColumn
            // 
            this.liczbapięterDataGridViewTextBoxColumn.DataPropertyName = "liczba_pięter";
            this.liczbapięterDataGridViewTextBoxColumn.HeaderText = "liczba_pięter";
            this.liczbapięterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.liczbapięterDataGridViewTextBoxColumn.Name = "liczbapięterDataGridViewTextBoxColumn";
            this.liczbapięterDataGridViewTextBoxColumn.ReadOnly = true;
            this.liczbapięterDataGridViewTextBoxColumn.Width = 125;
            // 
            // budynekBindingSource
            // 
            this.budynekBindingSource.DataMember = "budynek";
            this.budynekBindingSource.DataSource = this.administracjaBudynkamiDataSet;
            // 
            // administracjaBudynkamiDataSet
            // 
            this.administracjaBudynkamiDataSet.DataSetName = "AdministracjaBudynkamiDataSet";
            this.administracjaBudynkamiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budynekTableAdapter
            // 
            this.budynekTableAdapter.ClearBeforeFill = true;
            // 
            // nowe_budynki_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 366);
            this.Controls.Add(this.dataGridView1);
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
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nowe_budynki_window";
            this.Text = "Budynki";
            this.Load += new System.EventHandler(this.nowe_budynki_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budynekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private AdministracjaBudynkamiDataSet administracjaBudynkamiDataSet;
        private System.Windows.Forms.BindingSource budynekBindingSource;
        private AdministracjaBudynkamiDataSetTableAdapters.budynekTableAdapter budynekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbudynkuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejscowośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrbudynkuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczbapięterDataGridViewTextBoxColumn;
        private System.Windows.Forms.HelpProvider _userHelp;
    }
}