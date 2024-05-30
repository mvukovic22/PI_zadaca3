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
                STUDENTSfrm Studentsfrm = new STUDENTSfrm();
                Studentsfrm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Pogrešni podaci", "Neuspjela prijava", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
