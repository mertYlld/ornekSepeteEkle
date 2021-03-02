using System;
using System.Collections.Generic;
using System.Text;

namespace ornekSepeteEkle
{
    class SepeteEkle
    {

        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete Eklendi: " + urun.urunAdi, urun.Fiyati);
        }
    }
}

