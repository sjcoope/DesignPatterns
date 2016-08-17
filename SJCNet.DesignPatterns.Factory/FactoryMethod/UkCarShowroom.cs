﻿using SJCNet.DesignPatterns.Factory.Shared;
using SJCNet.DesignPatterns.Shared.Utility;

namespace SJCNet.DesignPatterns.Factory.FactoryMethod
{
    public class UkCarShowroom : CarShowroom
    {
        protected override ICar CreateCar(CarTypes type)
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

            PerformSafetyChecks(car);
            PerformCrashTests(car);

            return car;
        }

        private void PerformSafetyChecks(ICar car)
        {
            Logger.Write($"Performing safety checks for {car.Type} car.");
        }

        private void PerformCrashTests(ICar car)
        {
            Logger.Write($"Performing crash tests for {car.Type} car.");
        }
    }
}