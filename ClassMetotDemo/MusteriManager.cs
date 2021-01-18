using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> liste = new List<Musteri>();
        public void Listele()
        {
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine((i + 1) + ". Müşterinin adı soyadı: " + liste[i].AdSoyad);
                Console.WriteLine("Id: " + liste[i].Id);
                Console.WriteLine("Yaş: " + liste[i].Yas);
                Console.WriteLine("Cinsiyet: " + liste[i].Cinsiyet);
            }
        }

        public void Ekle(int id, string isim, string cinsiyet, int yas)
        {
            Musteri yeniMusteri = new Musteri();
            yeniMusteri.Id = id;
            yeniMusteri.AdSoyad = isim;
            yeniMusteri.Cinsiyet = cinsiyet;
            yeniMusteri.Yas = yas;

            liste.Add(yeniMusteri);

        }

        public void Sil(int id)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].Id == id)
                {
                    liste.Remove(liste[i]);
                }
            }

        }
    }
}
