using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class ColorfulScreen :ScreenBase
    {
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine($"I am {nameof(ColorfulScreen)}");
        }

        public override void Show(IScreenImage screenImage, int brightness)
        {
            Console.WriteLine($"I am {nameof(ColorfulScreen)} with brightness {brightness}");
        }

        public override string ToString()
        {
            return "Colorful Screen";
        }

    }
}
