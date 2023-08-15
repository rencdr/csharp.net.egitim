//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Ogrenci
//{
//    public string OgrenciAdi { get; set; }
//    public string OgrenciYasi { get; set; }
//    public string OgrenciSinifi { get; set; }
//    public string OgrenciNotu { get; set; }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        List<Ogrenci> ogrenciler = new List<Ogrenci>
//        {
//            new Ogrenci { OgrenciAdi = "Ahmet", OgrenciYasi = "20", OgrenciSinifi = "11A", OgrenciNotu = "85" },
//            new Ogrenci { OgrenciAdi = "Ayşe", OgrenciYasi = "19", OgrenciSinifi = "10B", OgrenciNotu = "92" },
//            new Ogrenci { OgrenciAdi = "Mehmet", OgrenciYasi = "21", OgrenciSinifi = "12C", OgrenciNotu = "78" },
//            // Diğer öğrencileri burada ekleyebilirsiniz.
//        };

//        // LINQ sorguları örnekleri
//        var yuksekNotAlanlar = ogrenciler.Where(o => int.Parse(o.OgrenciNotu) >= 85);
//        var sinifListesi = ogrenciler.Select(o => o.OgrenciSinifi).Distinct();
//        var adiAhmetOlanlar = ogrenciler.Where(o => o.OgrenciAdi == "Ahmet");

//        // Örnek sorguları ekrana yazdıralım
//        Console.WriteLine("Yüksek Not Alan Öğrenciler:");
//        foreach (var ogrenci in yuksekNotAlanlar)
//        {
//            Console.WriteLine(ogrenci.OgrenciAdi);
//        }

//        Console.WriteLine("Farklı Sınıflar:");
//        foreach (var sinif in sinifListesi)
//        {
//            Console.WriteLine(sinif);
//        }

//        Console.WriteLine("Adı Ahmet Olan Öğrenciler:");
//        foreach (var ogrenci in adiAhmetOlanlar)
//        {
//            Console.WriteLine(ogrenci.OgrenciAdi);
//        }
//    }
//}
