using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Self_Asessment_task.DL;

namespace Self_Asessment_task.BL
{
     public class CoffeeShop
     {
        public string Name;
        public List<MenuItem> MenuItemList = new List<MenuItem>();
        public List<MenuItem> OrderList = new List<MenuItem>();
        public CoffeeShop(string name)
        {
            Name = name;
        }
        public void AddMenuItemInList(MenuItem Item)
        {
            MenuItemList.Add(Item);
        }
        public void AddOrderInList(MenuItem Item)
        {
            OrderList.Add(Item);
        }
        public void DisplayOrderList()
        {
            int x = 1;
            int count = 1;
            foreach(var item in OrderList )
            {
                if(OrderList != null)
                {
                Console.WriteLine(x+": " + item.NameOfItem);
                    x++;
                }
                else
                {
                    count = 0;
                    break;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("No orders Yet !");
            }
        }
        public float CalculateTotalAmountOfOrders()
        {
            float totalAmount = 0;
            foreach(var item in OrderList )
            {
                totalAmount += item.PriceOfItem;
            }
            return totalAmount;
        }
        public void CheapestItemInMenuList()
        {
            float minimum = float.MaxValue;
            string nameOfItem = "";
            foreach(var item in MenuItemList)
            {
                if(minimum > item.PriceOfItem)
                {
                    minimum = item.PriceOfItem;
                    nameOfItem = item.NameOfItem;
                }
            }
            Console.WriteLine("The cheapest item in the menu : " + nameOfItem);
/*            if (MenuItemList.Count > 0)
            {
                MenuItem cheapestItem = MenuItemList.OrderBy(item => item.PriceOfItem).First();
                Console.WriteLine("Cheapest item in the menu: " + cheapestItem.NameOfItem);
            }
            else
            {
                Console.WriteLine("Menu is empty!");
            }*/
        }
        public void DrinksOnlyInMenuList()
        {
            string pattern = @"^(?i)Drink$";
            foreach(var item in MenuItemList)
            {
                if(Regex.IsMatch(item.TypeOfItem,pattern))

                {
                    Console.WriteLine(item.NameOfItem);
                }
            }
        }
        public void FoodOnlyInMenuList()
        {
            string pattern = @"^(?i)food$";
            foreach (var item in MenuItemList)
            {
                if (Regex.IsMatch(item.TypeOfItem,pattern))
                {
                    Console.WriteLine(item.NameOfItem);
                }
            }
        }
    }
}
