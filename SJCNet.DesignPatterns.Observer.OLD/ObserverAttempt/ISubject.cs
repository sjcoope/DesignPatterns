namespace SJCNet.DesignPatterns.Observer.Old.ObserverAttempt
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);

        void DeregisterObserver(IObserver observer);

        void NotifyObservers();
    }
}
