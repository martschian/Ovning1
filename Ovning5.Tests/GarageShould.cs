namespace Ovning5.Tests
{
    public class GarageShould
    {
        internal Garage<Vehicle> garage;
        internal Vehicle? car;
        public GarageShould()
        {
            garage = new Garage<Vehicle>(capacity: 10);

            //garage.ParkVehicle(new Car("blue", "BMW", "M3", 2));
            //garage.ParkVehicle(new Car("white", "Lexus", "G4", 2));
            //garage.ParkVehicle(new Car("brown", "Honda", "Accord", "auw193", 4));
            //garage.ParkVehicle(new Car("brown", "Lancia", "Delta", "IJU009", 2));
            //garage.ParkVehicle(new Car("brown", "Nissan", "Altima", "OEA232", 2));
            //garage.ParkVehicle(new Car("silver", "Toyota", "Corolla", "MML103", 2));
            //garage.ParkVehicle(new Car("black", "Citroen", "Xavia", 5));
            //garage.ParkVehicle(new Car("midnight", "Ferrari", "430", 2));
            //garage.ParkVehicle(new Car("maroon", "Saab", "9-5", 4));
            //garage.ParkVehicle(new Car("oilslick", "Renault", "Vivo", 6));

            //car = new Car("red", "Volvo", "740GLE", "MAG545", 4);
        }

        [Fact]
        public void HaveAMaxCapacity()
        {
            // Arrange
            var expected = 10;

            // Act
            var actual = garage.Capacity;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddVehicle()
        {
            var (actual, _) = garage.AddVehicle(new Car("red", "Volvo", "740GLE", "ABC123", 4));

            Assert.True(actual);
            Assert.Equal(1, garage.Count);
        }

        [Fact]
        public void FindVehicleByRegistrationNumber()
        {
            car = new Car("red", "Volvo", "740GLE", "MAG545", 4);
            _ = garage.AddVehicle(car);
            var actual = garage.GetVehicle("MAG545");

            Assert.Equal(car, actual);
        }

        [Fact]
        public void ReturnNullIfRetrieveVehicleByRegistrationNumberFails()
        {
            _ = garage.AddVehicle(new Car("red", "Volvo", "740GLE", "MAJ545", 4));
            var actual = garage.GetVehicle("ABC345");

            Assert.Null(actual);
        }

        [Fact]
        public void ReturnAListOfAllVehicles()
        {
            var car = new Car("red", "Volvo", "740GLE", "MAK545", 4);
            var car2 = new Car("White", "Saab", "9000", "MAI545", 4);
            var expected = new List<Vehicle>()
            {
                car,
                car2
            };

            //car = ;
            _ = garage.AddVehicle(car2);
            //expected.Add(car);

            //car = ;
            _ = garage.AddVehicle(car);
            //expected.Add(car);


            var actual = garage.GetAllVehicles();

            Assert.Equal(expected.OrderByDescending(x => x.RegistrationNumber), 
                         actual.OrderByDescending(x => x.RegistrationNumber));

        }

    }
}