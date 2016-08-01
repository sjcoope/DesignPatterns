using System;
using static System.Console;

namespace SJCNet.DesignPatterns.Observer.ObserverAttempt
{
    public class FinanceReporter :IObserver, IReporter
    {
        public void Update(object sender)
        {
            var newsStation = (sender as NewsStation);
            if (newsStation == null) throw new ArgumentException("sender is not of type NewsStation");

            var headline = newsStation.GetFinanceHeadline();
            if (!string.IsNullOrEmpty(headline))
            {
                Report(headline);
            }
        }

        public void Report(string headline)
        {
            WriteLine($"New Finance Headline: {headline}");
        }
    }
}
