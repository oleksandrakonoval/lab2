using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public static class SimCardFactory
    {
        public static ISimCard GetSimCard(int simCardType)
        {
            ISimCard simcard = null;
            switch (simCardType)
            {
                case 1:
                    simcard = new NanoSim(new ConsoleOutput());
                    break;
                case 2:
                    simcard = new MicroSim(new ConsoleOutput());
                    break;
                case 3:
                    simcard = new MiniSim(new ConsoleOutput());
                    break;
                case 4:
                    simcard = new Sim(new ConsoleOutput());
                    break;
                default:
                    throw new ArgumentException("Invalid SimCard type");
            }
            return simcard;
        }
    }
}
