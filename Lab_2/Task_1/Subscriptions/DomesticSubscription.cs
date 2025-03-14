using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Subscriptions
{
    public class DomesticSubscription : ISubscription
    {
        public void ShowDetails() =>
            Console.WriteLine("Домашня підписка: 10$, мінімум 1 місяць, канали: 50.");
    }
}
