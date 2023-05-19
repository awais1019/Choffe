using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Asessment_task.DL
{
    public class MenuItem
    {
        public string NameOfItem;
        public string TypeOfItem;
        public float PriceOfItem;
        public MenuItem(string NameOfItem,string TypeOfItem,float PriceOfItem)
        {
            this.NameOfItem = NameOfItem;
            this.TypeOfItem = TypeOfItem;
            this.PriceOfItem = PriceOfItem;
        }
    }
}
