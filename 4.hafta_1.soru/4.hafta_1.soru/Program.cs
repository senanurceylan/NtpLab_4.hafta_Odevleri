using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.hafta_1.soru
{


    class Program
    {
        static void Main(string[] args)
        {
            // BankaHesabı sınıfından yeni bir hesap nesnesi oluşturuyoruz.
            BankaHesabı hesap = new BankaHesabı("123456789", 5000m);

            try
            {
                // Para yatırma işlemi
                hesap.ParaYatir(1000m);
                Console.WriteLine("Güncel Bakiye: " + hesap.Bakiye);

                // Geçersiz miktar ile para yatırma işlemi
                hesap.ParaYatir(-500m);  // Hata fırlatır
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }

            try
            {
                // Para çekme işlemi
                hesap.ParaCek(2000m);
                Console.WriteLine("Güncel Bakiye: " + hesap.Bakiye);

                // Yetersiz bakiye ile para çekme işlemi
                hesap.ParaCek(10000m);  // Hata fırlatır
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }

            Console.ReadKey();
        }
    }

    class BankaHesabı
    {
        // Hesap numarası sınıf dışında da okunabilir ve değiştirilebilir.
        public string HesapNumarasi { get; set; }

        // Bakiye özelliği sadece sınıf içinde değiştirilebilecek şekilde ayarlandı.
        // Böylece bakiye sadece sınıf içindeki işlemlerle güncellenebilir.
        public decimal Bakiye { get; private set; }

        // Yapıcı metot: Hesap numarasını ve başlangıç bakiyesini ayarlamak için kullanılır.
        public BankaHesabı(string hesapNumarasi, decimal bakiye)
        {
            if (bakiye < 0)
            {
                throw new ArgumentException("Başlangıç bakiyesi negatif olamaz.");
            }

            HesapNumarasi = hesapNumarasi;
            Bakiye = bakiye;
        }

        // Para yatırma metodu: Geçerli bir miktar girildiğinde bakiyeyi artırır.
        public void ParaYatir(decimal miktar)
        {
            if (miktar <= 0)
            {
                throw new ArgumentException("Yatırılacak miktar pozitif olmalıdır.");
            }

            Bakiye += miktar;
            Console.WriteLine(miktar + " TL yatırıldı.");
        }

        // Para çekme metodu: Bakiyeden çekilmek istenen miktar mevcut bakiyeden fazla değilse işlem yapılır.
        public void ParaCek(decimal miktar)
        {
            if (miktar <= 0)
            {
                throw new ArgumentException("Çekilecek miktar pozitif olmalıdır.");
            }
            if (miktar > Bakiye)
            {
                throw new InvalidOperationException("Yetersiz bakiye! Çekmek istediğiniz miktar mevcut bakiyeden fazla.");
            }

            Bakiye -= miktar;
            Console.WriteLine(miktar + " TL çekildi.");
        }
    }
}