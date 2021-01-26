using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Id = 1;
            musteri1.musAdi = "Nevzat";
            musteri1.musSoyadi = "Çevik";
            musteri1.threedsecurity = false;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.musAdi = "Soner";
            musteri2.musSoyadi = "Koç";
            musteri2.threedsecurity = false;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.musAdi = "Meral";
            musteri3.musSoyadi = "Albay";
            musteri3.threedsecurity = true;


            Musteri[] musteriler = { musteri1, musteri2, musteri3 };
            Console.WriteLine("Musteri Listesi: ");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("ID: " + musteri.Id);
                Console.WriteLine("SOYADI: " + musteri.musAdi);
                Console.WriteLine("ADI: " + musteri.musSoyadi);
                if (musteri.threedsecurity)
                {
                    Console.WriteLine("3D Security durumu : ACIK");
                }
                else
                {
                    Console.WriteLine("3D Security durumu : KAPALI");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***");

            Console.WriteLine();
            MusteriManager musman = new MusteriManager();
            musman.musEkle("Ahmet", "Öztürk");
            musman.musSil(2);

        }
    }
}
