using System;
using System.Collections.Generic;
using System.Text;

namespace StoreAppLibrary
{
    public interface IStore
    {
        Product[] Products { get; }

        void DairyPRoductCountLimit(Product Products);
        void AlcoholPercentLimit(Product Products);
        void AddProduct(Product Product);
        bool HasProductByNo(int no);
        Product GetProductByNo(int no);

        DairyProduct[] GetDairyPRoducts(Product[] _products);

        DrinkProduct[] GetDrinkPRoducts(Product[] Products);


        void RemoveProduct(int no);



    }
}
