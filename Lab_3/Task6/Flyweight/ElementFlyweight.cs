using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Flyweight
{
    public class ElementFlyweight
    {
        public string Tag { get; }
        public string Display { get; }
        public bool IsSelfClosing { get; }

        public ElementFlyweight(string tag, string display, bool isSelfClosing)
        {
            Tag = tag;
            Display = display;
            IsSelfClosing = isSelfClosing;
        }
    }
}
