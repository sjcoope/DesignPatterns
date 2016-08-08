namespace SJCNet.DesignPatterns.Observer.ObserverAttempt
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);

        void DeregisterObserver(IObserver observer);

        void NotifyObservers();
    }
}
