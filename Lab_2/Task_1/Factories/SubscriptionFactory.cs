using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Factories
{
    using Task_1.Subscriptions;

    public abstract class SubscriptionFactory
    {
        public abstract ISubscription CreateSubscription();
    }
}
