using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim:"Ayşe");
            SelamVer(isim:"Engin");
            SelamVer();

            int sonuc = Topla(6,58);

            //Diziler / Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";
            //Console.WriteLine(ogrenci1);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";


            for (int i=0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1; //sehirler2 nin referası sehirler1 oluyor .REFERANS TİPTİR.
            //deger ve referas tipleri karıştırma (int,bool, gibi veri tipleri)
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirsName = "Engin";
            person1.LastName = "Demirog";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 1;

            Person person2 = new Person();
            person2.FirsName = "Murat";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            //generic collection
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" }; //list bir sınıftır
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
        static void SelamVer(string isim="isimsiz") //void herhangi bir şey döndürmeyecek sadece işi yapacak
            //default parametre yapıldı
        {
            Console.WriteLine("Merhaba" + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10) //parametre vermeyince verileni kabul eder 5 ve 10 kabul etmesini istedik
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam :" + sonuc);
            return sonuc;
        }
        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 10000; //db den gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long TcNo = 12345678910;

            Console.WriteLine(mesaj);
            Console.WriteLine();
        }
    }

    //pascal casing 
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
