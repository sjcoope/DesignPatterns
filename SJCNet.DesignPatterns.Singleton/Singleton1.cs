namespace SJCNet.DesignPatterns.Singleton
{
    public class Singleton1 : ITeaMaker
    {
        public static Singleton1 _instance = null;
        public static TeaMaker _teaMaker = null;

        private Singleton1()
        {
            _teaMaker = new TeaMaker();
        }

        public static Singleton1 Instance
        {
            get
            {
                return _instance ?? (_instance = new Singleton1());
            }
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