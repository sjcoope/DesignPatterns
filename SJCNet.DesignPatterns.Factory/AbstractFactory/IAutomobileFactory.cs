using SJCNet.DesignPatterns.Factory.Shared;

namespace SJCNet.DesignPatterns.Factory.AbstractFactory
{
    public interface IAutomobileFactory
    {
        IMotorbike CreateMotorbike(MotorbikeTypes type);

        IVan CreateVan(VanTypes type);

        ICar CreateCar(CarTypes type);
    }
}