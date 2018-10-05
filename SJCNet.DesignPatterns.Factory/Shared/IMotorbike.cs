namespace SJCNet.DesignPatterns.Factory.Shared
{
    public interface IMotorbike : IAutomobile
    {
        MotorbikeTypes Type { get; }
    }
}