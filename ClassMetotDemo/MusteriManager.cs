using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void musEkle(string Isim, string Soyisim)
        {
            Console.WriteLine(Isim + " " + Soyisim + " adli kullanici sisteme eklenmistir.");
        }
        public void musSil(int Id)
        {
            Console.WriteLine(Id + " numarali kullanici silindi.");
        }
    }
}
