using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Kadriye";
            musteri1.Soyadi = "Bitimli";
            musteri1.TcNo = "12345678910";


            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri1.MusteriNo = "54321";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "12345698789";


            //gercek müsteri-tüzel müsteri ----birbirinin yerine asla kullanılamazlar, farklı seylerdir. 
            //SOLİD

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);



        }
    }
}
