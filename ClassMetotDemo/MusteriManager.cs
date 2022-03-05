using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " sisteme eklendi!");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " sistemden silindi!");
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteriListe in musteriler)
            {
                Console.WriteLine(musteriListe.Ad + " " + musteriListe.Soyad);
            }
        }
        

    }
}
