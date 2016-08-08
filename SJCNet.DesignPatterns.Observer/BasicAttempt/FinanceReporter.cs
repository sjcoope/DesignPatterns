using static System.Console;

namespace SJCNet.DesignPatterns.Observer.BasicAttempt
{
    public class FinanceReporter : IReporter
    {
        public void Report(string headline)
        {
            if (!string.IsNullOrEmpty(headline))
            {
                WriteLine($"New Finance Headline: {headline}");
            }
        }
    }
}
