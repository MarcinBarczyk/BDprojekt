namespace BD
{
    partial class nowe_lokale_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nowe_lokale_window));
            this.label1 = new System.Windows.Forms.Label();
            this.nr_lokalu = new System.Windows.Forms.TextBox();
            this.nr_pietra = new System.Windows.Forms.TextBox();
            this.powierzchnia = new System.Windows.Forms.TextBox();
            this.liczba_pokoi = new System.Windows.Forms.TextBox();
            this.cena_m2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dodaj_lokal = new System.Windows.Forms.Button();
            this.administracjaBudynkamiDataSet1 = new BD.AdministracjaBudynkamiDataSet();
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
            this._userHelp = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this._userHelp.SetHelpString(this.label1, resources.GetString("label1.HelpString"));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this._userHelp.SetShowHelp(this.label1, true);
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer lokalu";
            // 
            // nr_lokalu
            // 
            this._userHelp.SetHelpString(this.nr_lokalu, resources.GetString("nr_lokalu.HelpString"));
            this.nr_lokalu.Location = new System.Drawing.Point(16, 34);
            this.nr_lokalu.Margin = new System.Windows.Forms.Padding(2);
            this.nr_lokalu.Name = "nr_lokalu";
            this._userHelp.SetShowHelp(this.nr_lokalu, true);
            this.nr_lokalu.Size = new System.Drawing.Size(76, 20);
            this.nr_lokalu.TabIndex = 1;
            // 
            // nr_pietra
            // 
            this._userHelp.SetHelpString(this.nr_pietra, resources.GetString("nr_pietra.HelpString"));
            this.nr_pietra.Location = new System.Drawing.Point(16, 80);
            this.nr_pietra.Margin = new System.Windows.Forms.Padding(2);
            this.nr_pietra.Name = "nr_pietra";
            this._userHelp.SetShowHelp(this.nr_pietra, true);
            this.nr_pietra.Size = new System.Drawing.Size(76, 20);
            this.nr_pietra.TabIndex = 2;
            // 
            // powierzchnia
            // 
            this._userHelp.SetHelpString(this.powierzchnia, resources.GetString("powierzchnia.HelpString"));
            this.powierzchnia.Location = new System.Drawing.Point(16, 127);
            this.powierzchnia.Margin = new System.Windows.Forms.Padding(2);
            this.powierzchnia.Name = "powierzchnia";
            this._userHelp.SetShowHelp(this.powierzchnia, true);
            this.powierzchnia.Size = new System.Drawing.Size(76, 20);
            this.powierzchnia.TabIndex = 3;
            // 
            // liczba_pokoi
            // 
            this._userHelp.SetHelpString(this.liczba_pokoi, resources.GetString("liczba_pokoi.HelpString"));
            this.liczba_pokoi.Location = new System.Drawing.Point(16, 180);
            this.liczba_pokoi.Margin = new System.Windows.Forms.Padding(2);
            this.liczba_pokoi.Name = "liczba_pokoi";
            this._userHelp.SetShowHelp(this.liczba_pokoi, true);
            this.liczba_pokoi.Size = new System.Drawing.Size(76, 20);
            this.liczba_pokoi.TabIndex = 4;
            // 
            // cena_m2
            // 
            this._userHelp.SetHelpString(this.cena_m2, resources.GetString("cena_m2.HelpString"));
            this.cena_m2.Location = new System.Drawing.Point(16, 232);
            this.cena_m2.Margin = new System.Windows.Forms.Padding(2);
            this.cena_m2.Name = "cena_m2";
            this._userHelp.SetShowHelp(this.cena_m2, true);
            this.cena_m2.Size = new System.Drawing.Size(76, 20);
            this.cena_m2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this._userHelp.SetHelpString(this.label2, resources.GetString("label2.HelpString"));
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this._userHelp.SetShowHelp(this.label2, true);
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numer piętra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this._userHelp.SetHelpString(this.label3, resources.GetString("label3.HelpString"));
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this._userHelp.SetShowHelp(this.label3, true);
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Powierzchnia [m2]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this._userHelp.SetHelpString(this.label4, resources.GetString("label4.HelpString"));
            this.label4.Location = new System.Drawing.Point(15, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this._userHelp.SetShowHelp(this.label4, true);
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Liczba pokoi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this._userHelp.SetHelpString(this.label5, resources.GetString("label5.HelpString"));
            this.label5.Location = new System.Drawing.Point(14, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this._userHelp.SetShowHelp(this.label5, true);
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cena za m2 na miesiąc";
            // 
            // dodaj_lokal
            // 
            this._userHelp.SetHelpString(this.dodaj_lokal, resources.GetString("dodaj_lokal.HelpString"));
            this.dodaj_lokal.Location = new System.Drawing.Point(16, 323);
            this.dodaj_lokal.Margin = new System.Windows.Forms.Padding(2);
            this.dodaj_lokal.Name = "dodaj_lokal";
            this._userHelp.SetShowHelp(this.dodaj_lokal, true);
            this.dodaj_lokal.Size = new System.Drawing.Size(152, 33);
            this.dodaj_lokal.TabIndex = 12;
            this.dodaj_lokal.Text = "Dodaj";
            this.dodaj_lokal.UseVisualStyleBackColor = true;
            this.dodaj_lokal.Click += new System.EventHandler(this.dodaj_lokal_Click);
            // 
            // administracjaBudynkamiDataSet1
            // 
            this.administracjaBudynkamiDataSet1.DataSetName = "AdministracjaBudynkamiDataSet";
            this.administracjaBudynkamiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
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
            this._userHelp.SetHelpString(this.dataGridView1, "Lista przedstawiajaca lokale istniejace juz w bazie.");
            this.dataGridView1.Location = new System.Drawing.Point(138, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this._userHelp.SetShowHelp(this.dataGridView1, true);
            this.dataGridView1.Size = new System.Drawing.Size(288, 266);
            this.dataGridView1.TabIndex = 13;
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
            // nrlokaluDataGridViewTextBoxColumn
            // 
            this.nrlokaluDataGridViewTextBoxColumn.DataPropertyName = "nr_lokalu";
            this.nrlokaluDataGridViewTextBoxColumn.HeaderText = "nr_lokalu";
            this.nrlokaluDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrlokaluDataGridViewTextBoxColumn.Name = "nrlokaluDataGridViewTextBoxColumn";
            this.nrlokaluDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrpiętraDataGridViewTextBoxColumn
            // 
            this.nrpiętraDataGridViewTextBoxColumn.DataPropertyName = "nr_piętra";
            this.nrpiętraDataGridViewTextBoxColumn.HeaderText = "nr_piętra";
            this.nrpiętraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrpiętraDataGridViewTextBoxColumn.Name = "nrpiętraDataGridViewTextBoxColumn";
            this.nrpiętraDataGridViewTextBoxColumn.Width = 125;
            // 
            // powierzchniaDataGridViewTextBoxColumn
            // 
            this.powierzchniaDataGridViewTextBoxColumn.DataPropertyName = "powierzchnia";
            this.powierzchniaDataGridViewTextBoxColumn.HeaderText = "powierzchnia";
            this.powierzchniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.powierzchniaDataGridViewTextBoxColumn.Name = "powierzchniaDataGridViewTextBoxColumn";
            this.powierzchniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // liczbapokoiDataGridViewTextBoxColumn
            // 
            this.liczbapokoiDataGridViewTextBoxColumn.DataPropertyName = "liczba_pokoi";
            this.liczbapokoiDataGridViewTextBoxColumn.HeaderText = "liczba_pokoi";
            this.liczbapokoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.liczbapokoiDataGridViewTextBoxColumn.Name = "liczbapokoiDataGridViewTextBoxColumn";
            this.liczbapokoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // cenazam2DataGridViewTextBoxColumn
            // 
            this.cenazam2DataGridViewTextBoxColumn.DataPropertyName = "cena_za_m2";
            this.cenazam2DataGridViewTextBoxColumn.HeaderText = "cena_za_m2";
            this.cenazam2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenazam2DataGridViewTextBoxColumn.Name = "cenazam2DataGridViewTextBoxColumn";
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
            // nowe_lokale_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 376);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dodaj_lokal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cena_m2);
            this.Controls.Add(this.liczba_pokoi);
            this.Controls.Add(this.powierzchnia);
            this.Controls.Add(this.nr_pietra);
            this.Controls.Add(this.nr_lokalu);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nowe_lokale_window";
            this.Text = "Nowy lokal";
            this.Load += new System.EventHandler(this.nowe_lokale_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nr_lokalu;
        private System.Windows.Forms.TextBox nr_pietra;
        private System.Windows.Forms.TextBox powierzchnia;
        private System.Windows.Forms.TextBox liczba_pokoi;
        private System.Windows.Forms.TextBox cena_m2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button dodaj_lokal;
        private AdministracjaBudynkamiDataSet administracjaBudynkamiDataSet1;
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
        private System.Windows.Forms.HelpProvider _userHelp;
    }
}