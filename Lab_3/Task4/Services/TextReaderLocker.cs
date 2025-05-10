using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4.Services
{
    public class TextReaderLocker : ITextReader
    {
        private readonly ITextReader _innerReader;
        private readonly Regex _allowedPattern;

        public TextReaderLocker(ITextReader reader, string pattern)
        {
            _innerReader = reader;
            _allowedPattern = new Regex(pattern);
        }

        public char[][] ReadTextFile(string filePath)
        {
            if (!_allowedPattern.IsMatch(filePath))
            {
                Console.WriteLine("[ПОМИЛКА] Access denied!");
                return Array.Empty<char[]>();
            }

            return _innerReader.ReadTextFile(filePath);
        }
    }
}
