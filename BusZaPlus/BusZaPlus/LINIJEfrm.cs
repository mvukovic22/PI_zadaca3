using BusZaPlus.Models;
using BusZaPlus.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusZaPlus
{
    public partial class LINIJEfrm : Form
    {
        public LINIJEfrm()
        {
            InitializeComponent();
        }

        private void LINIJEfrm_Load(object sender, EventArgs e)
        {
            ShowVozneLinije();
        }

        private void ShowVozneLinije()
        {
            var linije = LinijaRepository.GetLinije();
            dgvLinije.DataSource = linije;

            dgvLinije.Columns["ID_linije"].DisplayIndex = 0;
            dgvLinije.Columns["ID_vozila"].DisplayIndex = 3;
            dgvLinije.Columns["ID_stanice_polazak"].DisplayIndex = 1;
            dgvLinije.Columns["ID_stanice_dolazak"].DisplayIndex = 2;
            dgvLinije.Columns["Termin_dolaska"].DisplayIndex = 4;
            dgvLinije.Columns["Opis"].DisplayIndex = 5;
        }

 

        /*private void btnEvaluateStudent_Click(object sender, EventArgs e)
        {
            Student selectedStudent = dgvStudents.CurrentRow.DataBoundItem as Student;
            if (selectedStudent != null)
            {
                FrmEvaluation frmEvaluation = new FrmEvaluation(selectedStudent);
                frmEvaluation.ShowDialog();
            }
        }*/
    }
}
