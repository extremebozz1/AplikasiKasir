using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AplikasiKasir
{
    public class Koneksi
    {
        public static string Session_Username = String.Empty;

        public static bool cekKoneksi()
        {
            bool berhasil = true;
            try
            {
                var con = new MySqlConnection("Server=localhost;Database=appkasir;Uid=root;Pwd=");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                    berhasil = true;
                con.Close();
                return berhasil;
            } 
            catch 
            {
                berhasil = false;
                MessageBox.Show("Gagal Terhubung Dengan Database!", "Error!");
                if (!berhasil)
                {
                    string lokasi;

                    FolderBrowserDialog browserdialog = new FolderBrowserDialog();

                    DialogResult result = browserdialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        lokasi = Path.Combine(browserdialog.SelectedPath, @"mysql\data\appkasir");
                        string lokasifolder = @"aplikasikasir";

                        if (Directory.Exists(lokasifolder))
                        {
                            Directory.CreateDirectory(lokasi);

                            string[] files = Directory.GetFiles(lokasifolder);
                            string fileName, destFile;

                            foreach (string s in files)
                            {
                                fileName = Path.GetFileName(s);
                                destFile = Path.Combine(lokasi, fileName);
                                File.Copy(s, destFile, false);
                            }

                            berhasil = cekKoneksi();
                        }
                        else
                            MessageBox.Show("Source path does not exist!");
                    }
                }
            }
            return berhasil;
        }

        public static MySqlConnection koneksi()
        {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection("Server=localhost;Database=aplikasikasir;Uid=root;Pwd=");
                con.Open();
            }
            catch { }
            return con;
        }
    }
}
