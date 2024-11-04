using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.hafta_3.Soru_AracSinifi
{
    class Program
    {
        static void Main(string[] args)
        {

            AracSinifi arac = new AracSinifi("51BJK123",100);
            arac.AraciKirala();   
            arac.AraciKirala();   
            arac.AraciTeslimEt(); 
            arac.AraciTeslimEt(); 
            Console.ReadLine();
        }
    }


    class AracSinifi
    {
        public String Plaka { get; set; }
        public Decimal GunlukUcret { get; set; }
        public Boolean MusaitMi { get;private set; }

        public AracSinifi (String Plaka , Decimal GunlukUcret)
        {
            Plaka = Plaka;
            GunlukUcret = GunlukUcret;
            MusaitMi = true;

        }
         public void AraciKirala()
        {
            if (MusaitMi)
            {
                MusaitMi = false;
                Console.WriteLine($"{Plaka} plakalı araç kiralandi");
            }
            else
            {
                Console.WriteLine($"{Plaka} plakali arac zaten kiralanmistir");
            }
        }

        public void AraciTeslimEt()
        {
            if (!MusaitMi)
            {
                MusaitMi = true;// araç teslim edildi
                Console.WriteLine($"{Plaka}plakali arac teslim edildi");
            }
            else
            {
                Console.WriteLine($"{Plaka}plakali arac zaten bosta");
            }

        }


    }
}
