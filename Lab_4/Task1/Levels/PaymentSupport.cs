using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Levels
{
    public class PaymentSupport : SupportHandler
    {
        public override void ProcessRequest()
        {
            Console.WriteLine("Чи виникла проблема з оплатою або рахунком? (так/ні)");

            if (Console.ReadLine()?.Trim().ToLower() == "так")
            {
                Console.WriteLine("Ваш запит обробляє служба підтримки оплати (2 рівень).");
            }
            else
            {
                _next?.ProcessRequest();
            }
        }
    }
}
