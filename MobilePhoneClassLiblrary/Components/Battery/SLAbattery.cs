using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class SLABattery : Battery 
    {
        public SLABattery()
        {
           
        }

        public SLABattery(int capacity)
        {
            this.Capacity = capacity;
        }

        public override string ToString()
        {
            return base.ShowBatteryinfo() + "\nBattary type is SLA Battery";
        }
    }
}
