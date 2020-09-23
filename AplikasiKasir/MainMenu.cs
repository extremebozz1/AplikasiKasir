using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKasir
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            if (Koneksi.Session_Username.Equals(""))
            {
                Login lg = new Login();
                lg.Show();
            }
        }

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            label1.Text = "Halo, " + Koneksi.Session_Username;
        }
    }
}
