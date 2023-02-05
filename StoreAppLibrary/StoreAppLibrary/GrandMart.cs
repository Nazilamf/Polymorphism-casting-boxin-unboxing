using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq.Expressions;
using System.Text;

namespace StoreAppLibrary
{
     public class GrandMart :IStore

    {
        private  Product[] _products = new Product[0];
        public Product[] Products { get => _products; }

        

        private int AlcoholPerrcentLimit = 50;
       

       public void AddProduct(Product product)
        {
            Array.Resize(ref _products, _products.Length+1);
            _products[_products.Length-1] = product;
        }

        public void AlcoholPercentLimit(Product Products)
        {
            int count = 0;
            Product maxProduct;
            foreach (var item in _products)
            {

                if (item is DrinkProduct)
                {
                    DrinkProduct dp = item as DrinkProduct;
                    count++;

                    if (dp.AlcoholPercent > AlcoholPerrcentLimit)
                    {
                        maxProduct= dp;
                    }

                    
                }
            }

            throw new AlcoholPercentLimitException();
        }

       
        public void DairyPRoductCountLimit(Product Products)

        {
            int count = 0;
            foreach (var item in _products)
            {
                if (item is DairyProduct)
                {
                    DairyProduct dp1 = item as DairyProduct;
                    count++;
                }

            }
            throw new NotFoundDairyProductException();
        }

       public DairyProduct[] GetDairyPRoducts(Product[] _products)
        {
            DairyProduct[] dairyProducts = new DairyProduct[0];
            
            foreach (var item in _products)
            {
                if (item is DairyProduct)
                {
                    DairyProduct dp1 = item as DairyProduct;
                    Array.Resize(ref dairyProducts, dairyProducts.Length+1);
                    dairyProducts[dairyProducts.Length-1] = dp1;
                }
                return dairyProducts;

            }

            throw new NotFoundDairyProductException();
            
        }

      public DrinkProduct[] GetDrinkPRoducts(Product[] Products)
        {
            DrinkProduct[] drinkProducts = new DrinkProduct[0];

            foreach (var item in Products)
            {
                if (item is DrinkProduct)
                {
                    DrinkProduct dp = item as DrinkProduct;
                    Array.Resize(ref drinkProducts, drinkProducts.Length+1);
                    drinkProducts[drinkProducts.Length-1] = dp;
                }
                return drinkProducts;
            }
            

            throw new NotFountDrinkProductException();
        }

        public Product GetProductByNo(int no)
        {
            foreach (var item in _products)
            {
                if (item.No == no)
                    return item;
            }

            throw new ProductNotFoundException();
        }

        public bool HasProductByNo(int no)
        {
            foreach (var item in _products)
            {
                if (item.No == no)
                    return true;
            }
            return false;
        }

        public void RemoveProduct(int no)
        {
            Product[] products = new Product[_products.Length-1];
            foreach (var item in _products)
            {
                if (item.No == no)

                    RemoveProduct(item.No);
                     
                Array.Resize(ref _products, _products.Length-1);
            }
        }




        
       
    }
}


