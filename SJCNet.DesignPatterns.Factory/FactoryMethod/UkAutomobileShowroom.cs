using SJCNet.DesignPatterns.Factory.Shared;
using SJCNet.DesignPatterns.Shared.Utility.Old;

namespace SJCNet.DesignPatterns.Factory.FactoryMethod
{
    public class UkAutomobileShowroom : AutomobileShowroom
    {
        protected override ICar CreateCar(CarTypes type)
        {
            Car car;

            switch (type)
            {
                case CarTypes.Saloon:
                    car = new Car(CarTypes.Saloon, 2100, Colours.Red, 5, 5);
                    break;
                case CarTypes.Hatchback:
                    car = new Car(CarTypes.Hatchback, 2300, Colours.Blue, 3, 4);
                    break;
                default:
                    car = new Car(CarTypes.Mpv, 3000, Colours.Yellow, 5, 8);
                    break;
            }

            PerformSafetyChecks(car);
            PerformCrashTests(car);

            return car;
        }

        private void PerformSafetyChecks(ICar car)
        {
            Logger.Write($"Performing safety checks for {car.Name} in FactoryMethod.UkAutomobileShowroom.");
        }

        private void PerformCrashTests(ICar car)
        {
            Logger.Write($"Performing crash tests for {car.Name} in FactoryMethod.UkAutomobileShowroom.");
        }
    }
}
