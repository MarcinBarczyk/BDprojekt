﻿namespace BD
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
            this.new_login = new System.Windows.Forms.TextBox();
            this.new_pass = new System.Windows.Forms.TextBox();
            this.dane = new System.Windows.Forms.Label();
            this.login_add = new System.Windows.Forms.Label();
            this.pass_add = new System.Windows.Forms.Label();
            this.add_user = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typy_uzytkownika = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.administracjaBudynkamiDataSet = new BD.AdministracjaBudynkamiDataSet();
            this.użytkownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.użytkownikTableAdapter = new BD.AdministracjaBudynkamiDataSetTableAdapters.użytkownikTableAdapter();
            this.idużytkownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnajemcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typużytkownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imięDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.użytkownikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // new_login
            // 
            this.new_login.Location = new System.Drawing.Point(84, 54);
            this.new_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new_login.Name = "new_login";
            this.new_login.Size = new System.Drawing.Size(163, 22);
            this.new_login.TabIndex = 0;
            this.new_login.TextChanged += new System.EventHandler(this.new_login_TextChanged);
            // 
            // new_pass
            // 
            this.new_pass.Location = new System.Drawing.Point(84, 105);
            this.new_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new_pass.Name = "new_pass";
            this.new_pass.Size = new System.Drawing.Size(163, 22);
            this.new_pass.TabIndex = 1;
            this.new_pass.TextChanged += new System.EventHandler(this.new_pass_TextChanged);
            // 
            // dane
            // 
            this.dane.AutoSize = true;
            this.dane.Location = new System.Drawing.Point(112, 11);
            this.dane.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(109, 17);
            this.dane.TabIndex = 2;
            this.dane.Text = "Dane logowania";
            // 
            // login_add
            // 
            this.login_add.AutoSize = true;
            this.login_add.Location = new System.Drawing.Point(16, 58);
            this.login_add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_add.Name = "login_add";
            this.login_add.Size = new System.Drawing.Size(43, 17);
            this.login_add.TabIndex = 3;
            this.login_add.Text = "Login";
            // 
            // pass_add
            // 
            this.pass_add.AutoSize = true;
            this.pass_add.Location = new System.Drawing.Point(16, 108);
            this.pass_add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pass_add.Name = "pass_add";
            this.pass_add.Size = new System.Drawing.Size(44, 17);
            this.pass_add.TabIndex = 4;
            this.pass_add.Text = "Hasło";
            // 
            // add_user
            // 
            this.add_user.Location = new System.Drawing.Point(84, 437);
            this.add_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(140, 46);
            this.add_user.TabIndex = 5;
            this.add_user.Text = "Dodaj";
            this.add_user.UseVisualStyleBackColor = true;
            this.add_user.Click += new System.EventHandler(this.add_user_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 197);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Identyfikator najemcy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Typ użytkownika";
            // 
            // typy_uzytkownika
            // 
            this.typy_uzytkownika.FormattingEnabled = true;
            this.typy_uzytkownika.Location = new System.Drawing.Point(81, 261);
            this.typy_uzytkownika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typy_uzytkownika.Name = "typy_uzytkownika";
            this.typy_uzytkownika.Size = new System.Drawing.Size(165, 72);
            this.typy_uzytkownika.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idużytkownikaDataGridViewTextBoxColumn,
            this.idnajemcaDataGridViewTextBoxColumn,
            this.typużytkownikaDataGridViewTextBoxColumn,
            this.imięDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.użytkownikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(329, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(425, 184);
            this.dataGridView1.TabIndex = 10;
            // 
            // administracjaBudynkamiDataSet
            // 
            this.administracjaBudynkamiDataSet.DataSetName = "AdministracjaBudynkamiDataSet";
            this.administracjaBudynkamiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // użytkownikBindingSource
            // 
            this.użytkownikBindingSource.DataMember = "użytkownik";
            this.użytkownikBindingSource.DataSource = this.administracjaBudynkamiDataSet;
            // 
            // użytkownikTableAdapter
            // 
            this.użytkownikTableAdapter.ClearBeforeFill = true;
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
            this.idnajemcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // typużytkownikaDataGridViewTextBoxColumn
            // 
            this.typużytkownikaDataGridViewTextBoxColumn.DataPropertyName = "typ_użytkownika";
            this.typużytkownikaDataGridViewTextBoxColumn.HeaderText = "typ_użytkownika";
            this.typużytkownikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typużytkownikaDataGridViewTextBoxColumn.Name = "typużytkownikaDataGridViewTextBoxColumn";
            this.typużytkownikaDataGridViewTextBoxColumn.Width = 125;
            // 
            // imięDataGridViewTextBoxColumn
            // 
            this.imięDataGridViewTextBoxColumn.DataPropertyName = "imię";
            this.imięDataGridViewTextBoxColumn.HeaderText = "imię";
            this.imięDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imięDataGridViewTextBoxColumn.Name = "imięDataGridViewTextBoxColumn";
            this.imięDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nowy_uzytkownik_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 519);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.typy_uzytkownika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.add_user);
            this.Controls.Add(this.pass_add);
            this.Controls.Add(this.login_add);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.new_pass);
            this.Controls.Add(this.new_login);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "nowy_uzytkownik_window";
            this.Text = "add_user_window";
            this.Load += new System.EventHandler(this.nowy_uzytkownik_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracjaBudynkamiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.użytkownikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox new_login;
        private System.Windows.Forms.TextBox new_pass;
        private System.Windows.Forms.Label dane;
        private System.Windows.Forms.Label login_add;
        private System.Windows.Forms.Label pass_add;
        private System.Windows.Forms.Button add_user;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox typy_uzytkownika;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AdministracjaBudynkamiDataSet administracjaBudynkamiDataSet;
        private System.Windows.Forms.BindingSource użytkownikBindingSource;
        private AdministracjaBudynkamiDataSetTableAdapters.użytkownikTableAdapter użytkownikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idużytkownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnajemcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typużytkownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imięDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
    }
}