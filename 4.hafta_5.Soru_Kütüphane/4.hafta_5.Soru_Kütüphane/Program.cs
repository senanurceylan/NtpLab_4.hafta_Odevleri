using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.hafta_5.Soru_Kütüphane
{
    class Program
    {
        static void Main(string[] args)
        {
            KütüphaneSinifi nesne = new KütüphaneSinifi();

            // Kullanıcıdan kitap bilgisi alarak ekleme
            Console.WriteLine("Lütfen eklemek istediğiniz kitabın adını girin:");
            string kitapAdi = Console.ReadLine();

            Console.WriteLine("Lütfen eklemek istediğiniz kitabın yazarını girin:");
            string kitapYazari = Console.ReadLine();

            kitap yeniKitap = new kitap(kitapAdi, kitapYazari);
            nesne.KitapEkle(yeniKitap);

            nesne.KitaplariListele();

            Console.WriteLine("\nProgramı kapatmak için  herhangi bir tuşa basabilirsin ödevime baktığın için teşekkür ederim:)");
            Console.ReadKey();
        }
    }

    class kitap
    {
        public string KitapAdi { get; set; }
        public string KitapYazari { get; set; }

        public kitap(string kitapAdi, string kitapYazari)
        {
            this.KitapAdi = kitapAdi;
            this.KitapYazari = kitapYazari;
        }
    }

    class KütüphaneSinifi
    {
        public List<kitap> Kitaplar { get; private set; }

        public KütüphaneSinifi()
        {
            Kitaplar = new List<kitap>();
        }

        public void KitapEkle(kitap yeniKitap)
        {
            this.Kitaplar.Add(yeniKitap);
            Console.WriteLine($"{yeniKitap.KitapAdi} eklenmiştir.");
        }

        public void KitaplariListele()
        {
            Console.WriteLine("\nKütüphanemdeki kitaplar:");
            foreach (var kitap in Kitaplar)
            {
                Console.WriteLine($"Ad: {kitap.KitapAdi}, Yazar: {kitap.KitapYazari}");
            }
        }
    }
}
