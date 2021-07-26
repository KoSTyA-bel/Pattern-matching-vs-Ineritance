using Inheritance.Transport;
using System;


namespace Inhetitance
{
    public class Car : IVehicle
    {
        private int _passengers;

        public Car(int passengers)
        {
            this.Passengers = passengers;
        }

        public int Passengers
        {
            get => _passengers;
            set => _passengers = value >= 0 ? value : throw new ArgumentException("Value should be more or equal zero.", nameof(value));
        }

        public decimal CalculateToll() =>
            _passengers switch
            {
                0 => 2.00m + 0.5m,
                1 => 2.0m,
                2 => 2.0m - 0.5m,
                _ => 2.00m - 1.0m,
            };
    }
}
