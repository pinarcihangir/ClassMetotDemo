using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(12345, "Pınar Cihangir", "Kadın", 22);
            musteriManager.Ekle(12346, "Ali Bakır", "Erkek", 18);
            musteriManager.Ekle(12347, "Cengiz Talan", "Erkek", 54);
            musteriManager.Ekle(12348, "Yaren Kurtulan", "Kadın", 36);
            musteriManager.Ekle(12349, "Tülin Özer", "Kadın", 42);

            //musteriManager.Listele();
            // Tümeklemeler yapıldıktan sonra yorum satırı kaldırılırsa görülecektir ki metot doğru çalışmaktadır.
            musteriManager.Sil(12349);
            musteriManager.Listele();
            //Sil metodu da doğru çalışmaktadır.
        }
    }
}
