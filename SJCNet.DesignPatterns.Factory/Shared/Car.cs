namespace SJCNet.DesignPatterns.Factory.Shared
{
    public class Car : Automobile, ICar
    {
        public Car(CarTypes type, int engineSize, Colours colour, int doors, int seats) : base(engineSize, colour, doors, seats)
        {
            this.Type = type;
        }

        public override string Name
        {
            get { return $"Car: {Type}"; }
        }

        public CarTypes Type { get; private set; }
    }
}
