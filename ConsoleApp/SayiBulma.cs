using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SayiBulma
    {
        private int hedefSayi;
        private int denemeSayisi;
        private int min;
        private int max;
        private bool tamamlandi;
        private int denemeHakki;


        public void DegerAtama(int min, int max)
        {
            this.min = min;
            this.max = max;
            hedefSayi = new Random().Next(min, max);
        }

        public void Basla()
        {
            Console.WriteLine("___Sayı Bulma___");
            Console.WriteLine("Lütfen en küçük sayıyı giriniz");
            int enKucuk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen en büyük sayıyı giriniz");
            int enBuyuk = Convert.ToInt32(Console.ReadLine());

            if (enKucuk >= enBuyuk)
            {
                Console.WriteLine("Hatalı sayı girdiniz... Oyun kapanıyor...");
                System.Threading.Thread.Sleep(2000);
                Environment.Exit(0);
            }

            this.DegerAtama(enKucuk, enBuyuk);

            denemeHakki = ((enBuyuk - enKucuk) / 4);

            for (int i = 0; i < denemeHakki; i++)
            {
                this.denemeSayisi++;
                tamamlandi = this.TahminAl();
                if (tamamlandi)
                {
                    break;
                }
            }

            if (tamamlandi)
            {
                Console.WriteLine("***TEBRİKLER***");
                Console.WriteLine("{0} deneme ile sayıyı buldunuz...", denemeSayisi);
            }
            else
            {
                Console.WriteLine("Deneme hakkınız kalmadı. :( :( :(");
            }

            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }

        public bool TahminAl()
        {
            Console.WriteLine("Lütfen tahmininizi giriniz... Kalan deneme hakkınız : {0}", denemeHakki - denemeSayisi);
            int girilenTahmin = Convert.ToInt32(Console.ReadLine());

            return this.TahminKontrol(girilenTahmin);
        }

        public bool TahminKontrol(int tahmin)
        {
            if (tahmin > max || tahmin < min)
            {
                Console.WriteLine("Hatalı sayı girdiniz. Lütfen {0} ile {1} arası sayı giriniz...", min, max);
                return false;
            }
            if (tahmin > hedefSayi)
            {
                Console.WriteLine("Daha küçük bir sayı giriniz...");
                return false;
            }
            if (tahmin < hedefSayi)
            {
                Console.WriteLine("Daha büyük bir sayı giriniz...");
                return false;
            }
            else if (tahmin == hedefSayi)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Geçersiz sayı girdiniz...");
                return false;
            }
        }
    }
}
