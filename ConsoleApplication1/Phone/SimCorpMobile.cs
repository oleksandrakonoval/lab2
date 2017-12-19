using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class SimCorpMobile : Mobile
    {
        public override ScreenBase Screen { get { return vOLEDScreen; } }
        private readonly OLEDScreen vOLEDScreen = new OLEDScreen();

        static int[] pixels = { 1200, 780 };
        public override PhoneDisplay Display { get { return vDisplay; } }
        private readonly MultiTouchScreen vDisplay = new MultiTouchScreen(4.9, pixels);

        public override Keyboard Keyboard { get { return vKeyboard; } }
        private readonly Keyboard vKeyboard = new Keyboard(0, 1);

        public override Battery Battery { get { return vBattery; } }
        private readonly LiionBattery vBattery = new LiionBattery(3000);

        //public override SimCard SimCard { get { return vSimCard; } }  //remains form lab1
        //private readonly SimCard vSimCard = new SimCard(0);

        public override OperatingSystem OperatingSystem{ get { return vOperatingSystem; } }
        private readonly OperatingSystem vOperatingSystem = new OperatingSystem(1, 2, 16);

        public override Camera Camera { get { return vCamera; } }
        private readonly Camera vCamera = new Camera(15, true, true);

        


    }
}
