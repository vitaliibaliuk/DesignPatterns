using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.task1
{
    public class DomesticSubscription : Subscription
    {
        private static List<string> channels { get; } = new List<string> { "Regional Channel", "News Channel"};
        public DomesticSubscription() : base(10, 1, channels)
        {
        }

        public override string AdditionalFeature()
        {
            return "Access to domestic content";
        }

    }
}
