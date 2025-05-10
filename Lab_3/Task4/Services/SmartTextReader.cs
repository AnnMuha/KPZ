using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task4.Services
{
    public class SmartTextReader : ITextReader
    {
        public char[][] ReadTextFile(string filePath)
        {
            var result = new List<char[]>();

            foreach (string line in File.ReadLines(filePath))
            {
                result.Add(line.ToCharArray());
            }

            return result.ToArray();
        }
    }
}