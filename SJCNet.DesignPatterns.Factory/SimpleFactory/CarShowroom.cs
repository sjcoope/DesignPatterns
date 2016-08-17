using SJCNet.DesignPatterns.Factory.Shared;
using SJCNet.DesignPatterns.Shared.Utility;

namespace SJCNet.DesignPatterns.Factory.SimpleFactory
{
    public class CarShowroom
    {
        ICarFactory _factory;

        public CarShowroom(ICarFactory factory)
        {
            _factory = factory;
        }

        public ICar OrderCar(CarTypes type)
        {
            Logger.Write($"Order placed for {type} car.");

            var car =  _factory.CreateCar(type);

            car.AddColour();
            car.AddDoors();
            car.AddEngine();
            car.AddSeats();

            return car;
        }
    }
}
