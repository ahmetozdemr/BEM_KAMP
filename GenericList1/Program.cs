using System;
using System.Collections.Generic;

namespace GenericList1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kisiler = new List<Kisi>() 
            {
                new Kisi(){Ad="İbrahim",Soyad="İnan",TelefonNo=543829852},
                new Kisi(){Ad="İsmail",Soyad="Seven",TelefonNo=657869852},
                new Kisi(){Ad="Fatih",Soyad="Hüdaverdi",TelefonNo=548276852},
                new Kisi(){Ad="Ramazan",Soyad="Seven",TelefonNo=973829852},
                new Kisi(){Ad="Yasin",Soyad="Geven",TelefonNo=673829852}
            };
            foreach (var item in kisiler)
            {
                Console.ForegroundColor = ConsoleColor.Green;   
                Console.WriteLine("Ad : "+item.Ad);
                Console.WriteLine("Soayad : " + item.Soyad);
                Console.WriteLine("Telefon No : " + item.TelefonNo);
                Console.ResetColor();
                Console.WriteLine("*****************");
            }
           
            Console.ReadLine(); 
        }
    }
    class Kisi
    {
        public string Ad { get; set;}
        public string Soyad { get; set;}    
        public int TelefonNo { get; set; }  
    }
}
