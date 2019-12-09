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
            this.miejscowosc = new System.Windows.Forms.TextBox();
            this.ulica = new System.Windows.Forms.TextBox();
            this.liczba_pieter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nr_budynku = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // miejscowosc
            // 
            this.miejscowosc.Location = new System.Drawing.Point(12, 47);
            this.miejscowosc.Name = "miejscowosc";
            this.miejscowosc.Size = new System.Drawing.Size(196, 22);
            this.miejscowosc.TabIndex = 0;
            // 
            // ulica
            // 
            this.ulica.Location = new System.Drawing.Point(12, 120);
            this.ulica.Name = "ulica";
            this.ulica.Size = new System.Drawing.Size(196, 22);
            this.ulica.TabIndex = 1;
            // 
            // liczba_pieter
            // 
            this.liczba_pieter.Location = new System.Drawing.Point(12, 266);
            this.liczba_pieter.Name = "liczba_pieter";
            this.liczba_pieter.Size = new System.Drawing.Size(100, 22);
            this.liczba_pieter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Miejscowość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ulica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liczba pięter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numer budynku";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nr_budynku
            // 
            this.nr_budynku.Location = new System.Drawing.Point(12, 193);
            this.nr_budynku.Name = "nr_budynku";
            this.nr_budynku.Size = new System.Drawing.Size(196, 22);
            this.nr_budynku.TabIndex = 7;
            // 
            // budynki_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nr_budynku);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liczba_pieter);
            this.Controls.Add(this.ulica);
            this.Controls.Add(this.miejscowosc);
            this.Name = "budynki_window";
            this.Text = "Budynki";
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
    }
}