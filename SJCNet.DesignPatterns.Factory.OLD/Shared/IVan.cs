namespace SJCNet.DesignPatterns.Factory.Old.Shared
{
    public interface IVan : IAutomobile
    {
        VanTypes Type { get; }
    }
}