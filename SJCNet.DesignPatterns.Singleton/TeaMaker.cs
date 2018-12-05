using SJCNet.DesignPatterns.Shared.Utility;
using System;
using System.Threading;

namespace SJCNet.DesignPatterns.Singleton
{
    public class TeaMaker : ITeaMaker
    {
        private readonly Guid _name;
        private readonly string _loggerFormat = $"{0}: {1}";
        private readonly int _delay = new Random().Next(1000);
        private bool _kettleIsBoiled;
        private bool _kettleIsFull;
        private bool _cupIsFull;
        private bool _teabagInCup;

        public TeaMaker()
        {
            System.Console.WriteLine("TeaMaker Constructor");
            _name = Guid.NewGuid();
            _kettleIsBoiled = false;
            _kettleIsFull = false;
            _cupIsFull = false;
            _teabagInCup = false;
        }

        private void LogMessage(string message) 
        {
            Logger.Write($"{_name} - {message}");
        }

        public void FillKettle()
        {
            if (_kettleIsFull) LogMessage("Kettle is already full");
            else
            {
                LogMessage("Filling kettle");
                _kettleIsFull = true;
            }
        }

        public void BoilKettle()
        {
            if (!_kettleIsFull) LogMessage("Kettle is not full.");
            else if (_kettleIsBoiled) LogMessage("Kettle is already boiled");
            else
            {
                LogMessage("Kettle is boiling");
                _kettleIsBoiled = true;
            }
        }

        public void PutTeaBagInCup()
        {
            if (!_kettleIsBoiled) LogMessage("Kettle is not boiled");
            else if (_teabagInCup) LogMessage("Teabag is already in cup");
            else
            {
                LogMessage("Putting teabag into cup");
                _teabagInCup = true;
            }
        }

        public void FillCup()
        {
            if (!_kettleIsBoiled) LogMessage("Kettle is not boiled");
            else if (!_teabagInCup) LogMessage("Teabag is not in cup");
            else if (_cupIsFull) LogMessage("Cup is already full");
            else
            {
                LogMessage("Filling cup");
                _cupIsFull = true;
            }
        }
    }
}
