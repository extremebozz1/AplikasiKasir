﻿using System;
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
    public partial class DataUser : Form
    {
        Admin admin;
        public DataUser(Admin adm)
        {
            InitializeComponent();
            admin = adm;
        }
    }
}
