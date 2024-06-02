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


            dgvLinije.Columns["ID_linije"].HeaderText = "Linija";
            dgvLinije.Columns["ID_stanice_polazak"].HeaderText = "Stanica polaska";
            dgvLinije.Columns["ID_stanice_dolazak"].HeaderText = "Stanica odredišta";
            dgvLinije.Columns["ID_vozila"].HeaderText = "Vozilo";
            dgvLinije.Columns["Termin_dolaska"].HeaderText = "Vrijeme polaska";
            dgvLinije.Columns["Opis"].HeaderText = "Opis linije";

            dgvLinije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            UNOSfrm Unosfrm = new UNOSfrm();
            Unosfrm.ShowDialog();
            ShowVozneLinije();
        }  

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            UNOSfrm Unosfrm = new UNOSfrm();
            Unosfrm.FormClosed += UNOSfrm_FormClosed;
            Unosfrm.ShowDialog();
        }

        private void UNOSfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowVozneLinije();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            UPDATEfrm Updatefrm = new UPDATEfrm();
            Updatefrm.ShowDialog();
        }

        private void btnIzbrisi_Click_1(object sender, EventArgs e)
        {
            BRISANJEfrm Brisanjefrm = new BRISANJEfrm();
            Brisanjefrm.ShowDialog();
            //ShowVozneLinije();
            Close();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            DETALJIfrm Detaljifrm = new DETALJIfrm();
            Detaljifrm.ShowDialog();
            //ShowVozneLinije();
            Close();

        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Hide();
            LOGINfrm Loginfrm = new LOGINfrm();
            Loginfrm.ShowDialog(); 
        }
    }
}
