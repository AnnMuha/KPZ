using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Levels
{
    public class TechnicalSupport : SupportHandler
    {
        public override void ProcessRequest()
        {
            Console.WriteLine("У вас технічна проблема зі зв'язком чи додатком? (так/ні)");

            if (Console.ReadLine()?.Trim().ToLower() == "так")
            {
                Console.WriteLine("Ваш запит обробляє технічна служба підтримки (3 рівень).");
            }
            else
            {
                _next?.ProcessRequest();
            }
        }
    }
}
