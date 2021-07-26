using Inheritance.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class TollCalculator
    {
        public decimal CalculateToll(IVehicle vehicle)
        {
            if (vehicle is null)
            {
                throw new ArgumentNullException();
            }

            return vehicle.CalculateToll();
        }
    }
}
