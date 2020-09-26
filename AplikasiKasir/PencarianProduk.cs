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

namespace AplikasiKasir
{
    public partial class PencarianProduk : Form
    {
        Kasir kasir;
        Dictionary<object, object> testProduk = new Dictionary<object, object>();

        public PencarianProduk(Kasir ks)
        {
            kasir = ks;
            InitializeComponent();
            ambilData();
        }

        private void ambilData()
        {
            try
            {
                MySqlConnection con = Koneksi.koneksi();
                MySqlCommand cmd = new MySqlCommand("SELECT kode_produk, nama_produk FROM data_produk", con);
                MySqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                    testProduk.Add(read["nama_produk"], read["kode_produk"]);

                cbProduk.DataSource = new BindingSource(testProduk, null);
                cbProduk.DisplayMember = "Key";
                cbProduk.ValueMember = "Value";
            }
            catch
            {
                MessageBox.Show("Tidak Ada Produk Yang Terdaftar Dalam Sistem!", "Tidak Ada Data");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kasir.pencarian(cbProduk.SelectedValue);
            this.Close();
        }
    }
}
