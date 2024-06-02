namespace BusZaPlus
{
    partial class BRISANJEfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BRISANJEfrm));
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblBrisanje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numLinija = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numLinija)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(194)))), ((int)(((byte)(173)))));
            this.btnObrisi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnObrisi.Location = new System.Drawing.Point(256, 135);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(115, 49);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "OBRIŠI";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lblBrisanje
            // 
            this.lblBrisanje.AutoSize = true;
            this.lblBrisanje.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBrisanje.Location = new System.Drawing.Point(12, 75);
            this.lblBrisanje.Name = "lblBrisanje";
            this.lblBrisanje.Size = new System.Drawing.Size(312, 28);
            this.lblBrisanje.TabIndex = 6;
            this.lblBrisanje.Text = "Unesite ID linije koju želite obrisati";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "BRISANJE VOZNE LINIJE";
            // 
            // numLinija
            // 
            this.numLinija.Location = new System.Drawing.Point(365, 80);
            this.numLinija.Name = "numLinija";
            this.numLinija.Size = new System.Drawing.Size(117, 26);
            this.numLinija.TabIndex = 8;
            // 
            // BRISANJEfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(614, 196);
            this.Controls.Add(this.numLinija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBrisanje);
            this.Controls.Add(this.btnObrisi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BRISANJEfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brisanje vozne linije";
            ((System.ComponentModel.ISupportInitialize)(this.numLinija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblBrisanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numLinija;
    }
}