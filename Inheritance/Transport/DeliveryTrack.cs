using Inheritance.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhetitance
{
    public class DeliveryTruck : IVehicle
    {
        private int _grossWeightClass;

        public DeliveryTruck(int grossWeightClass)
        {
            this.GrossWeightClass = grossWeightClass;
        }

        public int GrossWeightClass
        {
            get => _grossWeightClass;
            set => _grossWeightClass = value > 0 ? value : throw new ArgumentException("Value should be more zero.", nameof(value));
        }

        public decimal CalculateToll() =>
            _grossWeightClass switch
            {
                int when (_grossWeightClass > 5000) => 10.00m + 5.00m,
                int when (_grossWeightClass < 5000) => 10.00m - 2.00m,
                _ => 10.00m,
            };
    }
}
