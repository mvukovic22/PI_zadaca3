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
    public partial class LOGINfrm : Form
    {
        public LOGINfrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           string username = txtUsername.Text;
           string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Popunite sva polja", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (username == "mladenvukovic55" && password == "2503")
            {
                Hide();
                MessageBox.Show("Prijavljeni ste kao zaposlenik", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LINIJEfrm Linijefrm = new LINIJEfrm();
                Linijefrm.ShowDialog();
                Close();
            }

            {
                MessageBox.Show("Pogrešni podaci", "Neuspjela prijava", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBezPrijave_Click_1(object sender, EventArgs e)
        {
            Hide();
            MessageBox.Show("Nastavljate bez prijave", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bezLINIJEfrm BezPrijavefrm = new bezLINIJEfrm();
            BezPrijavefrm.ShowDialog();
            Close();
        }
    }
}
