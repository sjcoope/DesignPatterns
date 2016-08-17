using SJCNet.DesignPatterns.Factory.Shared;
using SJCNet.DesignPatterns.Shared.Utility;

namespace SJCNet.DesignPatterns.Factory.FactoryMethod
{
    public abstract class CarShowroom
    {
        public ICar OrderCar(CarTypes type)
        {
            Logger.Write($"Order placed for {type} car.");

            var car = CreateCar(type);

            car.AddDoors();
            car.AddColour();
            car.AddEngine();
            car.AddSeats();

            return car;
        }

        protected abstract ICar CreateCar(CarTypes type);
    }
}
