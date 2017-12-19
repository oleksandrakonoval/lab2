using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone;

namespace Fake
{
    public class OutputMock : IOutput
    {
        public string Output
        {
            get
            {
                return myText.ToString();
            }
        }
        private StringBuilder myText = new StringBuilder();

        public void Write(string text)
        {
            myText.Append(text);
        }

        public void WriteLine(string text)
        {
            Write(text);
            myText.AppendLine();
        }

        
    }
}
