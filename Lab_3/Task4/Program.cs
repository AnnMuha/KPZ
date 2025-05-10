using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Services;

namespace Task4
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Тестування проксі ===");

            ITextReader realReader = new SmartTextReader();

            ITextReader logger = new TextReaderLogger(realReader);

            ITextReader locker = new TextReaderLocker(logger, @"^.*\.txt$");

            locker.ReadTextFile("test.txt"); // дозволений файл
            locker.ReadTextFile("secret_data.pdf"); // заборонений
        }
    }
}
