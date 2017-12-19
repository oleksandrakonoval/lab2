using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone;

namespace MobilePhone
{
    public enum headsetTypik
    {
        iPhoneHeadset,
        SamsungHeadset,
        UnoffocoaliPhoneHeadset,
        PhoneSpeaker
    }

    public static class HeadsetFactory
    {
        public static IPlayback GetPlayback(headsetTypik headsetType,IOutput output)
        {
            string typeName = headsetType.ToString();
            typeName = "MobilePhone." + typeName;
            Type hType = Type.GetType(typeName);
            object HeadsetComponent = Activator.CreateInstance(hType, output);
            IPlayback headset = HeadsetComponent as IPlayback;
            return headset;
        }
    }
}
