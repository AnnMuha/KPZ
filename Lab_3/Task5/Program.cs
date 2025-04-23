using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.LightHTML;
using Task5.LightHTML.Events;
using Task5.LightHTML.Strategy;

namespace Task5
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== LightHTML Renderer з підтримкою подій та стратегій ===\n");

            var section = new LightElement("section", "block", false);
            section.AddClass("main-section");

            var button = new LightElement("button", "inline", false);
            button.AddChild(new LightText("Натисни мене"));
            button.AddEventListener("click", new ClickLogger());
            section.AddChild(button);

            var image1 = new ImageElement("images/cat.jpg", new FileImageLoadingStrategy());
            var image2 = new ImageElement("https://example.com/dog.jpg", new NetworkImageLoadingStrategy());
            section.AddChild(image1);
            section.AddChild(image2);

            Console.WriteLine(section.RenderOuterHTML());

            Console.WriteLine("\n-- Емітація кліку по кнопці --");
            button.DispatchEvent("click");
        }
    }
}
