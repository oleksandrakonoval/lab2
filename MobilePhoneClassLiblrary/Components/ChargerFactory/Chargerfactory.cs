using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public static class ChargerFactory
    {
        public static ICharger GetCharger(int chargerType)
        {
            ICharger charger = null;
            switch (chargerType)
            {
                case 1:
                    charger = new SamsungCharger(new ConsoleOutput());
                    break;
                case 2:
                    charger = new SonyCharger(new ConsoleOutput());
                    break;
                case 3:
                    charger = new NokiaCharger(new ConsoleOutput());
                    break;
                case 4:
                    charger = new MotoCharger(new ConsoleOutput());
                    break;
                default:
                    throw new ArgumentException("Invalis SimCard type");
            }
            return charger;
        }
    }
}
