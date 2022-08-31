using System;

namespace MyApplication

{
    public class Truck : Vehicle //derived class
    {
        public float maxLoadCap;
        public int axelNo;
        public int wheelNo;

    }


    public Truck(int maxLoadCap, int axelNo, int wheelNo) : Vehicle()
    {
        this.maxLoadCap = maxLoadCap;
        this.axelNo = axelNo;
        this.wheelNo = wheelNo;


        {
            static void Main(string[] args)
            //Create an object of Truck class here and pass truck details to the constructor
            Truck truck1 = new truck(42.5, 8, 32);
            Console.WriteLine("Truck maximum load capacity is: {0} \n, Number of axel is: {1} \n, Number of wheels is: {2} \n");
        }
    }
}
