using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Self_Asessment_task.BL;

namespace Self_Asessment_task.DL
{
     public static class MenuItemsFileHandling
    {
        public static void WriteMenuItems(string path,MenuItem obj)
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine($"{obj.NameOfItem},{obj.TypeOfItem},{obj.PriceOfItem}");
            file.Flush();
            file.Close();
        }
        /*  public static void ReadMenuItems(string path,CoffeeShop coffeeShop)
          {
              StreamReader file = new StreamReader(path);
              string record;
              while((record = file.ReadLine()) != null)
              {
                  string[] splittedRecord = record.Split(',');
                  string name = splittedRecord[0];
                  string type = splittedRecord[1];
                  float price = float.Parse(splittedRecord[2]);
                  MenuItem obj = new MenuItem(name,type,price);
                  coffeeShop.AddMenuItemInList(obj);
              }
              file.Close();
          }*/
        public static void ReadMenuItems(string path, CoffeeShop coffeeShop)
        {
            StreamReader file = new StreamReader(path);
            string record;
            while ((record = file.ReadLine()) != null)
            {
                string[] splittedRecord = record.Split(',');
                string name = Regex.Match(record, @"^([^,]+),").Groups[1].Value;
                string type = Regex.Match(record, @",([^,]+),").Groups[1].Value;
                float price = float.Parse(Regex.Match(record, @",([^,]+)$").Groups[1].Value);
                MenuItem obj = new MenuItem(name, type, price);
                coffeeShop.AddMenuItemInList(obj);
            }
            file.Close();
        }
    }
}
