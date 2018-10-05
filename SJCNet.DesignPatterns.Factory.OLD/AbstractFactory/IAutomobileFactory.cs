using SJCNet.DesignPatterns.Factory.Old.Shared;

namespace SJCNet.DesignPatterns.Factory.Old.AbstractFactory
{
    public interface IAutomobileFactory
    {
        IMotorbike CreateMotorbike(MotorbikeTypes type);

        IVan CreateVan(VanTypes type);

        ICar CreateCar(CarTypes type);
    }
}