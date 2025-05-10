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
            Console.WriteLine("=== LightHTML Renderer з підтримкою подій, шаблонів і стратегій ===\n");

            // Секція
            var section = new LightElement("section", "block", false);
            section.AddClass("main-section");

            // Кнопка
            var button = new LightElement("button", "inline", false);
            button.AddClass("btn");
            button.AddClass("btn-primary");
            button.AddChild(new LightText("Натисни мене"));

            // Подія
            button.AddEventListener("click", new ClickLogger());

            // Життєвий цикл (Template Method)
            button.Render();

            // Додаємо кнопку до секції
            section.AddChild(button);

            // Зображення (залежить від того, чи реалізовано Strategy Pattern)
            var image1 = new ImageElement("images/cat.jpg", new FileImageLoadingStrategy());
            var image2 = new ImageElement("https://example.com/dog.jpg", new NetworkImageLoadingStrategy());
            section.AddChild(image1);
            section.AddChild(image2);

            // Вивід HTML
            Console.WriteLine("\n--- HTML ---");
            Console.WriteLine(section.RenderOuterHTML());

            // Емітація події
            Console.WriteLine("\n-- Емітація кліку по кнопці --");
            button.DispatchEvent("click");
        }
    }
}