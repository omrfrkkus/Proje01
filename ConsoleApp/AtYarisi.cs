using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class AtYarisi
    {
        private int birinciat;
        enum AtIsimleri
        {
            Gece,
            Karadut,
            Gül,
            Kartopu
        }

        public void BirinciAtıBelirleme()
        {
            birinciat = new Random().Next(1, 4);
        }

        public void Basla()
        {
            Console.WriteLine("___At Yarışı___");
            for (int i = 0; i < 4; i++)
            {
                AtIsimleri atisimleri;
                atisimleri = (AtIsimleri)i; Console.WriteLine((i + 1) + ".atın Adı : " + atisimleri);
            }
            BirinciAtıBelirleme();
            Console.WriteLine("Birinci olacağını düşündüğünüz atın sıralamasını giriniz : ");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n != birinciat)
            {
                Console.WriteLine("Tekrar deneyiniz...");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == birinciat)
                {
                    Console.WriteLine("Tebrikler doğru bildiniz...");
                    break;
                }
            }
        }
    }
}
