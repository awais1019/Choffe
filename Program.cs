using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Self_Asessment_task.BL;
using Self_Asessment_task.DL;
using Self_Asessment_task.UI;

namespace Self_Asessment_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coffeeShop = new CoffeeShop("NESCAFE");
            CoffeeShopCRUD.AddCoffeeShopInList(coffeeShop);
            string path = "D:\\Menu Items.txt";
            MenuItemsFileHandling.ReadMenuItems(path, coffeeShop);
            var result = CheckCoffeeShop.CheckCoffeeShopI();
            if (result)
            {
                while (true)
                {
                    Console.Clear();
                    string option = MainMenuDriver.MainMenuOptions();
                    if (option == "1")
                    {
                        MenuItem menuItem = AddItemMenu.AddMenuItem();
                        coffeeShop.MenuItemList.Add(menuItem);
                        MenuItemsFileHandling.WriteMenuItems(path,menuItem);
                    }
                    else if (option == "2")
                    {
                        if (OrderItemMenu.OrderedItemNameCheck(coffeeShop.MenuItemList, coffeeShop.OrderList))
                        {
                            Console.WriteLine("Ordered Placed succesfully !");
                        }
                        else
                        {
                            Console.WriteLine("Item is not currently available !");
                        }

                    }
                    else if (option == "3")
                    {
                        if (!FulFilOrder.CheckOrderList(coffeeShop.OrderList))
                        {
                            Console.WriteLine("All orders have been exhausted !");
                        }
                        Console.ReadKey();
                    }
                    else if (option == "4")
                    {
                        coffeeShop.DisplayOrderList();
                        Console.ReadKey();
                    }
                    else if (option == "5")
                    {
                        Console.WriteLine("Total Amount is : " + coffeeShop.CalculateTotalAmountOfOrders());
                        Console.ReadKey();
                    }
                    else if (option == "6")
                    {
                        coffeeShop.CheapestItemInMenuList();
                        Console.ReadKey();
                    }
                    else if (option == "7")
                    {
                        coffeeShop.DrinksOnlyInMenuList();
                        Console.ReadKey();
                    }
                    else if (option == "8")
                    {
                        coffeeShop.FoodOnlyInMenuList();
                        Console.ReadKey();
                    }
                    else if (option == "9")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You have Entered Wrong Option!");
                    }
                }


            }

            else
            {
                Console.WriteLine("You Entered Wrong Coffee Shop name !");
            }


        }

    }

}
