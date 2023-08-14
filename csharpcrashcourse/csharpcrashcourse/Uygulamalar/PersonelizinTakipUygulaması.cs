//using System;
//using System.Collections.Generic;

//namespace csharpcrashcourse.Uygulamalar
//{
//    internal class PersonelizinTakipUygulamasi
//    {
//        static List<Personel> personelListesi = new List<Personel>();
//        static bool devam = true;
//        static int personelIDCounter = 1; // Her yeni personel için benzersiz bir ID oluşturmak için sayaç

//        static void Main(string[] args)
//        {
//            while (devam)
//            {
//                Console.WriteLine("Personel/İzin Takip Uygulamasına Hoşgeldiniz.");
//                Console.WriteLine("1.Personel Ekle");
//                Console.WriteLine("2.İzin ver");
//                Console.WriteLine("3.Çıkış Yap");
//                int secim = int.Parse(Console.ReadLine());

//                switch (secim)
//                {
//                    case 1:
//                        personelEkle();
//                        break;
//                    case 2:
//                        izinVer();
//                        break;
//                    case 3:
//                        cikisYap();
//                        break;
//                    default:
//                        Console.WriteLine("Geçersiz Bir Seçim Yaptınız.");
//                        break;
//                }
//            }
//        }

//        static void personelEkle()
//        {
//            Console.WriteLine("Personel Görev Unvanını Seçiniz:");
//            Console.WriteLine("1. Stajyer");
//            Console.WriteLine("2. Müdür");
//            Console.WriteLine("3. Çalışan");
//            int unvanSecim = int.Parse(Console.ReadLine());

//            Console.WriteLine("Personel Adınız Giriniz:");
//            string isim = Console.ReadLine();

//            Console.WriteLine("Personelin Departmanını Giriniz:");
//            string departman = Console.ReadLine();

//            Console.WriteLine("Personelin Yaşını Giriniz:");
//            int yas = int.Parse(Console.ReadLine());

//            Console.WriteLine("Personelin İzin Gününü Giriniz:");
//            int izingunu = int.Parse(Console.ReadLine());

//            int personelID = personelIDCounter++; // Benzersiz bir ID oluşturuluyor
//            Console.WriteLine("Personel ID:" + personelID);

//            switch (unvanSecim)
//            {
//                case 1:
//                    Console.WriteLine("Staj Süresini Giriniz:");
//                    int stajSuresi = int.Parse(Console.ReadLine());
//                    personelListesi.Add(new Stajyer(personelID, isim, departman, yas, izingunu, stajSuresi));
//                    Console.WriteLine("Stajyer başarıyla eklendi.");
//                    break;
//                case 2:
//                    Console.WriteLine("Yetki Seviyesini Giriniz:");
//                    string yetkiSeviyesi = Console.ReadLine();
//                    personelListesi.Add(new Mudur(personelID, isim, departman, yas, izingunu, yetkiSeviyesi));
//                    Console.WriteLine("Müdür başarıyla eklendi.");
//                    break;
//                case 3:
//                    Console.WriteLine("Unvanı Giriniz:");
//                    string calisanUnvan = Console.ReadLine();
//                    personelListesi.Add(new Calisan(personelID, isim, departman, yas, izingunu, calisanUnvan));
//                    Console.WriteLine("Çalışan başarıyla eklendi.");
//                    break;
//                default:
//                    Console.WriteLine("Geçersiz Unvan Seçimi.");
//                    break;
//            }
//        }

//        static void izinVer()
//        {
//            Console.WriteLine("Personel ID'sini Giriniz:");
//            int personelID = int.Parse(Console.ReadLine());

//            Personel secilenPersonel = personelListesi.Find(p => p.ID == personelID);

//            if (secilenPersonel != null)
//            {
//                Console.WriteLine("Vereceğiniz izin gününü yazınız:");
//                int izin = int.Parse(Console.ReadLine());

//                if (izin > 0 && izin <= secilenPersonel.IzinGunu)
//                {
//                    secilenPersonel.IzinGunu -= izin;
//                    Console.WriteLine("İzin verildi. Kalan izin günü: " + secilenPersonel.IzinGunu);
//                }
//                else
//                {
//                    Console.WriteLine("Geçersiz izin günü veya yetersiz izin hakkı.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Belirtilen ID'ye sahip personel bulunamadı.");
//            }
//        }

//        static void cikisYap()
//        {
//            devam = false;
//            Console.WriteLine("Çıkış yapılıyor...");
//        }
//    }

//    class Personel
//    {
//        public int ID { get; } // Personel kimlik numarası
//        public string Isim { get; }
//        public string Departman { get; }
//        public int Yas { get; }
//        public int IzinGunu { get; set; }

//        public Personel(int id, string isim, string departman, int yas, int izinGunu)
//        {
//            ID = id;
//            Isim = isim;
//            Departman = departman;
//            Yas = yas;
//            IzinGunu = izinGunu;
//        }
//    }

//    class Stajyer : Personel
//    {
//        public int StajSuresi { get; }

//        public Stajyer(int id, string isim, string departman, int yas, int izinGunu, int stajSuresi)
//            : base(id, isim, departman, yas, izinGunu)
//        {
//            StajSuresi = stajSuresi;
//        }
//    }

//    class Mudur : Personel
//    {
//        public string YetkiSeviyesi { get; }

//        public Mudur(int id, string isim, string departman, int yas, int izinGunu, string yetkiSeviyesi)
//            : base(id, isim, departman, yas, izinGunu)
//        {
//            YetkiSeviyesi = yetkiSeviyesi;
//        }
//    }

//    class Calisan : Personel
//    {
//        public string Unvan { get; }

//        public Calisan(int id, string isim, string departman, int yas, int izinGunu, string unvan)
//            : base(id, isim, departman, yas, izinGunu)
//        {
//            Unvan = unvan;
//        }
//    }
//}
//
//