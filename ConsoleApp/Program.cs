using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___Oyunlar___");
            Console.WriteLine("1.Oyun : Sayı Bulma");
            Console.WriteLine("2.Oyun : At Yarışı");
            Console.WriteLine("3.Oyun : Matematik");
            Console.WriteLine("Oynamak istediğiniz oyunun numarasını giriniz : ");

            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    SayiBulma sayiBulma = new SayiBulma();
                    sayiBulma.Basla();
                    break;
                case 2:
                    AtYarisi atYarisi = new AtYarisi();
                    atYarisi.Basla();                    
                    break;
                case 3:
                    Matematik matematik = new Matematik();
                    matematik.Basla();
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
