using System;
using SJCNet.DesignPatterns.Factory.Shared;

namespace SJCNet.DesignPatterns.Factory.Shared
{
    public class CoupeCar : Car
    {
        public override CarTypes Type => CarTypes.Coupe;

        public override void AddColour()
        {
            this.Colour = Colours.Blue;
        }

        public override void AddDoors()
        {
            this.Doors = 3;
        }

        public override void AddEngine()
        {
            this.EngineSize = 2000;
        }

        public override void AddSeats()
        {
            this.Seats = 2;
        }
    }
}