using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{ 
    public class ConsoleOutput: IOutput
    {
        public string Output
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Write(string text)
        {
            Console.Write(text);
        }
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
