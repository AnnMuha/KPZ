using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, ElementFlyweight> _flyweights = new Dictionary<string, ElementFlyweight>();

        public ElementFlyweight GetFlyweight(string tag, string display, bool isSelfClosing)
        {
            string key = tag + "_" + display + "_" + isSelfClosing;
            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new ElementFlyweight(tag, display, isSelfClosing);
            }
            return _flyweights[key];
        }
    }
}
