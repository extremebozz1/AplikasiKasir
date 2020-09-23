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
        Login _lg = new Login();
        public MainMenu()
        {
            InitializeComponent();
            cekSession();
        }

        private void cekSession()
        {
            //if (Koneksi.Session_Username.Equals(""))
            //{
            //    Login lg = new Login();
            //    lg.Show();
            //}
            Login lg = Login.getInstance();
            if (lg.IsDisposed == true)
                lg = new Login();
                
            if (Koneksi.Session_Username.Equals(""))
                if (!lg.Visible)
                    lg.Show();
                else
                    lg.BringToFront();
        }

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            cekSession();
            label1.Text = "Halo, " + Koneksi.Session_Username;
        }
    }
}
