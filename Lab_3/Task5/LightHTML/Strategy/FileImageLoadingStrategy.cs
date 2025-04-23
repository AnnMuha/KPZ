using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task5.LightHTML.Strategy
{
    public class FileImageLoadingStrategy : IImageLoadingStrategy
    {
        public string LoadImage(string href)
        {
            return File.Exists(href) ? $"(Image from file: {href})" : "(File not found)";
        }
    }
}
