using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Engin";
            musteri1.Soyad = "Demiroğ";
            musteri1.Email = "engin@gmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Oğuz";
            musteri2.Soyad = "Yılmaz";
            musteri2.Email = "oguz@gmail.com";

            Musteri[] musteriler = new Musteri[] {
            musteri1,musteri2

            };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri1.Ad);
                Console.WriteLine(musteri1.Soyad);
                Console.WriteLine(musteri1.Email);
                Console.WriteLine("---------------");

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Listele(musteri1);
            musteriManager.Sil(musteri2);

        }
        
    }
}
