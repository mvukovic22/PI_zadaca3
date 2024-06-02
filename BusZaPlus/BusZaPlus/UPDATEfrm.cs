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
            numVozilo.Minimum = 1;
            numVozilo.Maximum = 10;
            numLinija.Value = 1;
            numVozilo.Value = 1;
        }

        private void UPDATEfrm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                combPolazak.Items.Add(i.ToString());
                combDolazak.Items.Add(i.ToString());
            }

        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            Linija linija = new Linija()
            {
                ID_linije = int.Parse(numLinija.Text),
                ID_stanice_polazak = int.Parse(combPolazak.Text),
                ID_stanice_dolazak = int.Parse(combDolazak.Text),
                ID_vozila = int.Parse(numVozilo.Text),
                Termin_dolaska = TimeSpan.Parse(dateVrijeme.Text),
                Opis = txtOpis.Text
            };

            LinijaRepository.AzuriranjeLinije(linija);
            MessageBox.Show("Linija je uspješno izmijenjena.", "Uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            LINIJEfrm Linijefrm = new LINIJEfrm();
            Linijefrm.ShowDialog();
                    }


    }
}
