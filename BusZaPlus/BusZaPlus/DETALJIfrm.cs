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
    public partial class DETALJIfrm : Form
    {
        public DETALJIfrm()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
          Hide();
          bezLINIJEfrm BezLinijefrm = new bezLINIJEfrm();
          BezLinijefrm.ShowDialog();
          Close();
        }
    }
}
