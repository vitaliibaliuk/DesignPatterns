using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.task1
{
    public class EducationalSubscription : Subscription
    {
        private static List<string> channels { get; } = new List<string> { "Education Channel 1", "Education Channel 2" };

        public EducationalSubscription() : base(20, 3, channels)
        {
        }

        public override string AdditionalFeature()
        {
            return "Access to educational content and resources";
        }
    }
}
