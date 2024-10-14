using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1bb
{
    class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public string Index
        {
            get { return index; }
            set { index = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string House
        {
            get { return house; }
            set { house = value; }
        }

        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Address myAddress = new Address();
            myAddress.Index = "01001";
            myAddress.Country = "Україна";
            myAddress.City = "Київ";
            myAddress.Street = "Левка Лук'яненка";
            myAddress.House = "11-В";
            myAddress.Apartment = "103";

            Console.WriteLine("Поштова адреса:");
            Console.WriteLine($"Індекс: {myAddress.Index}");
            Console.WriteLine($"Країна: {myAddress.Country}");
            Console.WriteLine($"Місто: {myAddress.City}");
            Console.WriteLine($"Вулиця: {myAddress.Street}");
            Console.WriteLine($"Будинок: {myAddress.House}");
            Console.WriteLine($"Квартира: {myAddress.Apartment}");
        }
    }
}
