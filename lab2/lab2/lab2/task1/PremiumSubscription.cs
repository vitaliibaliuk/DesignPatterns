using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.task1
{
    public class PremiumSubscription : Subscription
    {
        private static List<string> channels { get; } = new List<string> { "Sport Channel", "Education Channel 1", "Education Channel 2", "Regional Channel", "News Channel" };

        public PremiumSubscription() : base(34, 1, channels)
        {
        }

        public override string AdditionalFeature()
        {
            return "Access to premium content, educational resources, and exclusive features";
        }
    }
}
