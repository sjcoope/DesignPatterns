using SJCNet.DesignPatterns.Factory.Shared;

namespace SJCNet.DesignPatterns.Factory.Shared
{
    public abstract class Car : ICar
    {
        public int EngineSize { get; protected set; }

        public Colours Colour { get; protected set; }

        public int Doors { get; protected set; }

        public int Seats { get; protected set; }

        public abstract CarTypes Type { get; }

        public abstract void AddSeats();

        public abstract void AddColour();

        public abstract void AddEngine();

        public abstract void AddDoors();

        public override string ToString()
        {
            return $"Car Type: {Type} - Engine Size: {EngineSize} - Colour: {Colour} - Doors: {Doors} - Seats: {Seats}";
        }
    }
}
