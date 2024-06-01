using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.task1
{
    public interface subscription
    {
        public decimal MonthlyFee { get; }
        public int MinPeriod { get; }
        List<string> Channels { get; }
        string AdditionalFeature();
    }
    public class Subscription : subscription
    {
        public decimal MonthlyFee { get; }
        public int MinPeriod { get; }
        public List<string> Channels { get; }

        public Subscription(decimal monthlyFee, int minPeriod, List<string> channels)
        {
            MonthlyFee = monthlyFee;
            MinPeriod = minPeriod;
            Channels = channels;
        }

        public virtual string AdditionalFeature()
        {
            return "";
        }
        public override string ToString()
        {
            var channelsString = string.Join(", ", Channels);
            return $"MonthlyFee: {MonthlyFee}\nMinPeriod: {MinPeriod}\nChannels: {channelsString}\nAdditionalFeature: {AdditionalFeature()}";
        }
    }
}
