using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace CarsCRUD.Interfaces
{
    public interface ICarRepository
    {
        public bool Create(ICar car);
        public ICar Read(string plate);
        public bool Update(ICar ccar);
        public bool Delete(ICar ccar);

    }
}
