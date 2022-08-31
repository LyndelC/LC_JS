using System;

namespace MyApplication

public class Vehicle // Base class
{
    public string rego;
    public string make;
    public string model;
    public int kmDriven;
    Driver driver;

    public Vehicle(string rego, string make, string model, int kmDriven, Driver driver)
    {
        //this.rego = rego;
        //this.make = make;
        //this.model = model;
        //this.kmDriven = kmDriven;
        //this.driver = driver;



        {
            //Create an object of Vehicle class here and pass vehicle details to the constructor
            Vehicle vehicle1 = new Vehicle(1ABC777, "Holden", "Commodore", 123656);
            Console.WriteLine("Registration {0} \n, Make {1} \n, Model {2} \n, Km Driven {3} \n", this.rego, this.make, this.model, this.kmDriven);
        }
	}
}



