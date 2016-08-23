namespace SJCNet.DesignPatterns.Factory.Shared
{
    public interface ICar : IAutomobile
    {
        CarTypes Type { get; }
    }
}