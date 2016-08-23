using SJCNet.DesignPatterns.Factory.Shared;
using SJCNet.DesignPatterns.Shared.Utility;

namespace SJCNet.DesignPatterns.Factory.AbstractFactory
{
    public class AutomobileShowroom
    {
        readonly IAutomobileFactory _factory;

        public AutomobileShowroom(IAutomobileFactory factory)
        {
            _factory = factory;
        }

        public ICar OrderCar(CarTypes type)
        {
            Logger.Write($"Order placed for {type} car.");

            var car = _factory.CreateCar(type);

            car.PerformValet();
            car.PerformService();
            car.AddFuel();

            Logger.Write($"Order completed with car: {car.ToString()}");

            return car;
        }

        public IVan OrderVan(VanTypes type)
        {
            Logger.Write($"Order placed for {type} van.");

            var van = _factory.CreateVan(type);

            van.PerformValet();
            van.PerformService();
            van.AddFuel();

            Logger.Write($"Order completed with van: {van.ToString()}");

            return van;
        }

        public IMotorbike OrderMotorbike(MotorbikeTypes type)
        {
            Logger.Write($"Order placed for {type} motorbike.");

            var motorbike = _factory.CreateMotorbike(type);

            motorbike.PerformValet();
            motorbike.PerformService();
            motorbike.AddFuel();

            Logger.Write($"Order completed with motorbike: {motorbike.ToString()}");

            return motorbike;
        }
    }
}
