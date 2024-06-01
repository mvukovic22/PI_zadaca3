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
    public partial class UPDATEfrm : Form
    {

        public UPDATEfrm()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Linija linija = new Linija();
            linija.ID_linije = int.Parse(numLinija.Text);
            linija.ID_stanice_polazak = int.Parse(combPolazak.Text);
            linija.ID_stanice_dolazak = int.Parse(combDolazak.Text);
            linija.ID_vozila = int.Parse(numVozilo.Text);
            linija.Termin_dolaska = TimeSpan.Parse(dateVrijeme.Text);
            linija.Opis = txtOpis.Text;

            LinijaRepository.AzuriranjeLinije(linija);
            MessageBox.Show("Linije su uspješno izmijenjene.", "Uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            LINIJEfrm Linijefrm = new LINIJEfrm();
            Linijefrm.ShowDialog();
            Close();
        }

        private void UPDATEfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
