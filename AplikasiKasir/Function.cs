using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiKasir
{
    public class Function
    {
        public static void Logout(MainMenu mn)
        {
            Koneksi.Session_Username = "";
            mn.cekSession();
        }
    }
}
