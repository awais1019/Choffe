using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Self_Asessment_task.DL;
using Self_Asessment_task.UI;

namespace Self_Asessment_task.BL
{
    public class CoffeeShopCRUD
    {
        public static List<CoffeeShop> CoffeeShopList = new List<CoffeeShop>();
        public static void AddCoffeeShopInList(CoffeeShop Item)
        {
            CoffeeShopList.Add(Item);
        }
        public static bool CoffeeShopCheckInList(string nameOfCoffeeShop)
        {
            foreach (var item in CoffeeShopList)
            {
                if (item.Name == nameOfCoffeeShop)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
