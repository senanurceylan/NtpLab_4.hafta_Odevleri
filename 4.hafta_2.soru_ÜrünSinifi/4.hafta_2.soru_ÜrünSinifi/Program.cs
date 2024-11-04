using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.hafta_2.soru_ÜrünSinifi
{
    class Program
    {
        static void Main(string[] args)
        {
            ÜrünSinifi nesne = new ÜrünSinifi("saat", 1000);
            nesne.İndirim = 20;// %20 indirim uyguladım
            Console.WriteLine($"adı: {nesne.Ad} indirimli fiyati: {nesne.İndirimliFiyat()}");
            Console.ReadKey();
        }
    }
    class ÜrünSinifi
    {
        public String Ad { get; set; }
        public Decimal Fiyat { get; set; }
        private decimal indirim; // İndirim değerini saklamak için özel bir alan

        public decimal İndirim
        {
            get { return indirim; }
            set
            {
                // İndirim değeri 0 ile 50 arasında mı kontrol ediyoruz
                if (value >= 0 && value <= 50)
                {
                    indirim = value; // Geçerli aralıktaysa değeri ayarlıyoruz
                }
                else
                {
                    throw new ArgumentException("İndirim 0-50 arası olmalıdır"); // Geçersiz aralıkta hata fırlatıyoruz
                }
            }
        }


        public ÜrünSinifi (String Ad , decimal Fiyat)
        {
           this.Ad = Ad;
            this.Fiyat = Fiyat;
        }


        public decimal İndirimliFiyat()
        {
            return Fiyat * (1- indirim / 100);
        }

    }
}
