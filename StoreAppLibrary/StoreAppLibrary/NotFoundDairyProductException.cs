using System;
using System.Collections.Generic;
using System.Text;

namespace StoreAppLibrary
{
    internal class NotFoundDairyProductException:Exception
    {
        public NotFoundDairyProductException() : base("Dairy mehsul yoxdur") { }
    }
}
