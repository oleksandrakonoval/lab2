﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public enum SimCardTypeik
    {
        NanoSim,
        MicroSim,
        MiniSim,
        Sim
    }

    public static class SimCardFactory
    {
        public static ISimCard GetSimCard(SimCardTypeik simCardType, IOutput output)
        {
            string typeName = simCardType.ToString();
            typeName = "MobilePhone." + typeName;
            Type hType = Type.GetType(typeName);
            object SimCardItem = Activator.CreateInstance(hType, output);
            ISimCard simcard = SimCardItem as ISimCard;
            return simcard;

        }
    }
}
