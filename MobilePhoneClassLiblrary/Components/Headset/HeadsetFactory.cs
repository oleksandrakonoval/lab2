using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public static class HeadsetFactory
    {
        public static IPlayback GetPlayback(int headsetType)
        {
            IPlayback playback = null;
            switch (headsetType)
            {
                case 1:
                    playback = new iPhoneHeadset(new ConsoleOutput());
                    break;
                case 2:
                    playback = new SamsungHeadset(new ConsoleOutput());
                    break;
                case 3:
                    playback = new UnoffocoaliPhoneHeadset(new ConsoleOutput());
                    break;
                case 4:
                    playback = new PhoneSpeaker(new ConsoleOutput());
                    break;
                default:
                    throw new ArgumentException("Invalis headset type");
            }
            return playback;
        }
    }
}
