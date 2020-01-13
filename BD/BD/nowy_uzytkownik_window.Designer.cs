namespace BD
{
    partial class nowy_uzytkownik_window
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
            this.użytkownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administracjaBudynkamiDataSet = new BD.AdministracjaBudynkamiDataSet();
            this.użytkownikTableAdapter = new BD.AdministracjaBudynkamiDataSetTableAdapters.użytkownikTableAdapter();
            this.najemcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.najemcaTableAdapter = new BD.AdministracjaBudynkamiDataSetTableAdapters.najemcaTableAdapter();
            this.id_użytkownika = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imię = new System.Windows.Forms.TextBox();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typy_uzytkownika = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_najemcy = new System.Windows.Forms.TextBox();
            this.add_user = new System.Windows.Forms.Button();
            this.pass_add = new System.Windows.Forms.Label();
            this.login_add = new System.Windows.Forms.Label();
            this.dane = new System.Windows.Forms.Label();
            this.hasło_text = new System.Windows.Forms.TextBox();
            this.login_text = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idużytkownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnajemcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typużytkownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imięDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.użytkownikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.użytkownikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.najemcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.użytkownikBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // użytkownikBindingSource
            // 
            this.użytkownikBindingSource.DataMember = "użytkownik";
            this.użytkownikBindingSource.DataSource = this.administracjaBudynkamiDataSet;
            // 
            // administracjaBudynkamiDataSet
            // 
            this.administracjaBudynkamiDataSet.DataSetName = "AdministracjaBudynkamiDataSet";
            this.administracjaBudynkamiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // użytkownikTableAdapter
            // 
            this.użytkownikTableAdapter.ClearBeforeFill = true;
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
            // id_użytkownika
            // 
            this.id_użytkownika.Location = new System.Drawing.Point(244, 155);
            this.id_użytkownika.Name = "id_użytkownika";
            this.id_użytkownika.Size = new System.Drawing.Size(163, 22);
            this.id_użytkownika.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Identyfikator użytkownika";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Użytkownicy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Imię";
            // 
            // imię
            // 
            this.imię.Location = new System.Drawing.Point(244, 288);
            this.imię.Name = "imię";
            this.imię.Size = new System.Drawing.Size(163, 22);
            this.imię.TabIndex = 32;
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(244, 315);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(163, 22);
            this.nazwisko.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(485, 288);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(468, 203);
            this.dataGridView1.TabIndex = 30;
            // 
            // typy_uzytkownika
            // 
            this.typy_uzytkownika.FormattingEnabled = true;
            this.typy_uzytkownika.Location = new System.Drawing.Point(244, 212);
            this.typy_uzytkownika.Margin = new System.Windows.Forms.Padding(4);
            this.typy_uzytkownika.Name = "typy_uzytkownika";
            this.typy_uzytkownika.Size = new System.Drawing.Size(163, 72);
            this.typy_uzytkownika.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Typ użytkownika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Identyfikator najemcy";
            // 
            // id_najemcy
            // 
            this.id_najemcy.Location = new System.Drawing.Point(244, 184);
            this.id_najemcy.Margin = new System.Windows.Forms.Padding(4);
            this.id_najemcy.Name = "id_najemcy";
            this.id_najemcy.Size = new System.Drawing.Size(163, 22);
            this.id_najemcy.TabIndex = 26;
            // 
            // add_user
            // 
            this.add_user.Location = new System.Drawing.Point(190, 422);
            this.add_user.Margin = new System.Windows.Forms.Padding(4);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(163, 46);
            this.add_user.TabIndex = 32;
            this.add_user.Text = "Dodaj";
            this.add_user.UseVisualStyleBackColor = true;
            this.add_user.Click += new System.EventHandler(this.add_user_Click);
            // 
            // pass_add
            // 
            this.pass_add.AutoSize = true;
            this.pass_add.Location = new System.Drawing.Point(48, 96);
            this.pass_add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pass_add.Name = "pass_add";
            this.pass_add.Size = new System.Drawing.Size(44, 17);
            this.pass_add.TabIndex = 24;
            this.pass_add.Text = "Hasło";
            // 
            // login_add
            // 
            this.login_add.AutoSize = true;
            this.login_add.Location = new System.Drawing.Point(48, 69);
            this.login_add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_add.Name = "login_add";
            this.login_add.Size = new System.Drawing.Size(180, 17);
            this.login_add.TabIndex = 23;
            this.login_add.Text = "Login (gen. automatycznie)";
            // 
            // dane
            // 
            this.dane.AutoSize = true;
            this.dane.Location = new System.Drawing.Point(187, 23);
            this.dane.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(109, 17);
            this.dane.TabIndex = 22;
            this.dane.Text = "Dane logowania";
            // 
            // hasło_text
            // 
            this.hasło_text.Location = new System.Drawing.Point(244, 96);
            this.hasło_text.Margin = new System.Windows.Forms.Padding(4);
            this.hasło_text.Name = "hasło_text";
            this.hasło_text.Size = new System.Drawing.Size(163, 22);
            this.hasło_text.TabIndex = 21;
            this.hasło_text.TextChanged += new System.EventHandler(this.hasło_text_TextChanged);
            // 
            // login_text
            // 
            this.login_text.Location = new System.Drawing.Point(244, 69);
            this.login_text.Margin = new System.Windows.Forms.Padding(4);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(163, 22);
            this.login_text.TabIndex = 20;
            this.login_text.TextChanged += new System.EventHandler(this.login_text_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idużytkownikaDataGridViewTextBoxColumn,
            this.idnajemcaDataGridViewTextBoxColumn,
            this.typużytkownikaDataGridViewTextBoxColumn,
            this.imięDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.użytkownikBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(485, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(468, 174);
            this.dataGridView2.TabIndex = 40;
            // 
            // idużytkownikaDataGridViewTextBoxColumn
            // 
            this.idużytkownikaDataGridViewTextBoxColumn.DataPropertyName = "id_użytkownika";
            this.idużytkownikaDataGridViewTextBoxColumn.HeaderText = "id_użytkownika";
            this.idużytkownikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idużytkownikaDataGridViewTextBoxColumn.Name = "idużytkownikaDataGridViewTextBoxColumn";
            this.idużytkownikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idużytkownikaDataGridViewTextBoxColumn.Width = 125;
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
            // typużytkownikaDataGridViewTextBoxColumn
            // 
            this.typużytkownikaDataGridViewTextBoxColumn.DataPropertyName = "typ_użytkownika";
            this.typużytkownikaDataGridViewTextBoxColumn.HeaderText = "typ_użytkownika";
            this.typużytkownikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typużytkownikaDataGridViewTextBoxColumn.Name = "typużytkownikaDataGridViewTextBoxColumn";
            this.typużytkownikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.typużytkownikaDataGridViewTextBoxColumn.Width = 125;
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
            // użytkownikBindingSource1
            // 
            this.użytkownikBindingSource1.DataMember = "użytkownik";
            this.użytkownikBindingSource1.DataSource = this.administracjaBudynkamiDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Istniejący uzytkownicy:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(241, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Min. 7 znaków";
            // 
            // nowy_uzytkownik_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 519);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.id_użytkownika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imię);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.typy_uzytkownika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_najemcy);
            this.Controls.Add(this.add_user);
            this.Controls.Add(this.pass_add);
            this.Controls.Add(this.login_add);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.hasło_text);
            this.Controls.Add(this.login_text);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "nowy_uzytkownik_window";
            this.Text = "add_user_window";
            this.Load += new System.EventHandler(this.nowy_uzytkownik_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.użytkownikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.najemcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.użytkownikBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AdministracjaBudynkamiDataSet administracjaBudynkamiDataSet;
        private System.Windows.Forms.BindingSource użytkownikBindingSource;
        private AdministracjaBudynkamiDataSetTableAdapters.użytkownikTableAdapter użytkownikTableAdapter;
        private System.Windows.Forms.BindingSource najemcaBindingSource;
        private AdministracjaBudynkamiDataSetTableAdapters.najemcaTableAdapter najemcaTableAdapter;
        private System.Windows.Forms.TextBox id_użytkownika;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imię;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckedListBox typy_uzytkownika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_najemcy;
        private System.Windows.Forms.Button add_user;
        private System.Windows.Forms.Label pass_add;
        private System.Windows.Forms.Label login_add;
        private System.Windows.Forms.Label dane;
        private System.Windows.Forms.TextBox hasło_text;
        private System.Windows.Forms.TextBox login_text;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idużytkownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnajemcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typużytkownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imięDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource użytkownikBindingSource1;
        private System.Windows.Forms.Label label8;
    }
}