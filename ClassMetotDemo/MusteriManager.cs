using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.Ad + " " + musteri.Soyad);

        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri Listelendi.");
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + "\nEmail : " + musteri.Email);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " Adlı Müşteri Silindi");
        }
    }
}
