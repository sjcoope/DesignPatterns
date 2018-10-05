namespace SJCNet.DesignPatterns.Factory.Old.Shared
{
    public interface ICar : IAutomobile
    {
        CarTypes Type { get; }
    }
}