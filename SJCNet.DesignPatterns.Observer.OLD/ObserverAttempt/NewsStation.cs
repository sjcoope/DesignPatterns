using System;
using System.Collections.Generic;

namespace SJCNet.DesignPatterns.Observer.Old.ObserverAttempt
{
    public class NewsStation : NewsStationBase, ISubject
    {
        private readonly List<IObserver> _observers;

        public NewsStation()
        {
            _observers = new List<IObserver>();
        }

        public override void NewHeadlineAvailable()
        {
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void DeregisterObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(i => i.Update(this));
        }
    }
}
