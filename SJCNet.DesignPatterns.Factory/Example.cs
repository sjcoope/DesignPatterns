using SJCNet.DesignPatterns.Shared.Contracts;
using SJCNet.DesignPatterns.Shared.Utility;
using SJCNet.DesignPatterns.Factory.Shared;

namespace SJCNet.DesignPatterns.Factory
{
    public class Example : IExample
    {
        public void Execute()
        {
            Logger.WriteSubHeader("Simple Factory Implementation");

            var ukCarFactory = new SimpleFactory.UkCarFactory();
            var carShowroom1 = new SimpleFactory.CarShowroom(ukCarFactory);
            var ukCar1 = carShowroom1.OrderCar(CarTypes.Coupe);
            Logger.Write($"Car Ordered: {ukCar1.ToString()}");
            Logger.AddLineBreak();

            var italianCarFactory = new SimpleFactory.ItalianCarFactory();
            var carShowroom2 = new SimpleFactory.CarShowroom(italianCarFactory);
            var italianCar1 = carShowroom2.OrderCar(CarTypes.Hatchback);
            Logger.Write($"Car Ordered: {italianCar1.ToString()}");
            Logger.AddLineBreak();

            Logger.WriteSubHeader("Factory Method Implementation");

            var ukCarShowroom = new FactoryMethod.UkCarShowroom();
            var ukCar2 = ukCarShowroom.OrderCar(CarTypes.Saloon);
            Logger.Write($"Car Ordered: {ukCar2.ToString()}");
            Logger.AddLineBreak();

            var italianCarShowroom = new FactoryMethod.ItalianCarShowroom();
            var italianCar2 = italianCarShowroom.OrderCar(CarTypes.MPV);
            Logger.Write($"Car Ordered: {italianCar2.ToString()}");
            Logger.AddLineBreak();
        }
    }
}
