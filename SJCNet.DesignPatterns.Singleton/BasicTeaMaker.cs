using SJCNet.DesignPatterns.Shared.Utility;

namespace SJCNet.DesignPatterns.Singleton
{
    public class BasicTeaMaker
    {
        private bool _kettleIsBoiled;
        private bool _kettleIsFull;
        private bool _cupIsFull;
        private bool _teabagInCup;

        public BasicTeaMaker()
        {
            _kettleIsBoiled = false;
        }

        public void BoilKettle()
        {
            if (_kettleIsFull && !_kettleIsBoiled)
            {
                Logger.Write("Kettle is boiling");
                _kettleIsBoiled = true;
            }
        }

        public void FillKettle()
        {
            if (!_kettleIsFull)
            {
                Logger.Write("Filling kettle");
                _kettleIsFull = true;
            }
        }

        public void FillCup()
        {
            if (_kettleIsBoiled && _teabagInCup && !_cupIsFull)
            {
                Logger.Write("Filling cup");
                _cupIsFull = true;
            }
        }

        public void PutTeaBagInCup()
        {
            if (!_cupIsFull)
            {
                Logger.Write("Putting teabag into cup");
                _teabagInCup = true;
            }
        }

        public void RemoveTeaBagFromCup()
        {
            if (_cupIsFull && _teabagInCup)
            {
                Logger.Write("Removing teabag from cup");
                _teabagInCup = false;
            }
        }
    }B
}
