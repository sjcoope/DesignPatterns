using SJCNet.DesignPatterns.Factory.Shared;

namespace SJCNet.DesignPatterns.Factory.Shared
{
    public class SaloonCar : Car
    {
        public override CarTypes Type => CarTypes.Saloon;

        public override void AddColour()
        {
            this.Colour = Colours.Red;
        }

        public override void AddEngine()
        {
            this.EngineSize = 2200;
        }

        public override void AddSeats()
        {
            this.Seats = 5;
        }

        public override void AddDoors()
        {
            this.Doors = 5;
        }
    }
}