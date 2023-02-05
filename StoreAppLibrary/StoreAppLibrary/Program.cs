using System;
using System.Globalization;

namespace StoreAppLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            DrinkProduct drinkProduct1 = new DrinkProduct()
            {
                Name = "Coca-Cola",
                Price=3
            };

            DrinkProduct drinkProduct2 = new DrinkProduct()
            {
                Name = "RedBul",
                Price = 5
            };


            DairyProduct dairyProduct1 = new DairyProduct()
            {
                Name = "Milla",
                Price = 6
            };

            DairyProduct dairyProduct2 = new DairyProduct()
            {
                Name = "Azersud",
                Price = 4
            };



            DairyProduct dairyProduct3 = new DairyProduct()
            {
                Name = "Qaymaq",
                Price =5
            };


            Product[] products = { drinkProduct1, drinkProduct2, dairyProduct1, dairyProduct2 };

          

            

        }
    }
}
