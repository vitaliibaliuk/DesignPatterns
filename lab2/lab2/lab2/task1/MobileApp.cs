using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.task1
{
    public class MobileApp : FactorySubscription
    {
        public override subscription CreateSubscription(string subscriptionType)
        {
            switch (subscriptionType)
            {
                case "Domestic":
                    return new DomesticSubscription();
                case "Educational":
                    return new EducationalSubscription();
                case "Premium":
                    return new PremiumSubscription();
                default:
                    throw new ArgumentException("Invalid subscription type");
            }
        }
    }
}
