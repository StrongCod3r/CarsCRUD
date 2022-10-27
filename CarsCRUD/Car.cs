using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsCRUD.Interfaces;

namespace CarsCRUD
{
    public class Car : ICar
    {
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
