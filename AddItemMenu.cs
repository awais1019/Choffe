using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Self_Asessment_task.DL;

namespace Self_Asessment_task.UI
{
    public class AddItemMenu
    {
        public static MenuItem AddMenuItem()
        {
            Console.WriteLine("Enter name of item : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter type of item : ");
            string type = Console.ReadLine();
            Console.WriteLine("Enter price of item : ");
            float price = float.Parse(Console.ReadLine());
            var Object = new MenuItem(name, type, price);
            return Object;
        }

    }
}
