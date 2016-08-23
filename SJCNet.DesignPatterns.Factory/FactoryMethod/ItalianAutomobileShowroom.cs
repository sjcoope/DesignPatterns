using SJCNet.DesignPatterns.Factory.Shared;

namespace SJCNet.DesignPatterns.Factory.FactoryMethod
{
    public class ItalianAutomobileShowroom : AutomobileShowroom
    {
        protected override ICar CreateCar(CarTypes type)
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
    }
}
