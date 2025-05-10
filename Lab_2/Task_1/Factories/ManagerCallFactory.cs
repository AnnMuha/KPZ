using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Factories
{
    using Task_1.Subscriptions;

    public class ManagerCallFactory : SubscriptionFactory
    {
        public override ISubscription CreateSubscription() => new PremiumSubscription();
    }
}
