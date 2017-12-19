using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class SingleTouchScreen : TouchScreen
    {
        public SingleTouchScreen()
        {

        }

        public SingleTouchScreen(double size, int[] pixels)
        {
            this.Size = size;
            this.Pixels = pixels;
        }
        public override string ToString()
        {
            string result = base.ShowPixelsInfo() + '\n' + base.ShowSizeInfo() + '\n';
            return result+"SingleTouch Screen";
        }
    }
}
