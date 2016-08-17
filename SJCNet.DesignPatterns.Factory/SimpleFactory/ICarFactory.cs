using SJCNet.DesignPatterns.Factory.Shared;

namespace SJCNet.DesignPatterns.Factory.SimpleFactory
{
    public interface ICarFactory
    {
        ICar CreateCar(CarTypes type);
    }
}