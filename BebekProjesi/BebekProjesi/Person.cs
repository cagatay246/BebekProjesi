using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebekProjesi
{
    class Person
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        public Person()
        {
            Console.WriteLine("Ingaaaaaa");
            DogumTarihi = DateTime.Now;
        }

        public Person (string ad,string soyad): this()
        {
            Ad = ad;
            Soyad = soyad;
        }
            
        public void BilgileriYazdir()
        {
            Console.WriteLine($"AD: {Ad} , Soyad: {Soyad}, DOĞUM TARİHİ: {DogumTarihi.ToShortDateString()}");
        }

    }

  



   
}
