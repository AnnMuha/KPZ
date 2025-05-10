using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Factories;
using Task_2.Client;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("--- Продукція Macrosoft ---");
            var macrosoftClient = new TechClient(new MacrosoftFactory());
            macrosoftClient.Run();

            Console.WriteLine("\n--- Продукція Xiaoboy ---");
            var xiaoboyClient = new TechClient(new XiaoboyFactory());
            xiaoboyClient.Run();

            Console.WriteLine("\n--- Продукція Bamsung ---");
            var bamsungClient = new TechClient(new BamsungFactory());
            bamsungClient.Run();
        }
    }
}
