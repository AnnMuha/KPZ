using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Subscriptions
{
    public class EducationalSubscription : ISubscription
    {
        public void ShowDetails() =>
            Console.WriteLine("Освітня підписка: 5$, мінімум 3 місяці, канали: 20.");
    }
}
