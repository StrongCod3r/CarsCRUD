using CarsCRUD;
using CarsCRUD.Interfaces;

ICarCRUD carCRUD = new CarCRUD();

ICar car = new Car
{
    Plate = "1234ABC",
    Brand = "Opel",
    Model = "Corsa"
};


bool result = carCRUD.Create(car);

Console.WriteLine("Result: " + (result? "OK": "KO"));
