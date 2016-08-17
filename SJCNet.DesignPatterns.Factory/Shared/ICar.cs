using SJCNet.DesignPatterns.Factory.Shared;

namespace SJCNet.DesignPatterns.Factory.Shared
{
    public interface ICar
    {
        Colours Colour { get; }

        int Doors { get; }

        int EngineSize { get; }

        int Seats { get; }

        void AddSeats();

        void AddColour();

        void AddEngine();

        void AddDoors();

        CarTypes Type { get; }
    }
}