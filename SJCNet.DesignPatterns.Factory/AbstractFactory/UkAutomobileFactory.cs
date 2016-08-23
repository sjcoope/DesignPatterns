using SJCNet.DesignPatterns.Factory.Shared;
using SJCNet.DesignPatterns.Shared.Utility;

namespace SJCNet.DesignPatterns.Factory.AbstractFactory
{
    public class UkAutomobileFactory : IAutomobileFactory
    {
        public ICar CreateCar(CarTypes type)
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

        public IMotorbike CreateMotorbike(MotorbikeTypes type)
        {
            Motorbike motorbike;

            switch (type)
            {
                case MotorbikeTypes.Chopper:
                    motorbike = new Motorbike(MotorbikeTypes.Chopper, 400, Colours.Black, 0, 1);
                    break;
                case MotorbikeTypes.Scooter:
                    motorbike = new Motorbike(MotorbikeTypes.Scooter, 60, Colours.Yellow, 0, 1);
                    break;
                default:
                    motorbike = new Motorbike(MotorbikeTypes.Tourer, 1000, Colours.Red, 0, 1);
                    break;
            }

            PerformSafetyChecks(motorbike);
            PerformCrashTests(motorbike);

            return motorbike;
        }

        public IVan CreateVan(VanTypes type)
        {
            Van van;

            switch (type)
            {
                case VanTypes.Box:
                    van = new Van(VanTypes.Luton, 1800, Colours.White, 3, 2);
                    break;
                case VanTypes.Flatbed:
                    van = new Van(VanTypes.Luton, 1800, Colours.White, 2, 3);
                    break;
                default:
                    van = new Van(VanTypes.Luton, 1800, Colours.White, 4, 3);
                    break;
            }

            PerformSafetyChecks(van);
            PerformCrashTests(van);

            return van;
        }

        private void PerformSafetyChecks(IAutomobile automobile)
        {
            Logger.Write($"Performing safety checks for {automobile.Name} in AbstractFactory.UkAutomobileFactory.");
        }

        private void PerformCrashTests(IAutomobile automobile)
        {
            Logger.Write($"Performing crash tests for {automobile.Name} in AbstractFactory.UkAutomobileFactory.");
        }
    }
}
