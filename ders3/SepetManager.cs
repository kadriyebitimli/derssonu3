using System;
using System.Collections.Generic;
using System.Text;

namespace ders3
{
    class SepetManager
    {
        public void Ekle(Urun urun)//ne ekleyecegimizi belirtiriz.
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi :"+ urun.Adi);

        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi :" + urunAdi);
        }
    }
}
