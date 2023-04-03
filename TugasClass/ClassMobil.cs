using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ClassMobil
{
    // field
    private string warna = "...";
    private int jumlahPintu;
    private string merk = "...";
    private string model = "...";
    private int tahunKeluar;


    public string Warna
    {
        get
        {
            return warna;
        }
        set
        {
            warna = value;
        }
    }

    public int JumlahPintu
    {
        get
        {
            return jumlahPintu;
        }
        set
        {
            jumlahPintu = value;
        }
    }

    public string Merk
    {
        get
        {
            return merk;
        }
        set
        {
            merk = value;
        }
    }

    public string Model
    {
        get
        {
            return model;
        }
        set
        {
            model = value;
        }
    }

    public int TahunKeluar
    {
        get
        {
            return tahunKeluar;
        }
        set
        {
            tahunKeluar = value;
        }
    }
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