using System;
using System.Collections.Generic;
using System.Text;

namespace StoreAppLibrary
{
    internal class NotFountDrinkProductException:Exception
    {
        public NotFountDrinkProductException() : base("Drink mehsul yoxdur") { }
    }
}
