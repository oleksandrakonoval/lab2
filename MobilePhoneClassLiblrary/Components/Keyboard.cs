using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public enum language
    {
        Danish,
        English,
        German,
        Russian,
        Ukraininan
    }
    public enum keybordType
    {
        qwerty,
        numeric,
        other
    }

    public class Keyboard
    {
        
        public language Language { get; set; }
        public keybordType KeyboardType { get; set; }

        public Keyboard()
        {
            this.KeyboardType = (keybordType)0;
            this.Language = (language)1;
        }
        public Keyboard(int ktype, int lang)
        {
            this.KeyboardType =(keybordType)ktype;
            this.Language = (language)lang;
        }

        public override string ToString()
        {
            return $"Language: {(Language)}, Keyboard type: {(KeyboardType)}";
        }
    }
}
