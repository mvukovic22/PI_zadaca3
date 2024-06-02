using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusZaPlus.Models;
using BusZaPlus.Repositories;
using DBLayer;

namespace BusZaPlus
{
    public partial class UNOSfrm : Form
    {

        public UNOSfrm()
        {
            InitializeComponent();
            numVozilo.Value = 1;
            numVozilo.Minimum = 1;
            numVozilo.Maximum = 15;
            numLinija.Minimum = 1;
            numLinija.Value = 1;
        }

        private void UNOSfrm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                combPolazak.Items.Add(i.ToString());
                combDolazak.Items.Add(i.ToString());
            }

        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            var linija = new Linija()
            {
                ID_linije = int.Parse(numLinija.Text),
                ID_stanice_dolazak = int.Parse(combDolazak.Text),
                ID_stanice_polazak = int.Parse(combPolazak.Text),
                ID_vozila = int.Parse(numVozilo.Text),
                Termin_dolaska = TimeSpan.Parse(dateVrijeme.Text),
                Opis = txtOpis.Text
            };
            MessageBox.Show("Linija je uspješno dodana.", "Uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LinijaRepository.UnosLinije(linija);
            this.Close();
        }
    }
}
