using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri customer1 = new Musteri();
            customer1.Id = 1001;
            customer1.Name = "Çağdaş";
            customer1.Surname = "Özer";
            customer1.Age = 25;
            customer1.Phone = +90123;

            Musteri customer2 = new Musteri();
            customer2.Id = 1002;
            customer2.Name = "Ulaş";
            customer2.Surname = "Özer";
            customer2.Age = 20;
            customer2.Phone = +90125;

            Musteri customer3 = new Musteri();
            customer3.Id = 1003;
            customer3.Name = "Mihriban";
            customer3.Surname = "Özer";
            customer3.Age = 26;
            customer3.Phone = +90124;


            //Musteri[] customers = new Musteri[] { customer1, customer2, customer3 };

            //foreach (Musteri customer in customers)
            //{
            //    Console.WriteLine("Müşteri'nin Id Numarası : " + customer.Id);
            //    Console.WriteLine("Müşteri'nin Adı Soyadı : " + customer.Name + " " + customer.Surname);
            //    Console.WriteLine("Müşteri'nin Yaşı : " + customer.Age);
            //    Console.WriteLine("Müşteri'nin Telefon Numarası : " + customer.Phone);
            //    Console.WriteLine("");
            //    Console.WriteLine("--------------");
            //    Console.WriteLine("");
            //}

            ////////////////////////////////METOTLA YAPIMI///////////////////////////////

            Console.WriteLine("");
            Console.WriteLine("----------Metotla---------");
            Console.WriteLine("");

            Musteri[] customers = new Musteri[] { customer1, customer2, customer3 };

            foreach (Musteri customer in customers)
            {
                MusteriManager musteriManager = new MusteriManager();
                musteriManager.MusteriEkle(customer);
                Console.WriteLine("");
            }
            Console.WriteLine("$$$$$$$$$$$$$");
            Console.WriteLine("");

            foreach (Musteri customer in customers)
            {
                MusteriManager musteriManager = new MusteriManager();
                musteriManager.MusteriSil(customer);
                Console.WriteLine("");
            }
            Console.WriteLine("$$$$$$$$$$$$$");
            Console.WriteLine("");
            Console.WriteLine("Müşteri Listesi : ");
            foreach (Musteri customer in customers)
            {
                MusteriManager musteriManager = new MusteriManager();
                musteriManager.MusteriListele(customer);
            }
        }
    }
}
