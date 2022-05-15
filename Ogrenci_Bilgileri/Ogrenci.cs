using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Bilgileri
{
    class Ogrenci
    {
        private int ogrenciNo;
        private string ogrenciIsmi;
        private string ogrenciSoyismi;
        private double vize1;
        private double vize2;
        private double final;
        private string okulIsmi;


        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("Ogrenci No: " + ogrenciNo);
            Console.WriteLine("Ogrenci Adı: " + ogrenciIsmi);
            Console.WriteLine("Ogrenci Soyadı: " + ogrenciSoyismi);
            Console.WriteLine("Ogrenci Vize-1 Notu: " + vize1);
            Console.WriteLine("Ogrenci Vize-2 Notu: " + vize2);
            Console.WriteLine("Ogrenci Final Notu: " + final);
            Console.WriteLine("Okul Adı: " + okulIsmi);
        }
        public Ogrenci(int No, string ad, string soyad, double v1, double v2, double fin, string okulad) // Yapıcı Metod Olarak Geçmektedir. Kısa Yolu ctor yazıp 2 kere tab 
        {
            ogrenciNo = No;
            ogrenciIsmi = ad;
            ogrenciSoyismi = soyad;
            vize1 = v1;
            vize2 = v2;
            final = fin;
            okulIsmi = okulad;
        }
        public double ortalamabul()
        {
            double ortalama = (vize1 * 0.2) + (vize2 * 0.2) + (final * 0.6);
            return ortalama;
        }

        public void okulGetir()
        {
            Console.WriteLine("Okul Adı: " + okulIsmi);
        }

    }
}
