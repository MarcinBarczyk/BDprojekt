namespace BD
{
    partial class konserwator_window
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
            this.do_konserwacji = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dodaj_do_konserwacji = new System.Windows.Forms.Button();
            this.w_konserwacji = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.data_wykonania = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.potwierdz_konserwacje = new System.Windows.Forms.Button();
            this.budynki = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // do_konserwacji
            // 
            this.do_konserwacji.FormattingEnabled = true;
            this.do_konserwacji.Location = new System.Drawing.Point(11, 141);
            this.do_konserwacji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.do_konserwacji.Name = "do_konserwacji";
            this.do_konserwacji.Size = new System.Drawing.Size(154, 34);
            this.do_konserwacji.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podlegają konserwacji";
            // 
            // dodaj_do_konserwacji
            // 
            this.dodaj_do_konserwacji.Location = new System.Drawing.Point(21, 208);
            this.dodaj_do_konserwacji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dodaj_do_konserwacji.Name = "dodaj_do_konserwacji";
            this.dodaj_do_konserwacji.Size = new System.Drawing.Size(113, 40);
            this.dodaj_do_konserwacji.TabIndex = 2;
            this.dodaj_do_konserwacji.Text = "Dodaj do realizacji";
            this.dodaj_do_konserwacji.UseVisualStyleBackColor = true;
            // 
            // w_konserwacji
            // 
            this.w_konserwacji.FormattingEnabled = true;
            this.w_konserwacji.Location = new System.Drawing.Point(315, 32);
            this.w_konserwacji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.w_konserwacji.Name = "w_konserwacji";
            this.w_konserwacji.Size = new System.Drawing.Size(154, 49);
            this.w_konserwacji.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aktualnie w konserwacji";
            // 
            // data_wykonania
            // 
            this.data_wykonania.Location = new System.Drawing.Point(315, 141);
            this.data_wykonania.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_wykonania.Name = "data_wykonania";
            this.data_wykonania.Size = new System.Drawing.Size(213, 20);
            this.data_wykonania.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data wykonania konserwacji";
            // 
            // potwierdz_konserwacje
            // 
            this.potwierdz_konserwacje.Location = new System.Drawing.Point(320, 208);
            this.potwierdz_konserwacje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.potwierdz_konserwacje.Name = "potwierdz_konserwacje";
            this.potwierdz_konserwacje.Size = new System.Drawing.Size(113, 40);
            this.potwierdz_konserwacje.TabIndex = 7;
            this.potwierdz_konserwacje.Text = "Potwierdź wykonanie";
            this.potwierdz_konserwacje.UseVisualStyleBackColor = true;
            // 
            // budynki
            // 
            this.budynki.FormattingEnabled = true;
            this.budynki.Location = new System.Drawing.Point(11, 32);
            this.budynki.Name = "budynki";
            this.budynki.Size = new System.Drawing.Size(154, 56);
            this.budynki.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wybierz budynek";
            // 
            // konserwator_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.budynki);
            this.Controls.Add(this.potwierdz_konserwacje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data_wykonania);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.w_konserwacji);
            this.Controls.Add(this.dodaj_do_konserwacji);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.do_konserwacji);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "konserwator_window";
            this.Text = "Konserwator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox do_konserwacji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodaj_do_konserwacji;
        private System.Windows.Forms.CheckedListBox w_konserwacji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker data_wykonania;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button potwierdz_konserwacje;
        private System.Windows.Forms.ListBox budynki;
        private System.Windows.Forms.Label label4;
    }
}