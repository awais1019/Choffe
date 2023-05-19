using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Asessment_task.UI
{
    public class MainMenuDriver
    {
        public static string MainMenuOptions()
        {
            Console.WriteLine("1: Add menu Item");
            Console.WriteLine("2: Add Order");
            Console.WriteLine("3: Fulfill Order");
            Console.WriteLine("4: List Order");
            Console.WriteLine("5: Due Amount");
            Console.WriteLine("6: Cheapest Item");
            Console.WriteLine("7: Drinks only");
            Console.WriteLine("8: Food only");
            Console.WriteLine("9: Exit");
            string option = Console.ReadLine();
            return option;
        }

    }
}
