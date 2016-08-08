namespace SJCNet.DesignPatterns.Observer
{
    public interface INewsStationBase
    {
        bool IsActive { get; set; }

        void BeginBroadcasting();

        string GetCurrentAffairsHeadline();

        string GetFinanceHeadline();

        string GetSportsHeadline();

        void NewHeadlineAvailable();
    }
}