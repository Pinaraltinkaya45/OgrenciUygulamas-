using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci(1,"pınar","Altınkaya",50,60,79,"Bandırma Onyedi Eylül Üniversitesi");

            Console.WriteLine("UYGULAMAMIZA HOŞGELDİNİZZZ");

            Console.WriteLine("Yapmak İstediğiniz İşlemi Seciniz");
            islemleriGoster();

            bool kontrol = true;
            while (kontrol) {
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrenciBilgileriGoster();
                        break;

                    case "2":
                        double ogrenciOrtalaması = ogrenci1.ogrenciNotBul();
                        Console.WriteLine("Öğrencinin Ortalaması : " + ogrenciOrtalaması);
                        break;

                    case "3":
                        ogrenci1.okulGetir();
                        break;

                    case "4":
                        kontrol = false;
                        break;
                    default:
                        Console.WriteLine("HATALI GİRİŞ, LÜTFEN GİRDİĞİNİZ KARAKTERE DİKKAT EDİN LÜTFEN");
                        break;
                       
                }
            }
          

        }

        static void islemleriGoster()
        {
            Console.WriteLine("1- Öğrenci Bilgileri Göster");
            Console.WriteLine("2- Öğrencinin Ortalamasını Göster");
            Console.WriteLine("3- Öğrencinin Okulunu Göster");
            Console.WriteLine("4- Çıkış Yap");
        }
    }
}
