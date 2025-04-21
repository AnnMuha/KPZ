using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FileLoggerAdapter
    {
        private readonly FileWriter _writer;

        public FileLoggerAdapter(FileWriter writer)
        {
            _writer = writer;
        }

        public void Info(string message)
        {
            _writer.WriteLine("[ІНФО]: " + message);
        }

        public void Error(string message)
        {
            _writer.WriteLine("[ПОМИЛКА]: " + message);
        }

        public void Warning(string message)
        {
            _writer.WriteLine("[УВАГА]: " + message);
        }
    }
}
