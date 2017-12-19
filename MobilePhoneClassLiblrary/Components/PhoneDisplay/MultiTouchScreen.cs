using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class MultiTouchScreen : TouchScreen
    {
        public MultiTouchScreen()
        {

        }

        public MultiTouchScreen(double size, int[] pixels)
        {
            this.Size = size;
            this.Pixels = pixels;
        }

        public override string ToString()
        {
            string result = base.ShowPixelsInfo() + '\n' + base.ShowSizeInfo() + '\n';
            return result+"MultiTouch Screen";
        }
    }
}
