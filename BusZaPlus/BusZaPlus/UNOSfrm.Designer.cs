﻿namespace BusZaPlus
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
            this.combPolazak = new System.Windows.Forms.ComboBox();
            this.combDolazak = new System.Windows.Forms.ComboBox();
            this.numLinija = new System.Windows.Forms.NumericUpDown();
            this.numVozilo = new System.Windows.Forms.NumericUpDown();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.dateVrijeme = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLinija = new System.Windows.Forms.Label();
            this.lblPolazak = new System.Windows.Forms.Label();
            this.lblOdrediste = new System.Windows.Forms.Label();
            this.lblVozilo = new System.Windows.Forms.Label();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLinija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVozilo)).BeginInit();
            this.SuspendLayout();
            // 
            // combPolazak
            // 
            this.combPolazak.FormattingEnabled = true;
            this.combPolazak.Location = new System.Drawing.Point(199, 135);
            this.combPolazak.Name = "combPolazak";
            this.combPolazak.Size = new System.Drawing.Size(139, 28);
            this.combPolazak.TabIndex = 0;
            this.combPolazak.SelectedIndexChanged += new System.EventHandler(this.combPolazak_SelectedIndexChanged);
            // 
            // combDolazak
            // 
            this.combDolazak.FormattingEnabled = true;
            this.combDolazak.Location = new System.Drawing.Point(361, 135);
            this.combDolazak.Name = "combDolazak";
            this.combDolazak.Size = new System.Drawing.Size(139, 28);
            this.combDolazak.TabIndex = 1;
            this.combDolazak.SelectedIndexChanged += new System.EventHandler(this.combDolazak_SelectedIndexChanged);
            // 
            // numLinija
            // 
            this.numLinija.Location = new System.Drawing.Point(61, 135);
            this.numLinija.Name = "numLinija";
            this.numLinija.Size = new System.Drawing.Size(117, 26);
            this.numLinija.TabIndex = 2;
            // 
            // numVozilo
            // 
            this.numVozilo.Location = new System.Drawing.Point(528, 135);
            this.numVozilo.Name = "numVozilo";
            this.numVozilo.Size = new System.Drawing.Size(117, 26);
            this.numVozilo.TabIndex = 3;
            this.numVozilo.ValueChanged += new System.EventHandler(this.numVozilo_ValueChanged);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(830, 135);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(285, 26);
            this.txtOpis.TabIndex = 4;
            this.txtOpis.TextChanged += new System.EventHandler(this.txtOpis_TextChanged);
            // 
            // dateVrijeme
            // 
            this.dateVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateVrijeme.Location = new System.Drawing.Point(668, 135);
            this.dateVrijeme.Name = "dateVrijeme";
            this.dateVrijeme.Size = new System.Drawing.Size(131, 26);
            this.dateVrijeme.TabIndex = 5;
            this.dateVrijeme.ValueChanged += new System.EventHandler(this.dateVrijeme_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "UNOS NOVE VOZNE LINIJE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLinija
            // 
            this.lblLinija.AutoSize = true;
            this.lblLinija.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLinija.Location = new System.Drawing.Point(56, 107);
            this.lblLinija.Name = "lblLinija";
            this.lblLinija.Size = new System.Drawing.Size(70, 25);
            this.lblLinija.TabIndex = 7;
            this.lblLinija.Text = "ID linije";
            this.lblLinija.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPolazak
            // 
            this.lblPolazak.AutoSize = true;
            this.lblPolazak.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPolazak.Location = new System.Drawing.Point(194, 107);
            this.lblPolazak.Name = "lblPolazak";
            this.lblPolazak.Size = new System.Drawing.Size(133, 25);
            this.lblPolazak.TabIndex = 8;
            this.lblPolazak.Text = "Stanica polaska";
            // 
            // lblOdrediste
            // 
            this.lblOdrediste.AutoSize = true;
            this.lblOdrediste.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOdrediste.Location = new System.Drawing.Point(356, 107);
            this.lblOdrediste.Name = "lblOdrediste";
            this.lblOdrediste.Size = new System.Drawing.Size(147, 25);
            this.lblOdrediste.TabIndex = 9;
            this.lblOdrediste.Text = "Stanica odredišta";
            this.lblOdrediste.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblVozilo
            // 
            this.lblVozilo.AutoSize = true;
            this.lblVozilo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVozilo.Location = new System.Drawing.Point(523, 107);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(80, 25);
            this.lblVozilo.TabIndex = 10;
            this.lblVozilo.Text = "ID vozila";
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVrijeme.Location = new System.Drawing.Point(663, 107);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(136, 25);
            this.lblVrijeme.TabIndex = 11;
            this.lblVrijeme.Text = "Vrijeme polaska";
            this.lblVrijeme.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOpis.Location = new System.Drawing.Point(825, 107);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(49, 25);
            this.lblOpis.TabIndex = 12;
            this.lblOpis.Text = "Opis";
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(194)))), ((int)(((byte)(173)))));
            this.btnSpremi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSpremi.Location = new System.Drawing.Point(524, 212);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(121, 49);
            this.btnSpremi.TabIndex = 13;
            this.btnSpremi.Text = "SPREMI";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // UNOSfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1180, 273);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblVrijeme);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.lblOdrediste);
            this.Controls.Add(this.lblPolazak);
            this.Controls.Add(this.lblLinija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateVrijeme);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.numVozilo);
            this.Controls.Add(this.numLinija);
            this.Controls.Add(this.combDolazak);
            this.Controls.Add(this.combPolazak);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UNOSfrm";
            this.ShowIcon = false;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLinija;
        private System.Windows.Forms.Label lblPolazak;
        private System.Windows.Forms.Label lblOdrediste;
        private System.Windows.Forms.Label lblVozilo;
        private System.Windows.Forms.Label lblVrijeme;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Button btnSpremi;
    }
}