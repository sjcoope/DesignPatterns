namespace SJCNet.DesignPatterns.Factory.Shared
{
    public interface IAutomobile
    {
        string Name { get; }

        Colours Colour { get; }

        int Doors { get; }

        int EngineSize { get; }

        int Seats { get; }

        void PerformValet();

        void PerformService();
        
        void AddFuel();
    }
}
