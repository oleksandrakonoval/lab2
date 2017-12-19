using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class PhoneDisplay 
    {
        public double Size { get; set; } 
        public int[] Pixels { get; set; }

        public PhoneDisplay()
        {

        }

        public PhoneDisplay (double size, int[] pixels)
        {
            this.Size = size;
            this.Pixels = pixels;
        }

        public string ShowSizeInfo ()
        {
            return ($"Display diagonal is {(this.Size)} inches");
        }

        public string ShowPixelsInfo()
        {
            return ($"Screen resolution is {this.Pixels[0]}x{this.Pixels[1]}");
        }
    }
}
