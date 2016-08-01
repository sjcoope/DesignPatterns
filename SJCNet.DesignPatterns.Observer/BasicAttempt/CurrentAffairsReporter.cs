using static System.Console;

namespace SJCNet.DesignPatterns.Observer.BasicAttempt
{
    public class CurrentAffairsReporter : IReporter
    {
        public void Report(string headline)
        {
            if (!string.IsNullOrEmpty(headline))
            {
                WriteLine($"New Current Affairs Headline: {headline}");
            }
        }
    }
}
