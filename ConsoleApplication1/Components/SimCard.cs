using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public enum Format
    {
        nanoSim,
        microSim,
        miniSim,
        Sim
    }

    public class SimCard
    {
        public Format Simformat { get; set; }

        public SimCard()
        {

        }

        public SimCard(int format)
        {
            this.Simformat = (Format)format;
        }

        public override string ToString()
        {
            return $"Format: {this.Simformat}";
        }
    }
}
