using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public enum ChargerTypik
    {
        SamsungCharger,
        SonyCharger,
        NokiaCharger,
        MotoCharger
    }

    public static class ChargerFactory
    {
        public static ICharger GetCharger(ChargerTypik chargerType, IOutput output)
        {
            string typeName = chargerType.ToString();
            typeName = "MobilePhone." + typeName;
            Type hType = Type.GetType(typeName);
            object ChargerComponent = Activator.CreateInstance(hType, output);
            ICharger charger = ChargerComponent as ICharger;
            return charger;
        }
    }
}
