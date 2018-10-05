using System;
using static System.Console;

namespace SJCNet.DesignPatterns.Observer.Old.ObserverAttempt
{
    public class SportsReporter : IObserver, IReporter
    {
        public void Update(object sender)
        {
            var newsStation = (sender as INewsStationBase);
            if (newsStation == null) throw new ArgumentException("sender is not of type NewsStation");

            var headline = newsStation.GetSportsHeadline();
            if (!string.IsNullOrEmpty(headline))
            {
                Report(headline);
            }
        }

        public void Report(string headline)
        {
            WriteLine($"New Sports Headline: {headline}");
        }
    }
}
