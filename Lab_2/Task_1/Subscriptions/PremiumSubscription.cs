using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Subscriptions
{
    public class PremiumSubscription : ISubscription
    {
        public void ShowDetails() =>
            Console.WriteLine("Преміум підписка: 30$, мінімум 6 місяців, канали: 100.");
    }
}
