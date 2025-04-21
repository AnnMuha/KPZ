using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.LightHTML
{
    public class LightText : LightNode
    {
        public string Content { get; }

        public LightText(string content)
        {
            Content = content;
        }

        public override string RenderOuterHTML() => Content;

        public override string RenderInnerHTML() => Content;
    }
}
