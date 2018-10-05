using SJCNet.DesignPatterns.Shared.Contracts.Old;
using static System.Console;

namespace SJCNet.DesignPatterns.Observer.Old
{
    public class Example : IExample
    {
        public void Execute()
        {
            // Basic Attempt Initialisation
            // -------------------------------
            WriteLine("Starting Basic Attempt...");
            var newsStation1 = new BasicAttempt.NewsStation();
            newsStation1.BeginBroadcasting();

            // Wait for articles to load (bad practice)!  
            while (newsStation1.IsActive)
            {
                System.Threading.Thread.Sleep(1000);
            }

            // Observer Attempt Initialisation
            // -------------------------------
            WriteLine(string.Empty);
            WriteLine("Starting Observer Attempt...");
            var newsStation2 = new ObserverAttempt.NewsStation();
            newsStation2.RegisterObserver(new ObserverAttempt.SportsReporter());
            newsStation2.RegisterObserver(new ObserverAttempt.CurrentAffairsReporter());
            newsStation2.RegisterObserver(new ObserverAttempt.FinanceReporter());
            newsStation2.BeginBroadcasting();

            // Wait for articles to load (bad practice)!  
            while (newsStation2.IsActive)
            {
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
