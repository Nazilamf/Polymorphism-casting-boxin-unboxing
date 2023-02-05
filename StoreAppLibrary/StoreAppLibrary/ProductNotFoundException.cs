using System;
using System.Collections.Generic;
using System.Text;

namespace StoreAppLibrary
{
    internal class ProductNotFoundException : Exception
    {
        public ProductNotFoundException() : base("Mehsul tapilmadi") { }
    }
}
