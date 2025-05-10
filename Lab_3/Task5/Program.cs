using System;
using System.Text;
using Task5.LightHTML;
using Task5.LightHTML.Events;
using Task5.LightHTML.Strategy;
using Task5.LightHTML.State;

namespace Task5
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== LightHTML Renderer з підтримкою подій, шаблонів і стратегій ===\n");

            // Створення секції
            var section = new LightElement("section", "block", false);
            section.AddClass("main-section");

            // Кнопка
            var button = new LightElement("button", "inline", false);
            button.AddClass("btn");
            button.AddClass("btn-primary");
            button.AddChild(new LightText("Натисни мене"));

            // Додаємо обробник події кліку
            button.AddEventListener("click", new ClickLogger());

            // Прихований елемент (буде не виводитися)
            var hiddenDiv = new LightElement("div", "block", false);
            hiddenDiv.AddClass("secret");
            hiddenDiv.AddChild(new LightText("Це приховано"));
            hiddenDiv.Visibility.SetState(new HiddenState()); // зміна стану на прихований

            // Додаємо все в секцію
            section.AddChild(button);
            section.AddChild(hiddenDiv);

            // Зображення з різними стратегіями
            var image1 = new ImageElement("images/cat.jpg", new FileImageLoadingStrategy());
            var image2 = new ImageElement("https://example.com/dog.jpg", new NetworkImageLoadingStrategy());
            section.AddChild(image1);
            section.AddChild(image2);

            // Виведення HTML
            Console.WriteLine("\n--- Згенерований HTML ---");
            Console.WriteLine(section.RenderOuterHTML());

            // Емітація події
            Console.WriteLine("\n-- Емітація події 'click' для кнопки --");
            button.DispatchEvent("click");

            // Тест: показати прихований елемент
            Console.WriteLine("\n-- Робимо прихований div видимим --");
            hiddenDiv.Visibility.SetState(new VisibleState());
            Console.WriteLine(section.RenderOuterHTML());
        }
    }
}
