using SJCNet.DesignPatterns.Factory.Shared;

namespace SJCNet.DesignPatterns.Factory.Shared
{
    public class MPVCar : Car
    {
        public override CarTypes Type => CarTypes.MPV;

        public override void AddColour()
        {
            this.Colour = Colours.Yellow;
        }

        public override void AddDoors()
        {
            this.Doors = 5;
        }

        public override void AddEngine()
        {
            this.EngineSize = 1600;
        }

        public override void AddSeats()
        {
            this.Seats = 8;
        }
    }
}