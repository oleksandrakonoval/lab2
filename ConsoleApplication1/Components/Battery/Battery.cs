using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Battery 
    {
        public double Capacity { get; set; }

        public Battery()
        {

        }

        public Battery(int capacity)
        {
            this.Capacity = capacity;
        }

        public string ShowBatteryinfo()
        {
            return $"Battery capacity is {Capacity} mAh";
        }
    }
}
