using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.LightHTML;
using Task5.LightHTML.Events;
using Task5.LightHTML.Strategy;
using Task5.LightHTML.Iterator;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Створюємо дерево
            var root = new LightElement("div", "block", false);
            var header = new LightElement("header", "block", false);
            var nav = new LightElement("nav", "block", false);
            var main = new LightElement("main", "block", false);
            var paragraph = new LightText("Вітаємо у нашому HTML!");
            var footer = new LightElement("footer", "block", false);

            // Формуємо дерево
            header.AddChild(new LightText("Це заголовок"));
            nav.AddChild(new LightText("Головна | Про нас | Контакти"));
            main.AddChild(paragraph);
            footer.AddChild(new LightText("© 2025"));

            root.AddChild(header);
            root.AddChild(nav);
            root.AddChild(main);
            root.AddChild(footer);

            // Отримуємо ітератор та обходимо дерево
            var iterator = root.GetDepthFirstIterator();
            while (iterator.HasNext())
            {
                var node = iterator.Next();
                Console.WriteLine(node.RenderOuterHTML());
            }
        }
    }
}
