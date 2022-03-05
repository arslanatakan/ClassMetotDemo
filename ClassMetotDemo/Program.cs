using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Atakan";
            musteri1.Soyad = "Arslan";
            musteri1.HesapNo = 1300;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Hasan";
            musteri2.Soyad = "Rezai";
            musteri2.HesapNo = 1400;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Çağatay";
            musteri3.Soyad = "Cingiz";
            musteri3.HesapNo = 1500;

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            
            musteriManager.Ekle(musteri1);
            Console.WriteLine("Aktif müşteri listesi:");
            musteriManager.Listele(musteriler);
            Console.WriteLine("---------");
            musteriManager.Sil(musteri2);
            
            
        }
    }
}
