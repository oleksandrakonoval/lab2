using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public enum OSType
    {
        Android,
        WindowsPhone,
        Linux,
        iOS,
        Symbian
    }

    public class OperatingSystem 
    {
        public OSType OSType { get; set; }
        
        public int RAM { get; set; }

        public int InternalMemory { get; set; }

        public OperatingSystem()
        {

        }

        public OperatingSystem(int OS, int ram, int intmem)
        {
            this.OSType = (OSType)OS;
            this.RAM = ram;
            this.InternalMemory = intmem;
        }


        public override string ToString()
        {
            return $"OS Type : {this.OSType}, RAM : {this.RAM} Gb, internal memory {this.InternalMemory} Gb";
        }
    }
}
