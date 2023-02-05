using System;
using StoreAppLibrary;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            GrandMart market1 = new GrandMart();


            string option;

            do
            {
                Console.WriteLine("1.Drink product əlavə et");

                Console.WriteLine("2.Dairy product əlavə et");

                Console.WriteLine("3.Butun productlara bax");

                Console.WriteLine("4.Verilmis nomreli producta bax");

                Console.WriteLine("5.Drink productlara bax");

                Console.WriteLine("6.Dairy productlara bax");

                Console.WriteLine("7.Ada görə axtarış et");

                Console.WriteLine("8 Qiymət aralığına görə axtarış et ");

                Console.WriteLine("9.Siyahıdan məhsul sil");

                Console.WriteLine("0.Menudan cix");

                Console.WriteLine("Secim edin:");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1":

                        var pr = CreateDrinkProduct();
                        market1.AddProduct(pr);
                        break;
                    case "2":
                        var pr2 = CreateDairyProduct();
                        market1.AddProduct(pr2);
                        break;
                    case "3":
                        foreach (Product item in market1.Products)
                        {
                            item.ShowInfo();
                        }
                        break;
                    case "4":
                        Console.WriteLine("No: ");
                        string noStr = Console.ReadLine();
                        int no = Convert.ToInt32(noStr);

                        try
                        {
                            var wantedProduct = market1.GetProductByNo(no);
                            wantedProduct.ShowInfo();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"{no} nomreli mehsul yoxdur!");
                        }

                        break;
                    case "5":

                        DrinkProduct[] drinkProducts = market1.GetDrinkPRoducts();
                        foreach (var item in drinkProducts)
                        {
                            item.ShowInfo();
                        }

                        break;

                    case "6":

                        DairyProduct[] dairyProducts = market1.GetDairyPRoducts();
                        foreach (var item in dairyProducts)
                        {
                            item.ShowInfo();     
                        }
                        break;
                    case "7":

                        Console.WriteLine("Ad daxil edin:");
                        string name = Console.ReadLine();   

                        foreach (var item in market1.Products)
                        {
                            if (item.Name.Contains(name))
                              
                            {
                                item.ShowInfo();    
                            }
                        }
                        break;
                    case "8":
                       
                        string minpriceStr;
                        double minprice;
                        do
                        {
                            Console.Write("Price: ");
                            minpriceStr = Console.ReadLine();
                        } while (!double.TryParse(minpriceStr, out minprice));


                        string maxpriceStr;
                        double maxprice;
                        do
                        {
                            Console.Write("Price: ");
                            maxpriceStr = Console.ReadLine();
                        } while (!double.TryParse(maxpriceStr, out maxprice));


                        foreach (var item in market1.Products)
                        {
                            if (item.Price>minprice ||item.Price<maxprice)
                            {
                                item.ShowInfo();    
                            }
                              
                        }

                        break;
                    case "9":

                        Console.WriteLine("No daxil edin:");
                        string Nostr = Console.ReadLine();  
                        int No = Convert.ToInt32(Nostr);

                        foreach (var item in market1.Products)
                        {
                            if(item.No == No)
                            {
                                item.RemoveProduct();
                            }
                        }

                        break;
                    case "0":
                        Console.WriteLine("Menudan cixdiz!");
                        break;
                    default:
                        Console.WriteLine("Yanlis secim, yeniden cehd edin!");
                        break;

                }


            } while (option != "0");








            static DairyProduct CreateDairyProduct()
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();


                string priceStr;
                double price;
                do
                {
                    Console.Write("Price: ");
                    priceStr = Console.ReadLine();
                } while (!double.TryParse(priceStr, out price));

                string fatpercentstr;
                double fatpercent;

                do
                {
                    Console.Write("FatPercent: ");
                    string fatpercentstr = Console.ReadLine();
                } while (!double.TryParse(fatpercentstr, out fatpercent));


                DairyProduct dairyproduct = new DairyProduct
                {
                    Name = name,
                    Price = price,
                    FatPercent= fatpercent,

                };

                return dairyproduct;




                static DrinkProduct CreateDrinkProduct()
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();


                    string priceStr;
                    double price;
                    do
                    {
                        Console.Write("Price: ");
                        priceStr = Console.ReadLine();
                    } while (!double.TryParse(priceStr, out price));

                    string alcoholpercentstr;
                    double alcoholpercent;

                    do
                    {
                        Console.Write("AlcoholPercent: ");
                        string alcoholpercentstr = Console.ReadLine();
                    } while (!double.TryParse(alcoholpercentstr, out alcoholpercent));


                    DrinkProduct drinkproduct = new DrinkProduct
                    {
                        Name = name,
                        Price = price,
                        AlcoholPercent= alcoholpercent,

                    };

                    return drinkproduct;





                }
            }
        }
    }
}

