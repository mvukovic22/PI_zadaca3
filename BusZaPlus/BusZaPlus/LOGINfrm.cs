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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
           string username = txtUsername.Text;
           string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Popunite sva polja", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (username == "mladenvukovic55" && password == "2503")
            {
                MessageBox.Show("Prijavljeni ste kao zaposlenik", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                POCETNAZAPOSLENIKfrm PocetnaZaposlenikfrm = new POCETNAZAPOSLENIKfrm();
                PocetnaZaposlenikfrm.ShowDialog();
                Close();
            }

            {
                MessageBox.Show("Pogrešni podaci", "Neuspjela prijava", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void BtnBezPrijave_Click_1(object sender, EventArgs e)
        {
            
            MessageBox.Show("Nastavljate bez prijave", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
            POCETNAKORISNIKfrm PocetnaKorisnikfrm = new POCETNAKORISNIKfrm();
            PocetnaKorisnikfrm.ShowDialog();
            Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
