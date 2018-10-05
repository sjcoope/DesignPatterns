using static System.Console;

namespace SJCNet.DesignPatterns.Observer.BasicAttempt
{
    public class SportsReporter : IReporter
    {
        public void Report(string headline)
        {
            if (!string.IsNullOrEmpty(headline))
            {
                WriteLine($"New Sports Headline: {headline}");
            }
        }
    }
}
