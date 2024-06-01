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
    public partial class BRISANJEfrm : Form
    {
        public BRISANJEfrm()
        {
            InitializeComponent();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Linija je uspješno obrisana.", "Uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LinijaRepository.BrisanjeLinije(int.Parse(numLinija.Text));
            Hide();
            LINIJEfrm Linijefrm = new LINIJEfrm();
            Linijefrm.ShowDialog();
            Close();
        }

    }
}
