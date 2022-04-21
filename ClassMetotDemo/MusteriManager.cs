using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri customer)
        {
            Console.WriteLine("Müşteri Eklendi.");
            Console.WriteLine("Hoşgeldiniz : " + customer.Name + " " + customer.Surname);
            Console.WriteLine("Id Numaranız : " + customer.Id);
            Console.WriteLine("Yaşınız ve Telefon Numaranız : " + customer.Age + " & " + customer.Phone);
        }

        public void MusteriSil(Musteri customer)
        {
            Console.WriteLine("Müşteri Silindi.");
            Console.WriteLine("Silindi-->" + customer.Name + " " + customer.Surname);
            Console.WriteLine("Silinen Müşterinin Id Numarası : " + customer.Id);
            Console.WriteLine("Silinen Müşterinin Yaşı ve Telefon Numarası : " + customer.Age + " & " + customer.Phone);
        }

        public void MusteriListele(Musteri customer)
        {

            Console.WriteLine("Müşteri'nin Adı Soyadı : " + customer.Name + " " + customer.Surname);
        }
    }
}
