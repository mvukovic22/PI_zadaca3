namespace BusZaPlus
{
    partial class UPDATEfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UPDATEfrm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.lblVozilo = new System.Windows.Forms.Label();
            this.lblOdrediste = new System.Windows.Forms.Label();
            this.lblPolazak = new System.Windows.Forms.Label();
            this.lblLinija = new System.Windows.Forms.Label();
            this.dateVrijeme = new System.Windows.Forms.DateTimePicker();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.numVozilo = new System.Windows.Forms.NumericUpDown();
            this.numLinija = new System.Windows.Forms.NumericUpDown();
            this.combDolazak = new System.Windows.Forms.ComboBox();
            this.combPolazak = new System.Windows.Forms.ComboBox();
            this.BtnSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numVozilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLinija)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "AŽURIRANJE VOZNE LINIJE";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblOpis.Location = new System.Drawing.Point(780, 168);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(50, 28);
            this.lblOpis.TabIndex = 18;
            this.lblOpis.Text = "Opis";
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblVrijeme.Location = new System.Drawing.Point(618, 168);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(142, 28);
            this.lblVrijeme.TabIndex = 17;
            this.lblVrijeme.Text = "Vrijeme polaska";
            // 
            // lblVozilo
            // 
            this.lblVozilo.AutoSize = true;
            this.lblVozilo.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblVozilo.Location = new System.Drawing.Point(478, 168);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(82, 28);
            this.lblVozilo.TabIndex = 16;
            this.lblVozilo.Text = "ID vozila";
            // 
            // lblOdrediste
            // 
            this.lblOdrediste.AutoSize = true;
            this.lblOdrediste.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblOdrediste.Location = new System.Drawing.Point(311, 168);
            this.lblOdrediste.Name = "lblOdrediste";
            this.lblOdrediste.Size = new System.Drawing.Size(155, 28);
            this.lblOdrediste.TabIndex = 15;
            this.lblOdrediste.Text = "Stanica odredišta";
            // 
            // lblPolazak
            // 
            this.lblPolazak.AutoSize = true;
            this.lblPolazak.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblPolazak.Location = new System.Drawing.Point(149, 168);
            this.lblPolazak.Name = "lblPolazak";
            this.lblPolazak.Size = new System.Drawing.Size(140, 28);
            this.lblPolazak.TabIndex = 14;
            this.lblPolazak.Text = "Stanica polaska";
            // 
            // lblLinija
            // 
            this.lblLinija.AutoSize = true;
            this.lblLinija.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblLinija.Location = new System.Drawing.Point(250, 97);
            this.lblLinija.Name = "lblLinija";
            this.lblLinija.Size = new System.Drawing.Size(304, 28);
            this.lblLinija.TabIndex = 13;
            this.lblLinija.Text = "Unesite ID linije koju želite izmijeniti";
            // 
            // dateVrijeme
            // 
            this.dateVrijeme.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.dateVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateVrijeme.Location = new System.Drawing.Point(623, 199);
            this.dateVrijeme.Name = "dateVrijeme";
            this.dateVrijeme.Size = new System.Drawing.Size(131, 29);
            this.dateVrijeme.TabIndex = 24;
            // 
            // txtOpis
            // 
            this.txtOpis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpis.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.txtOpis.Location = new System.Drawing.Point(785, 199);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(285, 29);
            this.txtOpis.TabIndex = 23;
            // 
            // numVozilo
            // 
            this.numVozilo.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.numVozilo.Location = new System.Drawing.Point(483, 199);
            this.numVozilo.Name = "numVozilo";
            this.numVozilo.Size = new System.Drawing.Size(117, 29);
            this.numVozilo.TabIndex = 22;
            // 
            // numLinija
            // 
            this.numLinija.Location = new System.Drawing.Point(581, 102);
            this.numLinija.Name = "numLinija";
            this.numLinija.Size = new System.Drawing.Size(117, 26);
            this.numLinija.TabIndex = 21;
            // 
            // combDolazak
            // 
            this.combDolazak.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.combDolazak.FormattingEnabled = true;
            this.combDolazak.Location = new System.Drawing.Point(316, 199);
            this.combDolazak.Name = "combDolazak";
            this.combDolazak.Size = new System.Drawing.Size(139, 29);
            this.combDolazak.TabIndex = 20;
            // 
            // combPolazak
            // 
            this.combPolazak.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.combPolazak.FormattingEnabled = true;
            this.combPolazak.Location = new System.Drawing.Point(154, 199);
            this.combPolazak.Name = "combPolazak";
            this.combPolazak.Size = new System.Drawing.Size(139, 29);
            this.combPolazak.TabIndex = 19;
            // 
            // BtnSpremi
            // 
            this.BtnSpremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(194)))), ((int)(((byte)(173)))));
            this.BtnSpremi.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.BtnSpremi.Location = new System.Drawing.Point(529, 253);
            this.BtnSpremi.Name = "BtnSpremi";
            this.BtnSpremi.Size = new System.Drawing.Size(121, 49);
            this.BtnSpremi.TabIndex = 25;
            this.BtnSpremi.Text = "SPREMI";
            this.BtnSpremi.UseVisualStyleBackColor = false;
            this.BtnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // UPDATEfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1180, 316);
            this.Controls.Add(this.BtnSpremi);
            this.Controls.Add(this.dateVrijeme);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.numVozilo);
            this.Controls.Add(this.numLinija);
            this.Controls.Add(this.combDolazak);
            this.Controls.Add(this.combPolazak);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblVrijeme);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.lblOdrediste);
            this.Controls.Add(this.lblPolazak);
            this.Controls.Add(this.lblLinija);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UPDATEfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ažuriranje vozne linije";
            this.Load += new System.EventHandler(this.UPDATEfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numVozilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLinija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblVrijeme;
        private System.Windows.Forms.Label lblVozilo;
        private System.Windows.Forms.Label lblOdrediste;
        private System.Windows.Forms.Label lblPolazak;
        private System.Windows.Forms.Label lblLinija;
        private System.Windows.Forms.DateTimePicker dateVrijeme;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.NumericUpDown numVozilo;
        private System.Windows.Forms.NumericUpDown numLinija;
        private System.Windows.Forms.ComboBox combDolazak;
        private System.Windows.Forms.ComboBox combPolazak;
        private System.Windows.Forms.Button BtnSpremi;
    }
}