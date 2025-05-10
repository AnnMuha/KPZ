using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Core;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();

            editor.Type("Привіт, світ!");
            editor.Save();

            editor.Type(" Ще трохи тексту.");
            editor.Save();

            editor.Type(" А тепер щось зайве.");

            Console.WriteLine("Поточний текст: " + editor.GetContent());

            editor.Undo();
            Console.WriteLine("Після одного undo: " + editor.GetContent());

            editor.Undo();
            Console.WriteLine("Після другого undo: " + editor.GetContent());
        }
    }
}
