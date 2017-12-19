using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class RetinaScreen : ColorfulScreen
    {
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine($"I am {nameof(RetinaScreen)}");
        }

        public override string ToString()
        {
            return "Retina Screen";
        }
    }
}
