using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Self_Asessment_task.DL;
using Self_Asessment_task.UI;
using Self_Asessment_task.BL;

namespace Self_Asessment_task.UI
{
    public class CheckCoffeeShop
    {
        public static bool CheckCoffeeShopI()
        {
            Console.WriteLine("Enter name of Coffee Shop : ");
            string nameOfCoffeeShop = Console.ReadLine();
            if(CoffeeShopCRUD.CoffeeShopCheckInList(nameOfCoffeeShop))
            {
                return true;
            }
            return false;
        }
    }
}
