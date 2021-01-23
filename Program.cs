using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ahmet";
            musteri1.SoyAd = "Rastgele";
            musteri1.TelNo = 05385288737 ;
            musteri1.eMail = "rastgele@hotmail.com";
            musteri1.Id = 44467675500;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Mehmet";
            musteri2.SoyAd = "Taştoplayan";
            musteri2.TelNo = 05385288700;
            musteri2.eMail = "rastgele2@hotmail.com";
            musteri2.Id = 44877689500;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Mehmet";
            musteri3.SoyAd = "Taştoplayan";
            musteri3.TelNo = 05356288700;
            musteri3.eMail = "rastgele2@hotmail.com";
            musteri3.Id = 45787689860;


            Console.WriteLine("Müşteriler:");
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var Musteri in musteriler)
            {
                Console.WriteLine( Musteri.Id+ "  Tc No'lu  "+Musteri.Ad+ Musteri.SoyAd +"  Ad Soyadlı müşteri" );

            }

            Console.WriteLine("eklenmek isteyen müsteriler ");

            MusteriManager musteriEkle = new MusteriManager();
            musteriEkle.Ekle(musteri1);
            musteriEkle.Ekle(musteri2);
            musteriEkle.Ekle(musteri3);


            Console.WriteLine("silinen müşteriler");

            MusteriManager musteriListele = new MusteriManager();

            musteriListele.Listele(musteri1); 








        }
    }
}
