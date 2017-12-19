using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class NiCdBattery : Battery 
    {
        public NiCdBattery()
        {

        }

        public NiCdBattery(int capacity)
        {
            this.Capacity = capacity;
        }

        public override string ToString()
        {
            return base.ShowBatteryinfo()+"\nBattary type is NiCd Battary";
        }
    }
}
