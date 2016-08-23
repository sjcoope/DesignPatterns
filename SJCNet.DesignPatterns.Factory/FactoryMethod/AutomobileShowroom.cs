using SJCNet.DesignPatterns.Factory.Shared;
using SJCNet.DesignPatterns.Shared.Utility;

namespace SJCNet.DesignPatterns.Factory.FactoryMethod
{
    public abstract class AutomobileShowroom
    {
        public ICar OrderCar(CarTypes type)
        {
            Logger.Write($"Order placed for {type} car.");

            var car = CreateCar(type);

            car.PerformValet();
            car.PerformService();
            car.AddFuel();

            Logger.Write($"Order completed with car: {car.ToString()}");

            return car;
        }

        protected abstract ICar CreateCar(CarTypes type);
    }
}
