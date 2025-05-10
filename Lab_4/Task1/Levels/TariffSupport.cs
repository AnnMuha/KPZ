using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Levels
{
    public class TariffSupport : SupportHandler
    {
        public override void ProcessRequest()
        {
            Console.WriteLine("Чи ваша проблема пов'язана з тарифним планом? (так/ні)");

            if (Console.ReadLine()?.Trim().ToLower() == "так")
            {
                Console.WriteLine("Ваш запит вирішує служба підтримки тарифів (1 рівень).");
            }
            else
            {
                _next?.ProcessRequest();
            }
        }
    }
}
