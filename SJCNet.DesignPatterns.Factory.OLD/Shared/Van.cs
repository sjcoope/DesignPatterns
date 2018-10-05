using System;

namespace SJCNet.DesignPatterns.Factory.Old.Shared
{
    public class Van : Automobile, IVan
    {
        public Van(VanTypes type, int engineSize, Colours colour, int doors, int seats) : base(engineSize, colour, doors, seats)
        {
            this.Type = type;
        }

        public override string Name
        {
            get { return $"Van: {Type}"; }
        }

        public VanTypes Type { get; private set; }
    }
}
