namespace BD
{
    partial class podwykonawca_window
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
            this.firma_nazwa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.data_zlecenia = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // firma_nazwa
            // 
            this.firma_nazwa.Location = new System.Drawing.Point(37, 55);
            this.firma_nazwa.Name = "firma_nazwa";
            this.firma_nazwa.Size = new System.Drawing.Size(130, 22);
            this.firma_nazwa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa firmy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data zlecenia";
            // 
            // data_zlecenia
            // 
            this.data_zlecenia.Location = new System.Drawing.Point(37, 136);
            this.data_zlecenia.Name = "data_zlecenia";
            this.data_zlecenia.Size = new System.Drawing.Size(264, 22);
            this.data_zlecenia.TabIndex = 3;
            // 
            // podwykonawca_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data_zlecenia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firma_nazwa);
            this.Name = "podwykonawca_window";
            this.Text = "Podwykonawca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firma_nazwa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker data_zlecenia;
    }
}