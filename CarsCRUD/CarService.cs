using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsCRUD.Interfaces;

namespace CarsCRUD
{
    public class CarService : ICarService
    {
        public bool CheckPlate(string plate)
        {
            return true;
        }
        public bool CheckBrand(string brand) 
        {
            return true;
        }

        public bool CheckModel(string model)
        {
            return true;
        }  
    }
}
