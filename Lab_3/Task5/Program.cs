using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.LightHTML;

namespace Task5
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== LightHTML Renderer ===\n");

            var section = new LightElement("section", "block", false);
            section.AddClass("main-section");

            var title = new LightElement("h2", "block", false);
            title.AddChild(new LightText("Топ новини"));

            var image = new LightElement("img", "inline", true);
            image.AddClass("news-img");

            var paragraph = new LightElement("p", "block", false);
            paragraph.AddChild(new LightText("Сьогодні відбулись важливі події у світі технологій..."));

            section.AddChild(title);
            section.AddChild(image);
            section.AddChild(paragraph);

            Console.WriteLine(section.RenderOuterHTML());
        }
    }
}
