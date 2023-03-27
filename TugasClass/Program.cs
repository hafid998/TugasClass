using System;

public class Mobil
{
    //properties
    public string Warna { get; set; }
    public int JumlahPintu { get; set; }
    public string Merk { get; set; }
    public string Model { get; set; }
    public int TahunKeluar { get; set; }

    //method
    public void Gas(int kecepatan)
    {
        Console.WriteLine("Mobil {0} berjalan dengan kecepatan {1}", Model, kecepatan);
    }
    public void Klakson(string suara)
    {
        Console.WriteLine("suara klakson {0}", suara);
    }

    public void Tampilkaninfo()
    {
        Console.WriteLine("Mobil saya berwarna {0}, merk {1}, model {2}, keluaran tahun {3}, dengan jumlah pintu {4}", Warna, Merk, Model, TahunKeluar, JumlahPintu);
    }

}