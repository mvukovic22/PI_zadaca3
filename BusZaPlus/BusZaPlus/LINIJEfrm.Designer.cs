﻿namespace BusZaPlus
{
    partial class LINIJEfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LINIJEfrm));
            this.dgvLinije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLinije
            // 
            this.dgvLinije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLinije.BackgroundColor = System.Drawing.Color.White;
            this.dgvLinije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinije.Location = new System.Drawing.Point(18, 72);
            this.dgvLinije.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLinije.Name = "dgvLinije";
            this.dgvLinije.RowHeadersWidth = 62;
            this.dgvLinije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinije.Size = new System.Drawing.Size(1087, 337);
            this.dgvLinije.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label1.Location = new System.Drawing.Point(389, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRIKAZ SVIH VOZNIH LINIJA";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(194)))), ((int)(((byte)(173)))));
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnNovo.Location = new System.Drawing.Point(18, 427);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(202, 51);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "KREIRAJ NOVO";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(194)))), ((int)(((byte)(173)))));
            this.btnUredi.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnUredi.Location = new System.Drawing.Point(255, 427);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(121, 51);
            this.btnUredi.TabIndex = 4;
            this.btnUredi.Text = "UREDI";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(194)))), ((int)(((byte)(173)))));
            this.btnIzbrisi.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnIzbrisi.Location = new System.Drawing.Point(413, 427);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(121, 51);
            this.btnIzbrisi.TabIndex = 5;
            this.btnIzbrisi.Text = "IZBRIŠI";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click_1);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.btnDetalji.Location = new System.Drawing.Point(857, 443);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(248, 35);
            this.btnDetalji.TabIndex = 7;
            this.btnDetalji.Text = "DETALJI VOZNIH STANICA";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(183)))), ((int)(((byte)(161)))));
            this.btnOdjava.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnOdjava.Location = new System.Drawing.Point(984, 9);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(121, 51);
            this.btnOdjava.TabIndex = 8;
            this.btnOdjava.Text = "ODJAVA";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // LINIJEfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1127, 509);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLinije);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LINIJEfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz svih voznih linija";
            this.Load += new System.EventHandler(this.LINIJEfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLinije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnOdjava;
    }
}