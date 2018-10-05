using SJCNet.DesignPatterns.Factory.Old.Shared;

namespace SJCNet.DesignPatterns.Factory.Old.AbstractFactory
{
    public class ItalianAutomobileFactory : IAutomobileFactory
    {
        public ICar CreateCar(CarTypes type)
        {
            Car car;

            // Italians like red cars right?
            switch (type)
            {
                case CarTypes.Saloon:
                    car = new Car(CarTypes.Saloon, 2100, Colours.Red, 5, 5);
                    break;
                case CarTypes.Hatchback:
                    car = new Car(CarTypes.Hatchback, 2300, Colours.Red, 3, 4);
                    break;
                default:
                    car = new Car(CarTypes.Mpv, 3000, Colours.Red, 5, 8);
                    break;
            }

            // Who needs safety checks?

            return car;
        }

        public IMotorbike CreateMotorbike(MotorbikeTypes type)
        {
            Motorbike motorbike;

            // Italians like yellow motorbikes right?
            switch (type)
            {
                case MotorbikeTypes.Chopper:
                    motorbike = new Motorbike(MotorbikeTypes.Chopper, 400, Colours.Yellow, 0, 1);
                    break;
                case MotorbikeTypes.Scooter:
                    motorbike = new Motorbike(MotorbikeTypes.Scooter, 60, Colours.Yellow, 0, 1);
                    break;
                default:
                    motorbike = new Motorbike(MotorbikeTypes.Tourer, 1000, Colours.Yellow, 0, 1);
                    break;
            }

            // Who needs safety checks?

            return motorbike;
        }

        public IVan CreateVan(VanTypes type)
        {
            Van van;

            // Italians like blue vans right?
            switch (type)
            {
                case VanTypes.Box:
                    van = new Van(VanTypes.Luton, 1800, Colours.Blue, 3, 2);
                    break;
                case VanTypes.Flatbed:
                    van = new Van(VanTypes.Luton, 1800, Colours.Blue, 2, 3);
                    break;
                default:
                    van = new Van(VanTypes.Luton, 1800, Colours.Blue, 4, 3);
                    break;
            }

            // Who needs safety checks?

            return van;
        }
    }
}
