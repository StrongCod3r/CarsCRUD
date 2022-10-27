using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsCRUD.Interfaces;

namespace CarsCRUD
{
    public class CarRepository : ICarRepository
    {
        public bool Create(ICar car)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ICar ccar)
        {
            throw new NotImplementedException();
        }

        public ICar Read(string plate)
        {
            throw new NotImplementedException();
        }

        public bool Update(ICar ccar)
        {
            throw new NotImplementedException();
        }
    }
}
