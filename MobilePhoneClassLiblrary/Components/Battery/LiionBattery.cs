using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class LiionBattery :Battery
    {
        public LiionBattery()
        {

        }

        public LiionBattery(int capacity)
        {
            this.Capacity = capacity;
        }

        public override string ToString()
        {
            return base.ShowBatteryinfo() + "\nBattary type is Li-ion Battery";
        }
    }
}
