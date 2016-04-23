﻿using SJCNet.DesignPatterns.Shared.Utility;

namespace SJCNet.DesignPatterns.CompositionOverInheritance.Composition.Behaviours
{
    public class YipBehaviour : IBarkBehaviour
    {
        public void Bark()
        {
            Logger.Write($"I am yipping");
        }
    }
}
