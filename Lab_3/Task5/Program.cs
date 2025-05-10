using System;
using System.Text;
using Task5.LightHTML;
using Task5.LightHTML.Events;
using Task5.LightHTML.Strategy;
using Task5.LightHTML.Command;

namespace Task5
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== LightHTML Renderer з підтримкою подій, стратегій і команди ===\n");

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

            // Додавання класу через команду
            var addCommand = new AddClassCommand(button, "active");
            addCommand.Execute();

            Console.WriteLine("\n-- Після виконання команди (додано клас 'active') --");
            Console.WriteLine(button.RenderOuterHTML());

            addCommand.Undo();

            Console.WriteLine("\n-- Після скасування команди (видалено клас 'active') --");
            Console.WriteLine(button.RenderOuterHTML());

            // Додаємо кнопку до секції
            section.AddChild(button);

            // Зображення (стратегія завантаження)
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
