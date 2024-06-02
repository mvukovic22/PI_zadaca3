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
    public partial class POCETNAZAPOSLENIKfrm : Form
    {
        public POCETNAZAPOSLENIKfrm()
        {
            InitializeComponent();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            Hide();
            LINIJEfrm Linijefrm = new LINIJEfrm();
            Linijefrm.ShowDialog();
            Close();
        }
    }
}
