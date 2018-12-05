namespace SJCNet.DesignPatterns.Singleton
{
    public interface ITeaMaker
    {
        void FillKettle();
        void BoilKettle();
        void PutTeaBagInCup();
        void FillCup();
    }
}