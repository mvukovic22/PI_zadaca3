namespace BusZaPlus
{
    partial class bezLINIJEfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bezLINIJEfrm));
            this.dgvLinije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPretraga2 = new System.Windows.Forms.Label();
            this.txtPretraga2 = new System.Windows.Forms.TextBox();
            this.btnPovratak = new System.Windows.Forms.Button();
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
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(194)))), ((int)(((byte)(173)))));
            this.btnPretrazi.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnPretrazi.Location = new System.Drawing.Point(751, 486);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(139, 51);
            this.btnPretrazi.TabIndex = 6;
            this.btnPretrazi.Text = "PRETRAŽI";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.btnDetalji.Location = new System.Drawing.Point(857, 427);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(248, 35);
            this.btnDetalji.TabIndex = 7;
            this.btnDetalji.Text = "DETALJI VOZNIH STANICA";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblPretraga.Location = new System.Drawing.Point(99, 462);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(397, 32);
            this.lblPretraga.TabIndex = 8;
            this.lblPretraga.Text = "Unesite željenu stanicu polaska (broj) :";
            // 
            // txtPretraga
            // 
            this.txtPretraga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPretraga.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtPretraga.Location = new System.Drawing.Point(502, 462);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(218, 39);
            this.txtPretraga.TabIndex = 9;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(194)))), ((int)(((byte)(173)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnReset.Location = new System.Drawing.Point(896, 486);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(139, 51);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "RESETIRAJ";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPretraga2
            // 
            this.lblPretraga2.AutoSize = true;
            this.lblPretraga2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblPretraga2.Location = new System.Drawing.Point(193, 521);
            this.lblPretraga2.Name = "lblPretraga2";
            this.lblPretraga2.Size = new System.Drawing.Size(303, 32);
            this.lblPretraga2.TabIndex = 11;
            this.lblPretraga2.Text = "Unesite željeno vozilo (broj) :";
            // 
            // txtPretraga2
            // 
            this.txtPretraga2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPretraga2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtPretraga2.Location = new System.Drawing.Point(502, 521);
            this.txtPretraga2.Name = "txtPretraga2";
            this.txtPretraga2.Size = new System.Drawing.Size(218, 39);
            this.txtPretraga2.TabIndex = 12;
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(183)))), ((int)(((byte)(161)))));
            this.btnPovratak.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnPovratak.Location = new System.Drawing.Point(984, 9);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(121, 51);
            this.btnPovratak.TabIndex = 13;
            this.btnPovratak.Text = "IZLAZ";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // bezLINIJEfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1127, 590);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.txtPretraga2);
            this.Controls.Add(this.lblPretraga2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLinije);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bezLINIJEfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz svih voznih linija";
            this.Load += new System.EventHandler(this.bezLINIJEfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnDetalji;
        public System.Windows.Forms.DataGridView dgvLinije;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPretraga2;
        private System.Windows.Forms.TextBox txtPretraga2;
        private System.Windows.Forms.Button btnPovratak;
    }
}