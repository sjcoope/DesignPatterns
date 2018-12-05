using System;
using System.Threading;
using SJCNet.DesignPatterns.Shared.Utility;

namespace SJCNet.DesignPatterns.Singleton
{
    public sealed class Singleton2 : ITeaMaker
    {
        private static Singleton2 _instance = null;
        private TeaMaker _teaMaker = null;
        private static readonly object _lockObject = new object();
        private readonly Guid _name;
        private readonly string _loggerFormat = $"{0}: {1}";
        private bool _kettleIsBoiled;
        private bool _kettleIsFull;
        private bool _cupIsFull;
        private bool _teabagInCup;

        private Singleton2()
        {
            System.Console.WriteLine("Singleton2 Constructor");
            _name = Guid.NewGuid();
            _kettleIsBoiled = false;
            _kettleIsFull = false;
            _cupIsFull = false;
            _teabagInCup = false;
            _teaMaker = new TeaMaker();

        }

        public static Singleton2 Instance
        {
            get
            {
                lock (_lockObject)
                {
                    System.Console.WriteLine("Accessing locked code");
                    if (_instance == null)
                    {
                        System.Console.WriteLine("Instance is null");
                        _instance = new Singleton2();
                    }
                    return _instance;
                    //return _instance ?? (_instance = new Singleton2());
                }
            }
        }

        private void LogMessage(string message)
        {
            Logger.Write($"{_name} - {message}");
        }

        public void FillKettle()
        {
            _teaMaker.FillKettle();
        }

        public void BoilKettle()
        {
            _teaMaker.BoilKettle();
        }

        public void PutTeaBagInCup()
        {
            _teaMaker.PutTeaBagInCup();
        }

        public void FillCup()
        {
           _teaMaker.FillCup();
        }
    }
}