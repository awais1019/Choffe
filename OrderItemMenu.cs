using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Self_Asessment_task.DL;

namespace Self_Asessment_task.UI
{
    public class OrderItemMenu
    {
        public static bool OrderedItemNameCheck(List<MenuItem> MenuItemList , List<MenuItem> OrderList)
        {
            Console.WriteLine("Enter name of Item : ");
            string nameOfItem = Console.ReadLine();
            foreach(var item in MenuItemList)
            {
                if(nameOfItem == item.NameOfItem)
                {
                    OrderList.Add(item);
                    return true;
                }
            }
            return false;
        }
    }
}
