using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.LightHTML.Events;

namespace Task5.LightHTML.Events
{
    public class ClickLogger : IEventListener
    {
        public void HandleEvent(string eventType, LightElement element)
        {
            Console.WriteLine($"[EVENT] Подія '{eventType}' сталася на елементі <{element.Tag}>.");
        }
    }
}
