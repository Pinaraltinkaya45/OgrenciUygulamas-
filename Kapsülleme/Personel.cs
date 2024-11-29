using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
    public  class Personel
    {
        private string tckimlikno;

        public string TCKIMLIKNO
        {
            get
            {
                return tckimlikno.Substring(0, 4) + "******";
            }
            set
            {
                bool kontrol = false;
                if(value.Length == 11)
                {
                    for(int i=0; i<value.Length;i++)
                    {
                        bool sayiMi = char.IsNumber(value[i]);
                        if(sayiMi)
                        {
                            // yapmam gereken bir şey yok
                        }
                        else
                        {
                            kontrol = true;
                            break; // döngüyü kırdım
                        }
                    }

                    if (kontrol)
                    {
                        Console.WriteLine("TC KİMLİK NO içinde geçersiz karakter bulundu.");
                    }
                    else
                    {
                        tckimlikno = value;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Girdiğiniz TC KİMLİK NO 11 karakter değildir..");
                }
            }
        }
    }
}
