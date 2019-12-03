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
            this.SuspendLayout();
            // 
            // zgloszenie
            // 
            this.zgloszenie.Location = new System.Drawing.Point(12, 64);
            this.zgloszenie.Name = "zgloszenie";
            this.zgloszenie.Size = new System.Drawing.Size(214, 22);
            this.zgloszenie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zgłoszenie usterki";
            // 
            // potw_zgloszenia
            // 
            this.potw_zgloszenia.Location = new System.Drawing.Point(104, 113);
            this.potw_zgloszenia.Name = "potw_zgloszenia";
            this.potw_zgloszenia.Size = new System.Drawing.Size(122, 33);
            this.potw_zgloszenia.TabIndex = 2;
            this.potw_zgloszenia.Text = "Dodaj";
            this.potw_zgloszenia.UseVisualStyleBackColor = true;
            // 
            // user_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.potw_zgloszenia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zgloszenie);
            this.Name = "user_window";
            this.Text = "user_window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zgloszenie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button potw_zgloszenia;
    }
}