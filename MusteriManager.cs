using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteriEkle) 
        {
            Console.WriteLine(musteriEkle.Id +" Tc No'lu "+ musteriEkle.Ad+ musteriEkle.SoyAd + "sisteme eklendi");
        }
        public void Sil(Musteri musteriSil) 
        {
            Console.WriteLine(musteriSil.Id + "adlı müşteri silindi.");
        }

        public void Listele(Musteri musteriListele) 
        {
            Console.WriteLine(musteriListele.Ad + musteriListele.SoyAd + "müşteriler listelendi.");
        }
    }
}
