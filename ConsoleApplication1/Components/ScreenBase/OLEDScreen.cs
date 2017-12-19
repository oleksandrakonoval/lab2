using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class OLEDScreen : ColorfulScreen
    {
        public override void Show (IScreenImage screenImage)
        {
            Console.WriteLine($"I am {nameof(OLEDScreen)}");
        }

        public override string ToString()
        {
            return "OLED Screen";
        }

    }
}
