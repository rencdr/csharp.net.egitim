//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace csharpcrashcourse
//{
//    internal class NotDefteriUygulama
//    {
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                List<string> Notlar = new List<string>();
//                bool devam = true;
//                while (devam)
//                {
//                    Console.WriteLine("Seçiminizi yapınız:");
//                    Console.WriteLine("1.Notlara Bak");
//                    Console.WriteLine("2.Not Ekle");
//                    Console.WriteLine("3.Çıkış Yap");
//                    int secim = int.Parse(Console.ReadLine());

//                    switch (secim)
//                    {
//                        case 1:
//                            NotlaraBak(Notlar);
//                            break;
//                        case 2:
//                            NotEkle(Notlar);
//                            break;
//                        case 3:
//                            CikisYap(ref devam);
//                            break;
//                        default:
//                            Console.WriteLine("Geçersiz bir seçim yaptınız.");
//                            break;
//                    }
//                }
//            }

//            static void NotlaraBak(List<string> notlar)
//            {
//                Console.WriteLine("Notlar:");
//                foreach (string not in notlar)
//                {
//                    Console.WriteLine(not);
//                }
//            }

//            static void NotEkle(List<string> notlar)
//            {
//                Console.Write("Notu girin: ");
//                string not = Console.ReadLine();
//                notlar.Add(not);
//            }

//            static void CikisYap(ref bool devam)
//            {
//                devam = false;
//            }
//        }






//    }

//}

