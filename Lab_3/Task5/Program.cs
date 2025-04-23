using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.LightHTML;
using Task5.LightHTML.Events;

namespace Task5
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== LightHTML Renderer з підтримкою подій ===\n");

            var section = new LightElement("section", "block", false);
            section.AddClass("main-section");

            var button = new LightElement("button", "inline", false);
            button.AddChild(new LightText("Натисни мене"));

            var logger = new ClickLogger();
            button.AddEventListener("click", logger);

            section.AddChild(button);

            Console.WriteLine(section.RenderOuterHTML());

            Console.WriteLine("\n-- Емітація кліку по кнопці --");
            button.DispatchEvent("click");
        }
    }
}
