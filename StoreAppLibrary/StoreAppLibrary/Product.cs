using System;
using System.Collections.Generic;
using System.Text;

namespace StoreAppLibrary
{
    public class Product
    {

        static int _totalcount;
        public Product()
        {
            _totalcount++;
            No =_totalcount;

        }


        public int No;
        public string Name;
        public double Price;



        public void ShowInfo()
        {
            Console.WriteLine($"No:{No} - Name: {Name} -  Price: {Price}");
        }
    }
}
