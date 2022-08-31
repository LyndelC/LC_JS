using System;

namespace MyApplication


{
    public class Car : Vehicle      // derived class
    {

        public string bodyType;     // car fields
        public string carColour;
        public string upholstery;
        public int doorNo;

    }


    public Car(string bodyType, string carColour, string upholstery, int doorNo,) : Vehicle()
    {
        this.bodyType = bodyType;
        this.carColour = carColour;
        this.upholstery = upholstery;
        this.doorNo = doorNo;


    }
    static void Main(string[] args)
    { 
    //Create an object of Car class here and pass a car name and details to the constructor
    Car car1 = new Car("Station wagon", "Red", "Fabric", 5);
    Console.WriteLine("Body type is: {0} \n, Car colour is: {1} \n, Upholstery type is: {2} \n, Number of car doors is: {3} \n");
    }
}

