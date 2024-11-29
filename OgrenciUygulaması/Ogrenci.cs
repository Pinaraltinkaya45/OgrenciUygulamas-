using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulaması
{
    public  class Ogrenci
    {
        private int ogrno;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;

        private string okulIsmi;

        public Ogrenci(int ogrno, string isim, string soyisim, int vize1, int vize2, int final, string okulIsmi)
        {
            this.ogrno = ogrno;
            this.isim = isim;
            this.soyisim = soyisim;
            this.vize1 = vize1;
            this.vize2 = vize2;
            this.final = final;
            this.okulIsmi = okulIsmi;
        }

        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("Öğrenci numarası : " + ogrno);
            Console.WriteLine("Ogrenci ismi: " + isim);
            Console.WriteLine("Öğrenci soyad: " + soyisim);
            Console.WriteLine("Öğrenci vize1 notu : " + vize1);
            Console.WriteLine("Öğrenci vize2 notu : " + vize2);
            Console.WriteLine("Öğrenci final notu : " + final);
            Console.WriteLine("Öğrenci okul ismi : " + okulIsmi);
        }

        public double ogrenciNotBul()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ortalama;
        }

        public void okulGetir()
        {
            Console.WriteLine("Öğrencinin Okul İsimi : " + okulIsmi);
        }
    }
}
