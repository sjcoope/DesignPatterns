using SJCNet.DesignPatterns.Shared.Utility.Old;

namespace SJCNet.DesignPatterns.Factory.Shared
{
    public abstract class Automobile : IAutomobile
    {
        public Automobile(int engineSize, Colours colour, int doors, int seats)
        {
            this.EngineSize = engineSize;
            this.Colour = colour;
            this.Doors = doors;
            this.Seats = seats;
        }

        public abstract string Name { get; }
        
        public int EngineSize { get; protected set; }

        public Colours Colour { get; protected set; }

        public int Doors { get; protected set; }

        public int Seats { get; protected set; }
        public void PerformValet()
        {
            Logger.Write($"Performing valet for {Name}.");
        }

        public void PerformService()
        {
            Logger.Write($"Performing service for {Name}.");
        }

        public void AddFuel()
        {
            Logger.Write($"Adding fuel for {Name}.");
        }
        
        public override string ToString()
        {
            return $"{Name} - Engine Size: {EngineSize} - Colour: {Colour} - Doors: {Doors} - Seats: {Seats}";
        }

    }
}
