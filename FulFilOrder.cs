using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Self_Asessment_task.DL;

namespace Self_Asessment_task.UI
{
    public class FulFilOrder
    {
        public static bool CheckOrderList(List<MenuItem> OrderList)
        {
            foreach (var item in OrderList)
            {
                if (OrderList == null)
                {
                    return false;
                }
                else
                {
                    Console.WriteLine(item.NameOfItem + " is Ready !");
                }
            }
            return true;
        }
    }
}
