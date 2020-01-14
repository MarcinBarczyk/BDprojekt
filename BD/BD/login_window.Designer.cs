namespace BD
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginButton = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_haslo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._userHelp = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this._userHelp.SetHelpString(this.LoginButton, "Formularz logowania do serwisu. Aby sie zalogowac nalezy podac login oraz haslo p" +
        "rzydzielone przez administratora budynku oraz nacisnac przycisk \"Zaloguj\".");
            this.LoginButton.Location = new System.Drawing.Point(159, 176);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginButton.Name = "LoginButton";
            this._userHelp.SetShowHelp(this.LoginButton, true);
            this.LoginButton.Size = new System.Drawing.Size(81, 37);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Zaloguj";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // textBox_login
            // 
            this._userHelp.SetHelpString(this.textBox_login, "Formularz logowania do serwisu. Aby sie zalogowac nalezy podac login oraz haslo p" +
        "rzydzielone przez administratora budynku oraz nacisnac przycisk \"Zaloguj\".");
            this.textBox_login.Location = new System.Drawing.Point(149, 97);
            this.textBox_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_login.Name = "textBox_login";
            this._userHelp.SetShowHelp(this.textBox_login, true);
            this.textBox_login.Size = new System.Drawing.Size(92, 20);
            this.textBox_login.TabIndex = 1;
            this.textBox_login.TextChanged += new System.EventHandler(this.textBox_login_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this._userHelp.SetHelpString(this.label1, "Formularz logowania do serwisu. Aby sie zalogowac nalezy podac login oraz haslo p" +
        "rzydzielone przez administratora budynku oraz nacisnac przycisk \"Zaloguj\".");
            this.label1.Location = new System.Drawing.Point(100, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this._userHelp.SetShowHelp(this.label1, true);
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this._userHelp.SetHelpString(this.label2, "Formularz logowania do serwisu. Aby sie zalogowac nalezy podac login oraz haslo p" +
        "rzydzielone przez administratora budynku oraz nacisnac przycisk \"Zaloguj\".");
            this.label2.Location = new System.Drawing.Point(98, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this._userHelp.SetShowHelp(this.label2, true);
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasło";
            // 
            // textBox_haslo
            // 
            this._userHelp.SetHelpString(this.textBox_haslo, "Formularz logowania do serwisu. Aby sie zalogowac nalezy podac login oraz haslo p" +
        "rzydzielone przez administratora budynku oraz nacisnac przycisk \"Zaloguj\".");
            this.textBox_haslo.Location = new System.Drawing.Point(149, 128);
            this.textBox_haslo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_haslo.Name = "textBox_haslo";
            this._userHelp.SetShowHelp(this.textBox_haslo, true);
            this.textBox_haslo.Size = new System.Drawing.Size(92, 20);
            this.textBox_haslo.TabIndex = 5;
            this.textBox_haslo.TextChanged += new System.EventHandler(this.textBox_haslo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._userHelp.SetHelpString(this.label3, "Formularz logowania do serwisu. Aby sie zalogowac nalezy podac login oraz haslo p" +
        "rzydzielone przez administratora budynku oraz nacisnac przycisk \"Zaloguj\".");
            this.label3.Location = new System.Drawing.Point(116, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this._userHelp.SetShowHelp(this.label3, true);
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Administracja budynków";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 246);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_haslo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.LoginButton);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Administracja";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_haslo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HelpProvider _userHelp;
    }
}

