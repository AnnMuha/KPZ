using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.LightHTML.Visitor;

namespace Task5.LightHTML
{
    public abstract class LightNode
    {
        public abstract string RenderOuterHTML();
        public abstract string RenderInnerHTML();
        public abstract void Accept(IVisitor visitor); 

    }
}
