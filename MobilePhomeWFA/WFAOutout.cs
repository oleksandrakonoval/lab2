using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone;
using System.Windows.Forms;

namespace MobilePhomeWFA
{
    public class WFAOutput : IOutput
    {
        private TextBox myTextBox=new TextBox();

        public string Output
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Write(string text)
        {

            myTextBox.AppendText(text);
        }

        public void WriteLine(string text)
        {
            myTextBox.AppendText(text);
            myTextBox.AppendText(Environment.NewLine);
        }

        public WFAOutput(TextBox textBox)
        {
            this.myTextBox = textBox;
        }
    }
}
