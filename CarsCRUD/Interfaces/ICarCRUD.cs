using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsCRUD.Interfaces
{
    public interface ICarCRUD
    {
        public bool Create(ICar car);
        public ICar Read(string plate);
        public bool Update(ICar car);
        public bool Delete(ICar car);
    }
}
