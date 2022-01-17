using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Matematik
    {
        public void Basla()
        {
            Console.WriteLine("___Matematik___");
            int[] sayilar = new int[2];
            int toplam = 0;
            int carpim = 0;
            int cikarma = 0;
            
            //Toplama
            sayilar[0] = new Random().Next(1, 10);
            sayilar[1] = new Random().Next(1, 10);
            toplam = sayilar[0] + sayilar[1];
            Console.WriteLine("Soruları cevaplayınız : ");
            Console.Write("{0} + {1} =  ", sayilar[0], sayilar[1]);
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == toplam)
                Console.WriteLine("Cevap doğru");
            else
                Console.WriteLine("Yanlış, cevap = " + toplam);
            
            //Çıkarma
            sayilar[0] = new Random().Next(5, 10);
            sayilar[1] = new Random().Next(1, 4);
            cikarma = sayilar[0] - sayilar[1];
            Console.Write("{0} - {1} =  ", sayilar[0], sayilar[1]);
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == cikarma)
                Console.WriteLine("Cevap doğru");
            else
                Console.WriteLine("Yanlış, cevap : " + cikarma);
            
            //Çarpma
            sayilar[0] = new Random().Next(1, 10);
            sayilar[1] = new Random().Next(1, 10);
            carpim = sayilar[0] * sayilar[1];
            Console.Write("{0} * {1} =  ", sayilar[0], sayilar[1]);
            int b = Convert.ToInt32(Console.ReadLine());
            if (b == carpim)
                Console.WriteLine("Cevap doğru");
            else
                Console.WriteLine("Yanlış, cevap : " + carpim);
        }
    }
}
