using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lat
{
    internal class Karyawan
    {
        public string ID { get; set; }
        public string Nama { get; set; }
        public float Gaji { get; set; }
        public Karyawan(string nik, string nama, float gaji)
        {
            this.ID = nik;
            this.Nama = nama;
            if (gaji < 0)
            {
                gaji = 0;
            }
            this.Gaji = gaji;
        }

        public void NaikkanGaji(float persentase)
        {
            this.Gaji = persentase / 100 * this.Gaji + this.Gaji;
        }

    }
}
