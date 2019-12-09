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
            // nowy_uzytkownik_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 520);
            this.Controls.Add(this.add_user);
            this.Controls.Add(this.pass_add);
            this.Controls.Add(this.login_add);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.new_pass);
            this.Controls.Add(this.new_login);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "nowy_uzytkownik_window";
            this.Text = "add_user_window";
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
    }
}