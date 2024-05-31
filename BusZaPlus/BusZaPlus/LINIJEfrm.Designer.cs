namespace BusZaPlus
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
            this.dgvLinije = new System.Windows.Forms.DataGridView();
            //this.btnEvaluateStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvLinije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLinije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinije.Location = new System.Drawing.Point(12, 12);
            this.dgvLinije.Name = "dgvLinije";
            this.dgvLinije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinije.Size = new System.Drawing.Size(776, 390);
            this.dgvLinije.TabIndex = 0;
            // 
            // btnEvaluateStudent
            /*
            this.btnEvaluateStudent.Location = new System.Drawing.Point(680, 408);
            this.btnEvaluateStudent.Name = "btnEvaluateStudent";
            this.btnEvaluateStudent.Size = new System.Drawing.Size(108, 30);
            this.btnEvaluateStudent.TabIndex = 1;
            this.btnEvaluateStudent.Text = "Evaluiraj studenta";
            this.btnEvaluateStudent.UseVisualStyleBackColor = true;
            this.btnEvaluateStudent.Click += new System.EventHandler(this.btnEvaluateStudent_Click);
            */ 
            // FrmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            //this.Controls.Add(this.btnEvaluateStudent);
            this.Controls.Add(this.dgvLinije);
            this.Name = "LINIJEfrm";
            this.Text = "LINIJEfrm";
            this.Load += new System.EventHandler(this.LINIJEfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLinije;
        //private System.Windows.Forms.Button btnEvaluateStudent;
    }
}