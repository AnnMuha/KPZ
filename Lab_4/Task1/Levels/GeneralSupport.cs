using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Levels
{
    public class GeneralSupport : SupportHandler
    {
        public override void ProcessRequest()
        {
            Console.WriteLine("Можливо, у вас загальне запитання чи інша проблема? (так/ні)");

            if (Console.ReadLine()?.Trim().ToLower() == "так")
            {
                Console.WriteLine("Ваш запит передано до загальної служби підтримки (4 рівень).");
            }
            else
            {
                Console.WriteLine("На жаль, не вдалося класифікувати запит. Повторіть спробу.\n");
                Program.Main(null); // перезапуск
            }
        }
    }
}
