using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsCRUD.Interfaces;

namespace CarsCRUD
{
    public class CarCRUD : ICarCRUD
    {
        private readonly ICarService carService;
        private readonly ICarRepository carRepository;

        public CarCRUD() 
        {
            this.carService = new CarService();
            this.carRepository = new CarRepository();
        }

        public bool Create(ICar car)
        {
            bool result = this.carService.CheckBrand(car.Brand);

            if (result)
            {
                return this.carRepository.Create(car);
            }

            return result;
        }

        public bool Delete(ICar car)
        {
            throw new NotImplementedException();
        }

        public ICar Read(string plate)
        {
            throw new NotImplementedException();
        }

        public bool Update(ICar car)
        {
            throw new NotImplementedException();
        }
    }
}
