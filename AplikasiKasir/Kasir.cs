using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AplikasiKasir.Function;

namespace AplikasiKasir
{
    public partial class Kasir : Form
    {
        MainMenu mn;

        public Kasir(MainMenu menu)
        {
            InitializeComponent();
            lNamaKasir.Text = "Selamat Datang, " + Koneksi.Session_Username;
            mn = menu;
        }

        public void pencarian(object kode) { tKode.Text = kode.ToString(); }
            
        private void invoice()
        {
            int invoice;

            MySqlConnection con = Koneksi.koneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM data_pembelian WHERE invoice LIKE 'Invoice" +
                DateTime.Now.ToString("y''MM''dd") + "%'", con);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.HasRows)
            {
                read.Read();
                invoice = Convert.ToInt32(read["COUNT(*)"]);
            }
            else
                invoice = 0;

            string jAngka = Convert.ToString(invoice + 1);
            int angka = 4 - Convert.ToInt32(jAngka.Count());
            string idInvoice = "" + jAngka;

            for (int i = 0; i < angka; i++)
                idInvoice = idInvoice.Insert(0, "0");

            string invoices = DateTime.Now.ToString("y''MM''dd") + idInvoice;

            lInvoice.Text = "Invoice" + invoices;
        }

        private void keyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.C || e.KeyCode == Keys.F12)
                Logout(mn);
            if (e.KeyCode == Keys.F2)
                button2_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e) { Logout(mn); }

        private void button2_Click(object sender, EventArgs e)
        {
            PencarianProduk pp = new PencarianProduk(this);
            pp.Show();
        }
    }
}
