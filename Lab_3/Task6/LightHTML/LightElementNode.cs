using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.Flyweight;

namespace Task6.LightHTML
{
    public class LightElementNode : LightNode
    {
        private readonly ElementFlyweight _flyweight;
        public List<LightNode> Children { get; } = new List<LightNode>();

        public LightElementNode(ElementFlyweight flyweight)
        {
            _flyweight = flyweight;
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public override string OuterHTML()
        {
            if (_flyweight.IsSelfClosing)
                return "<" + _flyweight.Tag + " />\n";

            return "<" + _flyweight.Tag + ">\n" + InnerHTML() + "</" + _flyweight.Tag + ">\n";
        }

        public override string InnerHTML()
        {
            return string.Concat(Children.Select(child => child.OuterHTML()));
        }
    }
}
