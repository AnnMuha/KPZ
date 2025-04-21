using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Services
{
    public class TextReaderLogger : ITextReader
    {
        private readonly ITextReader _innerReader;

        public TextReaderLogger(ITextReader innerReader)
        {
            _innerReader = innerReader;
        }

        public char[][] ReadTextFile(string filePath)
        {
            Console.WriteLine($"[INFO] Відкриваємо файл: {filePath}");

            var content = _innerReader.ReadTextFile(filePath);

            Console.WriteLine($"[INFO] Успішно прочитано файл: {filePath}");
            Console.WriteLine($"[INFO] Рядків: {content.Length}");

            int totalSymbols = 0;
            foreach (var row in content)
                totalSymbols += row.Length;

            Console.WriteLine($"[INFO] Усього символів: {totalSymbols}");
            Console.WriteLine($"[INFO] Закриття файлу: {filePath}");

            return content;
        }
    }
}
