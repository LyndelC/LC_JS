using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApplication
{
      
    class Program
    {
        static void Main(string[] args)
        {

            //Create an object of Driver class here and pass a name and age to the constructor
            Driver driver1 = new Driver("VIC1234567", "John", "Doe", 0412345678, "1 Station Street", "Hometown", "VIC", 1234, "Victoria : NSW : Qld", 6);

            //Create an object of  Vehicle class here and pass a car make, model and the Driver object to the constructor
            Vehicle car2 = new Vehicle("1AB123", "Toyota", "Corolla", 52065, driver1);

            //Create an object of Car class here and pass a body type, car colour, upholstery type and number of doors to the constructor
            Car myCar = new Car("Sedan", "Blue", "Cloth", 5);
                
            //for the Vehicle object here
            //car1.Display();

           

        }

    }
}