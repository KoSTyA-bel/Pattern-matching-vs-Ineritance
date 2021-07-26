using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Transport
{
    public class Bus : IVehicle
    {
        private int _capacity;
        private int _riders;

        public Bus(int capacity, int riders)
        {
            this.Capacity = capacity;
            this.Riders = riders;
        }

        public int Capacity
        {
            get => _capacity;
            set => _capacity = value > 0 ? value : throw new ArgumentException("Value should be more zero.", nameof(value));
    }
        public int Riders
        {
            get => _riders;
            set => _riders = value >= 0 ? value : throw new ArgumentException("Value should be more or equal zero.", nameof(value));
        }

        public decimal CalculateToll() =>
            ((double)_riders / (double)_capacity) switch
            {
                double coef when (coef < 0.50) => 5.00m + 2.00m,
                double coef when (coef > 0.90) => 5.00m - 1.00m,
                _ => 5.00m,
            };
    }
}
