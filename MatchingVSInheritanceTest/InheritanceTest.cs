using System;
using Inheritance;
using Inheritance.Transport;
using Inhetitance;
using NUnit.Framework;

namespace MatchingVSInheritanceTest
{
    [TestFixture]
    public class InheritanceTest
    {
        private TollCalculator calculator = new TollCalculator();
        private int[] passengersAndFares = new int[] { 0, 1, 2, 3, 12453 };
        private int[] riders = new int[] { 1, 1, 1 };
        private int[] capacity = new int[] { 1, 2, 3 };
        private int[] weight = new int[] { 5001, 2999, 5000 };
        private decimal[] expectedResCar = new decimal[] { 2.00m + 0.5m, 2.0m, 2.0m - 0.5m, 2.00m - 1.0m, 2.00m - 1.0m };
        private decimal[] expectedResTaxi = new decimal[] { 3.50m + 1.00m, 3.50m, 3.50m - 0.50m, 3.50m - 1.00m, 3.50m - 1.00m };
        private decimal[] expectedResBus = new decimal[] { 5.00m - 1.00m, 5.00m, 5.00m + 2.00m };
        private decimal[] expectedResTruck = new decimal[] { 10.00m + 5.00m, 10.00m - 2.00m, 10.00m };

        [Test]
        public void CarTest()
        {
            for (int i = 0; i < passengersAndFares.Length; i++)
            {
                var car = new Car(passengersAndFares[i]);
                Assert.AreEqual(expectedResCar[i], calculator.CalculateToll(car));
            }
        }

        [Test]
        public void TaxiTest()
        {
            for (int i = 0; i < passengersAndFares.Length; i++)
            {
                var taxi = new Taxi(passengersAndFares[i]);
                Assert.AreEqual(expectedResTaxi[i], calculator.CalculateToll(taxi));
            }
        }

        [Test]
        public void BusTest()
        {
            for (int i = 0; i < riders.Length; i++)
            {
                var bus = new Bus(capacity[i], riders[i]);
                Assert.AreEqual(expectedResBus[i], calculator.CalculateToll(bus));
            }
        }

        [Test]
        public void TruckTest()
        {
            for (int i = 0; i < weight.Length; i++)
            {
                var truck = new DeliveryTruck(weight[i]);
                Assert.AreEqual(expectedResTruck[i], calculator.CalculateToll(truck));
            }
        }

        [Test]
        public void NullTest()
        {
            Assert.Throws<ArgumentNullException>(() => calculator.CalculateToll(null));
        }

        [Test]
        public void ArgumentExceptionInCarAndTaxiTest()
        {
            Assert.Throws<ArgumentException>(() => new Car(-1));
            Assert.Throws<ArgumentException>(() => new Taxi(-1));
        }
    }
}
