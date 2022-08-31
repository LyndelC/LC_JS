using System;

namespace MyApplication

{
    public class Driver
    {
        public string licenseNo;
        public string firstName;
        public string lastName;
        public int mobile;
        public string driverStreet;
        public string driverCity;
        public string driverState;
        public int driverPcode;
        public string licenseStates;
        public int demeritPoints;

        public Driver(string licenseNo, string firstName, string lastName, int mobile, string driverStreet, string driverCity, string driverState, int driverPcode, string licenseStates, int demeritPoints)
        {
            this.licenseNo = licenseNo;
            this.firstName = firstName;
            this.lastName = lastName;
            this.mobile = mobile;
            this.driverStreet = driverStreet;
            this.driverCity = driverCity;
            this.driverState = driverState;
            this.driverPcode = driverPcode;
            this.licenseStates = licenseStates;
            this.demeritPoints = demeritPoints;

        }
         static void Main(string[] args)
        {
            //Create an object of Driver class here and pass a name and age to the constructor
            Driver driver1 = new Driver("VIC1234567", "John", "Doe", 0412345678, "1 Station Street", "Hometown", "VIC", 1234, "Victoria : NSW : Qld", 6);

            Console.WriteLine("Driver name: {1} + " " + {2} \n, License Number: {0} \n, Mobile: {3} \n, Street: {4} \n, City: {5} \n, State: {6} \n, Postcode: {7}\n, Licensed in States: {8} \n, Demerit Points; {9} \n ", this.driver.firstName, this.driver.lastName, this.driver.licenseNo, this.driver.mobile, this, this.driver.driverStreet, this.driver.driverCity, this.driver.driverState, this.driver.driverPcode, this.driver.licenseStates, this.driver.demeritPoints);
        }
    }
}
