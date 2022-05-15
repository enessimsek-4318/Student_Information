using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ogrenci_Bilgileri
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci1 = new Ogrenci(1605061164, "Enes Muhammed", "Şimşek", 50, 65, 84, "Yıldırım Beyazıt Üniversitesi");
            while (kontrol)
            {
                Console.WriteLine("Enes Şimşek OBS sistemine Hoşgeldiniz:");
                Console.WriteLine("Öğrenci Bilgileri  :1\nÖğrenci Ortalaması :2\nÖğrencinin Okulu   :3\nÇıkış              :4\nSeçiminizi Yapınız");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    ogrenci1.ogrenciBilgileriGoster();
                }
                else if (secim == 2)
                {
                    double ort =ogrenci1.ortalamabul();
                    Console.WriteLine("Ortalamanız: " + ort);
                    if (ort<50)
                    {
                        Console.WriteLine("Dersten Kaldınız");
                    }
                    else
                    {
                        Console.WriteLine("Dersten Geçtiniz");
                    }
                }
                else if (secim == 3)
                {
                    ogrenci1.okulGetir();
                }
                else if (secim == 4)
                {
                    kontrol = false;
                }
                else
                {
                    Console.WriteLine("Hatalı Tuşlama Yaptınız");
                }
                Console.ReadLine();
            }
        }
    }
}
