using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClass
{
    public class ClassMobil
    {
        public static void Main()
        {
            Mobil mobil1 = new Mobil();

            mobil1.Warna = "Hitam";
            mobil1.JumlahPintu = 4;
            mobil1.Merk = "Daihatsu";
            mobil1.Model = "Xenia";
            mobil1.TahunKeluar = 2010;

            mobil1.Gas(180);
            mobil1.Klakson("Tiin Tinn Tiiiiiiiin");
            mobil1.Tampilkaninfo();



            Console.Write("Press <R> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.R) { }
        }
    }



}