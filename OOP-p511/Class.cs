using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{
    internal abstract class Transport
    {
        protected double speed;
        protected double costPerKm;
        protected int passengerCapasity;
        protected double cargoCapacity;

        protected Transport(double speed, double costPerKm, int passengerCapasity, double cargoCapacity)
        {
            this.speed = speed;
            this.costPerKm = costPerKm;
            this.passengerCapasity = passengerCapasity;
            this.cargoCapacity = cargoCapacity;
        }

        public abstract double CalculateTime(double distance);
        public abstract double CalculateCostPerKm(double distance, int passenger, double cargo);
    }

    internal class Car : Transport
    {
        public Car() : base(80, 15, 4, 0.5) { }

        public override double CalculateTime(double distance)
        {
            return distance / speed;
        }

        public override double CalculateCostPerKm(double distance, int passenger, double cargo)
        {
            if (passenger > 4 || passenger < 0)
            {
                return 0;
            }
            else
            {

                return (distance * costPerKm) + (passenger * 100) + (cargo + 500);
            }
        }
    }

    internal class Cart : Transport
    {
        public Cart() : base(50, 5, 8, 0.3) { }

        public override double CalculateTime(double distance)
        {
            return distance / speed;
        }

        public override double CalculateCostPerKm(double distance, int passenger, double cargo)
        {
            if (passenger > 8 || passenger < 0)
            {
                return 0;
            }
            else
            {

                return (distance * costPerKm) + (passenger * 100) + (cargo + 500);
            }
        }
    }

    internal class Bike : Transport
    {
        public Bike() : base(15, 5, 2, 0.02) { }

        public override double CalculateTime(double distance)
        {
            return distance / speed;
        }

        public override double CalculateCostPerKm(double distance, int passenger, double cargo)
        {
            if (passenger > 2 || passenger < 0)
            {
                return 0;
            }
            else
            {

                return (distance * costPerKm) + (passenger * 100) + (cargo + 500);
            }
        }
    }
}
