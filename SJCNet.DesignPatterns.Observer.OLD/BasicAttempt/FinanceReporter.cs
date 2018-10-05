using static System.Console;

namespace SJCNet.DesignPatterns.Observer.Old.BasicAttempt
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
