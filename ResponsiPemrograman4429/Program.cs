using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lat
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("21114429", "Gilang ", 1000000);
            Karyawan karyawan2 = new Karyawan("21114499", "Candra", 1500000);
            Console.WriteLine("Gaji bulanan Perusahaan Adityas");
            Console.WriteLine("-----------21.11.4429----------");
            Console.WriteLine("===============================");
            Console.WriteLine();
            Console.WriteLine("No   ID Karyawan       Gaji Bulanan");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", karyawan1.ID, karyawan1.Nama, karyawan1.Gaji);
            Console.WriteLine("2    {0}/{1}          {2}", karyawan2.ID, karyawan2.Nama, karyawan2.Gaji);

            Console.WriteLine();
            Console.WriteLine("Gaji ke 12 cair naik 10%");
            Console.WriteLine();

            karyawan1.NaikkanGaji(10);
            karyawan2.NaikkanGaji(10);

            Console.WriteLine("No   ID Karyawan        Gaji Bulan ke 12");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", karyawan1.ID, karyawan1.Nama, karyawan1.Gaji);
            Console.WriteLine("2    {0}/{1}          {2}", karyawan2.ID, karyawan2.Nama, karyawan2.Gaji);

            Console.ReadKey();
        }
    }

}
