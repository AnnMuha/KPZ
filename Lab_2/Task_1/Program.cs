using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Factories;
using Task_1.Subscriptions;

namespace Task_1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Створюємо фабрики
            SubscriptionFactory websiteFactory = new WebsiteFactory();
            SubscriptionFactory mobileAppFactory = new MobileAppFactory();
            SubscriptionFactory managerCallFactory = new ManagerCallFactory();

            // Створюємо підписки через фабрики
            ISubscription websiteSubscription = websiteFactory.CreateSubscription();
            ISubscription mobileAppSubscription = mobileAppFactory.CreateSubscription();
            ISubscription managerCallSubscription = managerCallFactory.CreateSubscription();

            // Виводимо інформацію
            websiteSubscription.ShowDetails();
            mobileAppSubscription.ShowDetails();
            managerCallSubscription.ShowDetails();
        }
    }
}
