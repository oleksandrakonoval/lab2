using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Camera 
    {
        public double QualityMPX { get; set; }
        public bool Autofocus { get; set; }
        public bool Flash { get; set; }

        public Camera()
        {

        }

        public Camera(double quality, bool autof, bool flash)
        {
            this.QualityMPX = quality;
            this.Autofocus = autof;
            this.Flash = flash;
        }

        public override string ToString()
        {
            string a = this.Flash ? "yes" : "no";
            string b= this.Autofocus? "yes" : "no";
            return $"{this.QualityMPX} MPX, flash - {a}, autofocus - {b}";
        }
    }
}
