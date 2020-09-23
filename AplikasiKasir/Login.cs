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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Koneksi.koneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT nama_user FROM data_user WHERE nama_user = '" + tUsername.Text +
                "'AND password = '" + tPassword.Text + "'", con);
            MySqlDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                read.Read();
                MessageBox.Show("Login Berhasil!", "Berhasil");
                Koneksi.Session_Username = read["nama_user"].ToString();
                con.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username atau Password anda salah!", "Gagal Login");
                tUsername.Focus();
            }
        }
    }
}
