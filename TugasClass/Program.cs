using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classobj
{
    public class Program
    {
        public static void Main()
        {
            ClassMobil mobil1 = new ClassMobil();

            mobil1.Warna = "Putih";
            mobil1.JumlahPintu = 4;
            mobil1.Merk = "Honda";
            mobil1.Model = "Brio";
            mobil1.TahunKeluar = 2019;

            mobil1.Gas(180);
            mobil1.Klakson("tiiin tiiiin titititin");
            mobil1.Tampilkaninfo();



          
        }
    }



}
