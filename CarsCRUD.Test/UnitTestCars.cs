using CarsCRUD.Interfaces;

namespace CarsCRUD.Test.xUnit
{
    public class UnitTestCars
    {
        public readonly ICarService carService;
        public UnitTestCars() 
        { 
            this.carService = new CarService();
        }

        [Theory]
        [InlineData("1234XXX")]
        public void PassingPlate(string plate)
        {
            bool result = this.carService.CheckPlate(plate);

            Assert.True(result);
        }

        [Theory]
        [InlineData("XXX01234")]
        public void FallingPlate(string plate)
        {
            bool result = this.carService.CheckPlate(plate);

            Assert.False(result);
        }

    }
}