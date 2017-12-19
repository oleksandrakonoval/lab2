using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public abstract class TouchScreen : PhoneDisplay
    {
        public TouchScreen()
        {
            
        }

        public TouchScreen(double size, int[] pixels)
        {
            this.Size = size;
            this.Pixels = pixels;
        }

        public override string ToString()
        {
            string result = base.ShowPixelsInfo() + '\n'+ base.ShowSizeInfo()+'\n';
            return result+"Touch screen";
        }
    }
}
