using System;

namespace ornekSepeteEkle
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.urunAdi = "Hp NoteBook";
            urun1.Fiyati = 2500;

            Product urun2 = new Product();
            urun2.urunAdi = "Casper NoteBook";
            urun2.Fiyati = 4700;

            Product urun3 = new Product();
            urun3.urunAdi = "Macbook";
            urun3.Fiyati=10000;

            Product urun4 = new Product();
            urun4.urunAdi = "Monster Gaming Pc";
            urun4.Fiyati = 7600;

            Product[] urunler = new Product[] { urun1, urun2, urun3, urun4 };
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.urunAdi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("---------AYRIM-----------");

            SepeteEkle sepeteEkle = new SepeteEkle(); 
            {
                sepeteEkle.Ekle(urun1);
                sepeteEkle.Ekle(urun2);
                sepeteEkle.Ekle(urun3);
                sepeteEkle.Ekle(urun4);
            };

        }
    }
}
