using System;

namespace SJCNet.DesignPatterns.Factory.Shared
{
    public class Motorbike : Automobile, IMotorbike
    {
        public Motorbike(MotorbikeTypes type, int engineSize, Colours colour, int doors, int seats) : base(engineSize, colour, doors, seats)
        {
            this.Type = type;
        }
        
        public override string Name
        {
            get { return $"Motorbike: {Type}"; }
        }
        
        public MotorbikeTypes Type { get; private set; }
    }
}
