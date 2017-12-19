using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone;
using Fake;

namespace FakeTest
{
    [TestClass]
    public class FakeTest
    {
        [TestMethod]
        public void ConsoleFakePlay()
        {
            // Arrange / Act
            IOutput output = new OutputMock();
            FakeHeadset headset = new FakeHeadset(output);
            headset.Play(output);

            var expectedString = "iPhoneHeadset sound\r\n";
            
            //Assert
            Assert.AreEqual(expectedString, output.Output.ToString());
        }
        
    }
}
