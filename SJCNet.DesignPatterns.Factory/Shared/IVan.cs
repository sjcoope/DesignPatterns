namespace SJCNet.DesignPatterns.Factory.Shared
{
    public interface IVan : IAutomobile
    {
        VanTypes Type { get; }
    }
}