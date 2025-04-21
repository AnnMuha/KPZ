using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var consoleLogger = new Logger();
            consoleLogger.Info("Це повідомлення для консолі");
            consoleLogger.Error("Це повідомлення про помилку для консолі");
            consoleLogger.Warning("Це попередження для консолі");

            var writer = new FileWriter("my_logs.txt");
            var fileLogger = new FileLoggerAdapter(writer);

            fileLogger.Info("Це повідомлення у файл");
            fileLogger.Error("Це помилка у файл");
            fileLogger.Warning("Це попередження у файл");

            Console.WriteLine("Логи записані у my_logs.txt");
        }
    }
}
