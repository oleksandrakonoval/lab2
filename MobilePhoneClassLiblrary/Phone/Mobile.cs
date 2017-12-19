using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public abstract class Mobile
    {
        public abstract ScreenBase Screen { get; }
        public abstract PhoneDisplay Display { get; }
        public abstract Keyboard Keyboard { get; }
        public abstract Battery Battery { get; }
        // public abstract SimCard SimCard { get; }  //remains form lab1
        public abstract OperatingSystem OperatingSystem { get; }
        public abstract Camera Camera { get; }

        public IPlayback PlaybackComponent { get; set; }
        public ISimCard SimCardItem { get; set; }
        public ICharger ChargerComponenet { get; set; }


        public void Play (object data)
        {
            PlaybackComponent.Play(data);
        }

        private void Show(IScreenImage screenImage)
        {
            Screen.Show(screenImage);
        }

        public string Description()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type:\n{Screen.ToString()}");
            descriptionBuilder.AppendLine($"Display Parameters:\n{Display.ToString()}");
            descriptionBuilder.AppendLine($"Keyboard parmeters:\n{Keyboard.ToString()}");
            descriptionBuilder.AppendLine($"Battery parameters:\n{Battery.ToString()}");
           // descriptionBuilder.AppendLine($"SimCard parameters:\n{SimCard.ToString()}"); //remains form lab1
            descriptionBuilder.AppendLine($"Operating system parameters:\n{OperatingSystem.ToString()}");
            descriptionBuilder.AppendLine($"Camera parameters:\n{Camera.ToString()}");
            descriptionBuilder.AppendLine("====================================================================");
            return descriptionBuilder.ToString();
        }

        public void ConfigureMobile()
        {
            Console.WriteLine("Select playback component (specify index):");
            Console.WriteLine($"1 - {nameof(iPhoneHeadset)}");
            Console.WriteLine($"2 - {nameof(SamsungHeadset)}");
            Console.WriteLine($"3 - {nameof(UnoffocoaliPhoneHeadset)}");
            Console.WriteLine($"4 - {nameof(PhoneSpeaker)}");

            int type = Convert.ToInt32( Console.ReadLine());
            PlaybackComponent = HeadsetFactory.GetPlayback(type);
            PlaybackComponent.Play(new object());

            Console.WriteLine("Select SimCard (specify index):");
            Console.WriteLine($"1 - {nameof(NanoSim)}");
            Console.WriteLine($"2 - {nameof(MicroSim)}");
            Console.WriteLine($"3 - {nameof(MiniSim)}");
            Console.WriteLine($"4 - {nameof(Sim)}");

            type = Convert.ToInt32(Console.ReadLine());
            SimCardItem = SimCardFactory.GetSimCard(type);
            SimCardItem.Call(new object());

            Console.WriteLine("Select charger (specify index):");
            Console.WriteLine($"1 - {nameof(SamsungCharger)}");
            Console.WriteLine($"2 - {nameof(SonyCharger)}");
            Console.WriteLine($"3 - {nameof(NokiaCharger)}");
            Console.WriteLine($"4 - {nameof(MotoCharger)}");

            type = Convert.ToInt32(Console.ReadLine());
            ChargerComponenet = ChargerFactory.GetCharger(type);
            ChargerComponenet.Charge(new object());

            Console.ReadKey();
        }
    }
}
