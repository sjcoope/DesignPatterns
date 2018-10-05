namespace SJCNet.DesignPatterns.Observer.BasicAttempt
{
    public class NewsStation : NewsStationBase
    {
        public override void NewHeadlineAvailable()
        {
            var sportsReporter = new SportsReporter();
            sportsReporter.Report(base.GetSportsHeadline());

            var currentAffairsReporter = new CurrentAffairsReporter();
            currentAffairsReporter.Report(base.GetCurrentAffairsHeadline());

            var financeReporter = new FinanceReporter();
            financeReporter.Report(base.GetFinanceHeadline());
        }
    }
}
