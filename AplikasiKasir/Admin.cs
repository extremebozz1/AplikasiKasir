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
        Form activeForm;

        public Admin(MainMenu mn)
        {
            InitializeComponent();
            menu = mn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.openChildForm(new Kasir(menu));
        }

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            Text = childForm.Text + " ( " + Koneksi.Session_Username + " )";
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pChild.Controls.Add(childForm);
            pChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new DataUser(this));
        }
    }
}
