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
    public partial class Admin : Form
    {
        MainMenu menu;
        public Admin(MainMenu mn)
        {
            InitializeComponent();
            lNama.Text = "Selamat Datang, " + Koneksi.Session_Username;
            menu = mn;
        }
    }
}
