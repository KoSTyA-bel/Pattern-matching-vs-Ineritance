using Inheritance.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhetitance
{
    public class Taxi : IVehicle
    {
        private int _fares;

        public Taxi(int fares)
        {
            Fares = fares;
        }

        public int Fares
        {
            get => _fares;
            set => _fares = value >= 0 ? value : throw new ArgumentException("Value should be more or equal zero.", nameof(value));
        }

        public decimal CalculateToll() =>
            _fares switch
            {
                0 => 3.50m + 1.00m,
                1 => 3.50m,
                2 => 3.50m - 0.50m,
                _ => 3.50m - 1.00m,
            };
    }
}
