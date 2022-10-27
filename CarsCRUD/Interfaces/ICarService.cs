using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsCRUD.Interfaces
{
    public interface ICarService
    {
        public bool CheckPlate(string plate);
        public bool CheckBrand(string brand);
        public bool CheckModel(string model);
    }
}
