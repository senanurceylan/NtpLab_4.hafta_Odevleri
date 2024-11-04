using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.hafta_4.Soru_AdresSinifi
{
    class Program
    {
        static void Main(string[] args)
        {
            AdresDefteriSinifi nesne = new AdresDefteriSinifi("sena", "ceylan", "05447717808");
            Console.WriteLine(nesne.KisiBilgisi());

            Console.ReadKey();
        }
    }


    class AdresDefteriSinifi
    {
        public String Ad { get; set; }
        public String Soyad { get; set; }
        public String telefon { get; set; }



        public AdresDefteriSinifi(String Ad,String Soyad,String  telefon)
        {
            // parametre ile özellik isimleri aynı oyzdn this kullancaz
           this.Ad = Ad;
            this.Soyad = Soyad;
            this.telefon = telefon;
        }

        public String KisiBilgisi()
        {
           return $":Ad soyad {Ad} {Soyad}   telefon:  {telefon}";
        }

    }
}
