using System;
using System.Collections.Generic;
using System.Text;

namespace StoreAppLibrary
{
    internal class AlcoholPercentLimitException:Exception
    {
        public AlcoholPercentLimitException() : base("Alkoqol limitindan asagidir") { }
    }
}
