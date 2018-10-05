using SJCNet.DesignPatterns.Shared.Utility.Old;
using SJCNet.DesignPatterns.Factory.Shared;
using SJCNet.DesignPatterns.Shared.Contracts.Old;

namespace SJCNet.DesignPatterns.Factory
{
    public class Example : IExample
    {
        public void Execute()
        {
            Logger.WriteSubHeader("Simple Factory Implementation");
            ExecuteSimpleFactoryExample();
            
            Logger.WriteSubHeader("Factory Method Implementation");
            ExecuteFactoryMethodExample();

            Logger.WriteSubHeader("Abstract Factory Implementation");
            ExecuteAbstractFactoryExample();
        }

        private void ExecuteAbstractFactoryExample()
        {
            var ukAutomobileFactory = new AbstractFactory.UkAutomobileFactory();
            var ukAutomobileShowroom = new AbstractFactory.AutomobileShowroom(ukAutomobileFactory);
            var ukCar = ukAutomobileShowroom.OrderCar(CarTypes.Hatchback);
            Logger.AddLineBreak();

            var ukMotorbike = ukAutomobileShowroom.OrderMotorbike(MotorbikeTypes.Chopper);
            Logger.AddLineBreak();

            var italianAutomobileFactory = new AbstractFactory.ItalianAutomobileFactory();
            var italianAutomobileShowroom = new AbstractFactory.AutomobileShowroom(italianAutomobileFactory);
            var italianCar = italianAutomobileShowroom.OrderCar(CarTypes.Saloon);
            Logger.AddLineBreak();

            var italianMotorboke = italianAutomobileShowroom.OrderMotorbike(MotorbikeTypes.Scooter);
            Logger.AddLineBreak();
        }

        private void ExecuteFactoryMethodExample()
        {
            var ukAutomobileShowroom = new FactoryMethod.UkAutomobileShowroom();
            var ukCar = ukAutomobileShowroom.OrderCar(CarTypes.Saloon);
            Logger.AddLineBreak();

            var italianAutomobileShowroom = new FactoryMethod.ItalianAutomobileShowroom();
            var italianCar = italianAutomobileShowroom.OrderCar(CarTypes.Mpv);
            Logger.AddLineBreak();
        }

        private void ExecuteSimpleFactoryExample()
        {
            var simpleFactory = new SimpleFactory.AutomobileFactory();
            var automobileShowroom = new SimpleFactory.AutomobileShowroom(simpleFactory);
            var car = automobileShowroom.OrderCar(CarTypes.Mpv);
            Logger.AddLineBreak();
        }
    }
}
