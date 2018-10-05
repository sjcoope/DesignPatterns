using SJCNet.DesignPatterns.Factory.Shared;
using SJCNet.DesignPatterns.Shared.Utility.Old;

namespace SJCNet.DesignPatterns.Factory.SimpleFactory
{
    public class AutomobileShowroom
    {
        readonly AutomobileFactory _factory;

        public AutomobileShowroom(AutomobileFactory factory)
        {
            _factory = factory;
        }

        public ICar OrderCar(CarTypes type)
        {
            Logger.Write($"Order placed for {type} car.");

            var car =  _factory.CreateCar(type);

            car.PerformService();
            car.PerformValet();
            car.AddFuel();

            Logger.Write($"Order completed with car: {car.ToString()}");

            return car;
        }
    }
}
