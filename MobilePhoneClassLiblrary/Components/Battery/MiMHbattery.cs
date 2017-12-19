using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class MiMHBattery : Battery
    {
        public MiMHBattery()
        {

        }

        public MiMHBattery(int capacity)
        {
            this.Capacity = capacity;
        }

        public override string ToString()
        {
            return base.ShowBatteryinfo() + "\nBattary type is MiMH Battery";
        }
    }
}
