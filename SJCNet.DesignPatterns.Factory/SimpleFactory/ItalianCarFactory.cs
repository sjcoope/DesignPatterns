﻿using SJCNet.DesignPatterns.Factory.Shared;

namespace SJCNet.DesignPatterns.Factory.SimpleFactory
{
    public class ItalianCarFactory : ICarFactory
    {
        public ICar CreateCar(CarTypes type)
        {
            Car car = null;

            switch (type)
            {
                case CarTypes.Saloon:
                    car = new SaloonCar();
                    break;
                case CarTypes.Hatchback:
                    car = new HatchbackCar();
                    break;
                case CarTypes.MPV:
                    car = new MPVCar();
                    break;
                default: // Coupe
                    car = new CoupeCar();
                    break;
            }

            // Who needs safety checks?
            
            return car;
        }
    }
}