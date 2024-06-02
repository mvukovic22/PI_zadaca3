namespace BusZaPlus
{
    partial class UNOSfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UNOSfrm));
            this.combPolazak = new System.Windows.Forms.ComboBox();
            this.combDolazak = new System.Windows.Forms.ComboBox();
            this.numLinija = new System.Windows.Forms.NumericUpDown();
            this.numVozilo = new System.Windows.Forms.NumericUpDown();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.dateVrijeme = new System.Windows.Forms.DateTimePicker();
            this.lblUnos = new System.Windows.Forms.Label();
            this.lblLinija = new System.Windows.Forms.Label();
            this.lblPolazak = new System.Windows.Forms.Label();
            this.lblOdrediste = new System.Windows.Forms.Label();
            this.lblVozilo = new System.Windows.Forms.Label();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.BtnSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLinija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVozilo)).BeginInit();
            this.SuspendLayout();
            // 
            // combPolazak
            // 
            this.combPolazak.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.combPolazak.FormattingEnabled = true;
            this.combPolazak.Location = new System.Drawing.Point(199, 135);
            this.combPolazak.Name = "combPolazak";
            this.combPolazak.Size = new System.Drawing.Size(139, 29);
            this.combPolazak.TabIndex = 0;
            // 
            // combDolazak
            // 
            this.combDolazak.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.combDolazak.FormattingEnabled = true;
            this.combDolazak.Location = new System.Drawing.Point(361, 135);
            this.combDolazak.Name = "combDolazak";
            this.combDolazak.Size = new System.Drawing.Size(139, 29);
            this.combDolazak.TabIndex = 1;
            // 
            // numLinija
            // 
            this.numLinija.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.numLinija.Location = new System.Drawing.Point(61, 135);
            this.numLinija.Name = "numLinija";
            this.numLinija.Size = new System.Drawing.Size(117, 29);
            this.numLinija.TabIndex = 2;
            // 
            // numVozilo
            // 
            this.numVozilo.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.numVozilo.Location = new System.Drawing.Point(528, 135);
            this.numVozilo.Name = "numVozilo";
            this.numVozilo.Size = new System.Drawing.Size(117, 29);
            this.numVozilo.TabIndex = 3;
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.txtOpis.Location = new System.Drawing.Point(830, 135);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(285, 29);
            this.txtOpis.TabIndex = 4;
            // 
            // dateVrijeme
            // 
            this.dateVrijeme.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.dateVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateVrijeme.Location = new System.Drawing.Point(668, 135);
            this.dateVrijeme.Name = "dateVrijeme";
            this.dateVrijeme.Size = new System.Drawing.Size(131, 29);
            this.dateVrijeme.TabIndex = 5;
            // 
            // lblUnos
            // 
            this.lblUnos.AutoSize = true;
            this.lblUnos.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lblUnos.Location = new System.Drawing.Point(409, 9);
            this.lblUnos.Name = "lblUnos";
            this.lblUnos.Size = new System.Drawing.Size(390, 45);
            this.lblUnos.TabIndex = 6;
            this.lblUnos.Text = "UNOS NOVE VOZNE LINIJE";
            // 
            // lblLinija
            // 
            this.lblLinija.AutoSize = true;
            this.lblLinija.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblLinija.Location = new System.Drawing.Point(56, 104);
            this.lblLinija.Name = "lblLinija";
            this.lblLinija.Size = new System.Drawing.Size(72, 28);
            this.lblLinija.TabIndex = 7;
            this.lblLinija.Text = "ID linije";
            // 
            // lblPolazak
            // 
            this.lblPolazak.AutoSize = true;
            this.lblPolazak.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblPolazak.Location = new System.Drawing.Point(194, 104);
            this.lblPolazak.Name = "lblPolazak";
            this.lblPolazak.Size = new System.Drawing.Size(140, 28);
            this.lblPolazak.TabIndex = 8;
            this.lblPolazak.Text = "Stanica polaska";
            // 
            // lblOdrediste
            // 
            this.lblOdrediste.AutoSize = true;
            this.lblOdrediste.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblOdrediste.Location = new System.Drawing.Point(356, 104);
            this.lblOdrediste.Name = "lblOdrediste";
            this.lblOdrediste.Size = new System.Drawing.Size(155, 28);
            this.lblOdrediste.TabIndex = 9;
            this.lblOdrediste.Text = "Stanica odredišta";
            // 
            // lblVozilo
            // 
            this.lblVozilo.AutoSize = true;
            this.lblVozilo.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblVozilo.Location = new System.Drawing.Point(523, 104);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(82, 28);
            this.lblVozilo.TabIndex = 10;
            this.lblVozilo.Text = "ID vozila";
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblVrijeme.Location = new System.Drawing.Point(663, 104);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(142, 28);
            this.lblVrijeme.TabIndex = 11;
            this.lblVrijeme.Text = "Vrijeme polaska";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblOpis.Location = new System.Drawing.Point(825, 104);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(50, 28);
            this.lblOpis.TabIndex = 12;
            this.lblOpis.Text = "Opis";
            // 
            // BtnSpremi
            // 
            this.BtnSpremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(194)))), ((int)(((byte)(173)))));
            this.BtnSpremi.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.BtnSpremi.Location = new System.Drawing.Point(524, 212);
            this.BtnSpremi.Name = "BtnSpremi";
            this.BtnSpremi.Size = new System.Drawing.Size(121, 49);
            this.BtnSpremi.TabIndex = 13;
            this.BtnSpremi.Text = "SPREMI";
            this.BtnSpremi.UseVisualStyleBackColor = false;
            this.BtnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // UNOSfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1180, 273);
            this.Controls.Add(this.BtnSpremi);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblVrijeme);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.lblOdrediste);
            this.Controls.Add(this.lblPolazak);
            this.Controls.Add(this.lblLinija);
            this.Controls.Add(this.lblUnos);
            this.Controls.Add(this.dateVrijeme);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.numVozilo);
            this.Controls.Add(this.numLinija);
            this.Controls.Add(this.combDolazak);
            this.Controls.Add(this.combPolazak);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UNOSfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiranje nove vozne linije";
            this.Load += new System.EventHandler(this.UNOSfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLinija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVozilo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combPolazak;
        private System.Windows.Forms.ComboBox combDolazak;
        private System.Windows.Forms.NumericUpDown numLinija;
        private System.Windows.Forms.NumericUpDown numVozilo;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.DateTimePicker dateVrijeme;
        private System.Windows.Forms.Label lblUnos;
        private System.Windows.Forms.Label lblLinija;
        private System.Windows.Forms.Label lblPolazak;
        private System.Windows.Forms.Label lblOdrediste;
        private System.Windows.Forms.Label lblVozilo;
        private System.Windows.Forms.Label lblVrijeme;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Button BtnSpremi;
    }
}