using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Personel();

            p1.TCKIMLIKNO = "12345678956";

            Console.WriteLine("TC kimlik numaranız: " + p1.TCKIMLIKNO);

            Console.ReadLine();
        }
    }
}
