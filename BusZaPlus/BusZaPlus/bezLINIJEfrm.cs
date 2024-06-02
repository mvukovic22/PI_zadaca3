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
    public partial class bezLINIJEfrm : Form
    {

        public bezLINIJEfrm()
        {
            InitializeComponent();
        }

        private void bezLINIJEfrm_Load(object sender, EventArgs e)
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


            dgvLinije.Columns["ID_linije"].HeaderText = "Linija";
            dgvLinije.Columns["ID_stanice_polazak"].HeaderText = "Stanica polaska";
            dgvLinije.Columns["ID_stanice_dolazak"].HeaderText = "Stanica odredišta";
            dgvLinije.Columns["ID_vozila"].HeaderText = "Vozilo";
            dgvLinije.Columns["Termin_dolaska"].HeaderText = "Vrijeme polaska";
            dgvLinije.Columns["Opis"].HeaderText = "Opis linije";

            dgvLinije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            DETALJIfrm Detaljifrm = new DETALJIfrm();
            Detaljifrm.ShowDialog();
            //ShowVozneLinije();
            Close();
        }

        /*private void pretrazifunkcija()
        {
            int uvjet = int.Parse(txtPretraga.Text);
            int uvjet2 = int.Parse(txtPretraga2.Text);
            List<Linija> linije = LinijaRepository.PretrazivanjeLinije(uvjet, uvjet2);
            dgvLinije.DataSource = linije;
        }*/
        private void pretrazifunkcija()
        {
            int uvjet;
            int uvjet2;
            
        if (!string.IsNullOrEmpty(txtPretraga.Text) && int.TryParse(txtPretraga.Text, out uvjet))
            {
                if (!string.IsNullOrEmpty(txtPretraga2.Text) && int.TryParse(txtPretraga2.Text, out uvjet2))
                {
                    // Ako su oba uvjeta upisana, pretraži po oba uvjeta
                    List<Linija> linije = LinijaRepository.PretrazivanjeLinije(uvjet, uvjet2);
                    dgvLinije.DataSource = linije;
                }
                else
                {
                    List<Linija> linije = LinijaRepository.PretrazivanjeLinije(uvjet, 0);
                    dgvLinije.DataSource = linije;
                }
                }
                else if (!string.IsNullOrEmpty(txtPretraga2.Text) && int.TryParse(txtPretraga2.Text, out uvjet2))
                {
                List<Linija> linije = LinijaRepository.PretrazivanjeLinije(0, uvjet2);
                dgvLinije.DataSource = linije;
                }
        }
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            pretrazifunkcija();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ShowVozneLinije();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Hide();
            LOGINfrm Loginfrm = new LOGINfrm();
            Loginfrm.ShowDialog();
        }
    }
}
