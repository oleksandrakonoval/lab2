using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone;
using MobilePhomeWFA;
using System.Windows.Forms;

namespace Fake
{
    public class FakeHeadset : IPlayback
    {
        private IOutput Output;

        public FakeHeadset(IOutput output)
        {
            Output = output;
        }

        public void Play(object data)
        {
            Output.WriteLine($"{nameof(iPhoneHeadset)} sound");
        }
    }
}
