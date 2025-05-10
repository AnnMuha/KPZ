using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.LightHTML.Visitor
{
    public class TagPrinterVisitor : IVisitor
    {
        public void Visit(LightElement element)
        {
            Console.WriteLine($"Visited element: <{element.Tag}>");

            foreach (var child in element.Children)
            {
                if (child is LightElement el)
                    el.Accept(this);
                else if (child is LightText txt)
                    txt.Accept(this);
            }
        }

        public void Visit(LightText text)
        {
            Console.WriteLine($"Visited text: {text.Content}");
        }
    }
}