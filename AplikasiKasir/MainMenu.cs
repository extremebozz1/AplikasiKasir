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
        private Form activeForm = null;
        public MainMenu()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            cekSession();
            this.BringToFront();
        }

        private void cekSession()
        {
            if (Koneksi.Session_Username.Equals(""))
                openChildForm(new Login(this));
        }

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pChild.Controls.Add(childForm);
            pChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void openChildForm(Login childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Location = new Point((Screen.GetWorkingArea(this).Width - childForm.Width) / 2, (Screen.GetWorkingArea(this).Height - childForm.Height) / 2);
            //childForm.Dock = DockStyle.Fill;
            childForm.StartPosition = FormStartPosition.CenterParent;
            pChild.Controls.Add(childForm);
            pChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void MainMenu_Shown(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}
