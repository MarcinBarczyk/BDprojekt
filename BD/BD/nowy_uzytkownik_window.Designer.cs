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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // new_login
            // 
            this.new_login.Location = new System.Drawing.Point(63, 44);
            this.new_login.Name = "new_login";
            this.new_login.Size = new System.Drawing.Size(123, 20);
            this.new_login.TabIndex = 0;
            this.new_login.TextChanged += new System.EventHandler(this.new_login_TextChanged);
            // 
            // new_pass
            // 
            this.new_pass.Location = new System.Drawing.Point(63, 85);
            this.new_pass.Name = "new_pass";
            this.new_pass.Size = new System.Drawing.Size(123, 20);
            this.new_pass.TabIndex = 1;
            this.new_pass.TextChanged += new System.EventHandler(this.new_pass_TextChanged);
            // 
            // dane
            // 
            this.dane.AutoSize = true;
            this.dane.Location = new System.Drawing.Point(84, 9);
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(84, 13);
            this.dane.TabIndex = 2;
            this.dane.Text = "Dane logowania";
            // 
            // login_add
            // 
            this.login_add.AutoSize = true;
            this.login_add.Location = new System.Drawing.Point(12, 47);
            this.login_add.Name = "login_add";
            this.login_add.Size = new System.Drawing.Size(33, 13);
            this.login_add.TabIndex = 3;
            this.login_add.Text = "Login";
            // 
            // pass_add
            // 
            this.pass_add.AutoSize = true;
            this.pass_add.Location = new System.Drawing.Point(12, 88);
            this.pass_add.Name = "pass_add";
            this.pass_add.Size = new System.Drawing.Size(36, 13);
            this.pass_add.TabIndex = 4;
            this.pass_add.Text = "Hasło";
            // 
            // add_user
            // 
            this.add_user.Location = new System.Drawing.Point(63, 355);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(105, 37);
            this.add_user.TabIndex = 5;
            this.add_user.Text = "Dodaj";
            this.add_user.UseVisualStyleBackColor = true;
            this.add_user.Click += new System.EventHandler(this.add_user_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Identyfikator najemcy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Typ użytkownika";
            // 
            // typy_uzytkownika
            // 
            this.typy_uzytkownika.FormattingEnabled = true;
            this.typy_uzytkownika.Location = new System.Drawing.Point(61, 212);
            this.typy_uzytkownika.Name = "typy_uzytkownika";
            this.typy_uzytkownika.Size = new System.Drawing.Size(125, 64);
            this.typy_uzytkownika.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(225, 162);
            this.dataGridView1.TabIndex = 10;
            // 
            // nowy_uzytkownik_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 422);
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
            this.Name = "nowy_uzytkownik_window";
            this.Text = "add_user_window";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}