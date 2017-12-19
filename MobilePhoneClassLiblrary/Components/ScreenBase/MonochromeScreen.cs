using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class MonochromeScreen : ScreenBase
    {
        public override void Show (IScreenImage screenImage)
        {
            Console.WriteLine($"I am {nameof(MonochromeScreen)}");
        }

        public override void Show(IScreenImage screenImage, int brightness)
        {
            Console.WriteLine($"I am {nameof(MonochromeScreen)} with brightness {brightness}");
        }

        public override string ToString()
        {
            return "Monochrome Screen";
        }
    }
}
