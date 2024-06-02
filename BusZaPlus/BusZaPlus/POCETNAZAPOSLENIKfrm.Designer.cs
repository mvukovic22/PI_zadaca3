namespace BusZaPlus
{
    partial class POCETNAZAPOSLENIKfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POCETNAZAPOSLENIKfrm));
            this.lblZaposlenikPocetna = new System.Windows.Forms.Label();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.btnPracenje = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblZaposlenikPocetna
            // 
            this.lblZaposlenikPocetna.AutoSize = true;
            this.lblZaposlenikPocetna.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lblZaposlenikPocetna.Location = new System.Drawing.Point(277, 25);
            this.lblZaposlenikPocetna.Name = "lblZaposlenikPocetna";
            this.lblZaposlenikPocetna.Size = new System.Drawing.Size(263, 45);
            this.lblZaposlenikPocetna.TabIndex = 3;
            this.lblZaposlenikPocetna.Text = "GLAVNI IZBORNIK";
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(194)))), ((int)(((byte)(173)))));
            this.btnPrikaz.FlatAppearance.BorderSize = 0;
            this.btnPrikaz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(183)))), ((int)(((byte)(161)))));
            this.btnPrikaz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(183)))), ((int)(((byte)(161)))));
            this.btnPrikaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaz.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.btnPrikaz.Location = new System.Drawing.Point(246, 115);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(313, 62);
            this.btnPrikaz.TabIndex = 4;
            this.btnPrikaz.Text = "Prikaz voznih linija";
            this.btnPrikaz.UseVisualStyleBackColor = false;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // btnPracenje
            // 
            this.btnPracenje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(194)))), ((int)(((byte)(173)))));
            this.btnPracenje.FlatAppearance.BorderSize = 0;
            this.btnPracenje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPracenje.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.btnPracenje.Location = new System.Drawing.Point(208, 204);
            this.btnPracenje.Name = "btnPracenje";
            this.btnPracenje.Size = new System.Drawing.Size(388, 62);
            this.btnPracenje.TabIndex = 5;
            this.btnPracenje.Text = "Praćenje lokacije autobusa";
            this.btnPracenje.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(194)))), ((int)(((byte)(173)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.button2.Location = new System.Drawing.Point(246, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(313, 62);
            this.button2.TabIndex = 6;
            this.button2.Text = "Broj putnika u autobusu";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(0, 404);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 27);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Prijavljen zaposlenik : Mladen Vuković";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // POCETNAZAPOSLENIKfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPracenje);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.lblZaposlenikPocetna);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "POCETNAZAPOSLENIKfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "glavni izbornik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZaposlenikPocetna;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.Button btnPracenje;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}