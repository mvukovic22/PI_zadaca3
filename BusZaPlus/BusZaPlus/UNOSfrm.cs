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
            numVozilo.Minimum = 1;
            numVozilo.Maximum = 10;
            numLinija.Minimum = 1;
        }

        private void UNOSfrm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                combPolazak.Items.Add(i.ToString());
                combDolazak.Items.Add(i.ToString());
            }

        }

        private void btnSpremi_Click(object sender, EventArgs e)
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
            LinijaRepository.UnosLinije(linija);
            this.Close();
        }

        /*private void btnSpremi_Click(object sender, EventArgs e)
        {
            UNOSfrm Unosfrm = new UNOSfrm();
            Unosfrm.FormClosed += UNOSfrm_FormClosed;
            Unosfrm.ShowDialog();
        }

        private void UNOSfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowVozneLinije();
        }*/
    }
}
