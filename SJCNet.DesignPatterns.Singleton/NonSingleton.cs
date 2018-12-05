namespace SJCNet.DesignPatterns.Singleton
{
    public class NonSingleton : ITeaMaker
    {
        public readonly TeaMaker _teaMaker;

        public NonSingleton()
        {
            _teaMaker = new TeaMaker();
        }

        public void BoilKettle()
        {
            _teaMaker.BoilKettle();
        }

        public void FillCup()
        {
            _teaMaker.FillCup();
        }

        public void FillKettle()
        {
            _teaMaker.FillKettle();
        }

        public void PutTeaBagInCup()
        {
            _teaMaker.PutTeaBagInCup();
        }
    }
}