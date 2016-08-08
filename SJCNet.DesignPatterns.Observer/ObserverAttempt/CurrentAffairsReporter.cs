using System;
using static System.Console;

namespace SJCNet.DesignPatterns.Observer.ObserverAttempt
{
    public class CurrentAffairsReporter : IObserver, IReporter
    {
        public void Update(object sender)
        {
            var newsStation = (sender as INewsStationBase);
            if (newsStation == null) throw new ArgumentException("sender is not of type NewsStation");

            var headline = newsStation.GetCurrentAffairsHeadline();
            if (!string.IsNullOrEmpty(headline))
            {
                Report(headline);
            }
        }

        public void Report(string headline)
        {
            WriteLine($"New Current Affairs Headline: {headline}");
        }
    }
}
