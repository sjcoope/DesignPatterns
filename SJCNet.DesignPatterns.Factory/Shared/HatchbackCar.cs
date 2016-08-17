namespace SJCNet.DesignPatterns.Factory.Shared
{
    public class HatchbackCar : Car
    {
        public override CarTypes Type => CarTypes.Hatchback;

        public override void AddColour()
        {
            this.Colour = Colours.Black;
        }

        public override void AddDoors()
        {
            this.Doors = 3;
        }

        public override void AddEngine()
        {
            this.EngineSize = 1600;
        }

        public override void AddSeats()
        {
            this.Seats = 4;
        }
    }
}