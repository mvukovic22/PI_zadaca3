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
    public partial class POCETNAKORISNIKfrm : Form
    {
        public POCETNAKORISNIKfrm()
        {
            InitializeComponent();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            Hide();
            bezLINIJEfrm BezLinijefrm = new bezLINIJEfrm();
            BezLinijefrm.ShowDialog();
            Close();
        }
    }
}
