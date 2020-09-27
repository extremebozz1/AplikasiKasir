using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKasir
{
    public partial class Pembayaran : Form
    {
        Kasir kasir;
        long totalBelanja;
        CultureInfo idID = CultureInfo.CreateSpecificCulture("id-ID");

        public Pembayaran(Kasir ks, int total)
        {
            InitializeComponent();
            kasir = ks;
            totalBelanja = total;
            lTotalHargaBelanja.Text = string.Format(idID, "{0:#,##0}", totalBelanja);
        }

        private void tBayar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int posisiKursor = tBayar.SelectionStart;
                tBayar.Text = string.Format(idID, "{0:#,##0}", Convert.ToInt64(Regex.Replace(tBayar.Text, @"[\W+\.~]", "")));
                tBayar.SelectionStart = posisiKursor;
            } catch { }
        }
    }
}
