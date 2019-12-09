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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.potwierdz_konserwacje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // do_konserwacji
            // 
            this.do_konserwacji.FormattingEnabled = true;
            this.do_konserwacji.Location = new System.Drawing.Point(12, 51);
            this.do_konserwacji.Name = "do_konserwacji";
            this.do_konserwacji.Size = new System.Drawing.Size(204, 55);
            this.do_konserwacji.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podlegają konserwacji";
            // 
            // dodaj_do_konserwacji
            // 
            this.dodaj_do_konserwacji.Location = new System.Drawing.Point(268, 51);
            this.dodaj_do_konserwacji.Name = "dodaj_do_konserwacji";
            this.dodaj_do_konserwacji.Size = new System.Drawing.Size(103, 55);
            this.dodaj_do_konserwacji.TabIndex = 2;
            this.dodaj_do_konserwacji.Text = "Dodaj";
            this.dodaj_do_konserwacji.UseVisualStyleBackColor = true;
            // 
            // w_konserwacji
            // 
            this.w_konserwacji.FormattingEnabled = true;
            this.w_konserwacji.Location = new System.Drawing.Point(12, 162);
            this.w_konserwacji.Name = "w_konserwacji";
            this.w_konserwacji.Size = new System.Drawing.Size(204, 55);
            this.w_konserwacji.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aktualnie w konserwacji";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 260);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data wykonania konserwacji";
            // 
            // potwierdz_konserwacje
            // 
            this.potwierdz_konserwacje.Location = new System.Drawing.Point(268, 162);
            this.potwierdz_konserwacje.Name = "potwierdz_konserwacje";
            this.potwierdz_konserwacje.Size = new System.Drawing.Size(103, 120);
            this.potwierdz_konserwacje.TabIndex = 7;
            this.potwierdz_konserwacje.Text = "Potwierdź wykonanie";
            this.potwierdz_konserwacje.UseVisualStyleBackColor = true;
            // 
            // konserwator_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.potwierdz_konserwacje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.w_konserwacji);
            this.Controls.Add(this.dodaj_do_konserwacji);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.do_konserwacji);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button potwierdz_konserwacje;
    }
}