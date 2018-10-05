namespace SJCNet.DesignPatterns.Factory.Old.Shared
{
    public interface IMotorbike : IAutomobile
    {
        MotorbikeTypes Type { get; }
    }
}