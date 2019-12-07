namespace BD
{
    partial class user_window
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
            this.zgloszenie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.potw_zgloszenia = new System.Windows.Forms.Button();
            this.remont = new System.Windows.Forms.RadioButton();
            this.usterka = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.potwierdzenie_platnosci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zgloszenie
            // 
            this.zgloszenie.Location = new System.Drawing.Point(9, 108);
            this.zgloszenie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zgloszenie.Name = "zgloszenie";
            this.zgloszenie.Size = new System.Drawing.Size(162, 20);
            this.zgloszenie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zgłoś:";
            // 
            // potw_zgloszenia
            // 
            this.potw_zgloszenia.Location = new System.Drawing.Point(79, 149);
            this.potw_zgloszenia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.potw_zgloszenia.Name = "potw_zgloszenia";
            this.potw_zgloszenia.Size = new System.Drawing.Size(92, 27);
            this.potw_zgloszenia.TabIndex = 2;
            this.potw_zgloszenia.Text = "Dodaj";
            this.potw_zgloszenia.UseVisualStyleBackColor = true;
            // 
            // remont
            // 
            this.remont.AutoSize = true;
            this.remont.Location = new System.Drawing.Point(12, 50);
            this.remont.Name = "remont";
            this.remont.Size = new System.Drawing.Size(57, 17);
            this.remont.TabIndex = 3;
            this.remont.TabStop = true;
            this.remont.Text = "remont";
            this.remont.UseVisualStyleBackColor = true;
            // 
            // usterka
            // 
            this.usterka.AutoSize = true;
            this.usterka.Location = new System.Drawing.Point(12, 73);
            this.usterka.Name = "usterka";
            this.usterka.Size = new System.Drawing.Size(60, 17);
            this.usterka.TabIndex = 4;
            this.usterka.TabStop = true;
            this.usterka.Text = "usterke";
            this.usterka.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Płatności";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(445, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 20);
            this.textBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(445, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kwota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data przelewu";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(445, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tytuł przelewu";
            // 
            // potwierdzenie_platnosci
            // 
            this.potwierdzenie_platnosci.Location = new System.Drawing.Point(445, 182);
            this.potwierdzenie_platnosci.Name = "potwierdzenie_platnosci";
            this.potwierdzenie_platnosci.Size = new System.Drawing.Size(102, 30);
            this.potwierdzenie_platnosci.TabIndex = 12;
            this.potwierdzenie_platnosci.Text = "Potwierdź";
            this.potwierdzenie_platnosci.UseVisualStyleBackColor = true;
            // 
            // user_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.potwierdzenie_platnosci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usterka);
            this.Controls.Add(this.remont);
            this.Controls.Add(this.potw_zgloszenia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zgloszenie);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "user_window";
            this.Text = "Użytkownik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zgloszenie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button potw_zgloszenia;
        private System.Windows.Forms.RadioButton remont;
        private System.Windows.Forms.RadioButton usterka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button potwierdzenie_platnosci;
    }
}