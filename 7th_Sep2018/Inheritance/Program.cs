using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{

    public class Vehicle
    {
        public string name;
        public int wheels;
        public int seats;
        private string oiltype;

        public Vehicle()
        {
            name = null;
            wheels = 0;
            seats = 0;
            
            Console.WriteLine("\nthis is base class Constructor and\n initial values name: {0}\t wheels: {1}\tseats: {2}\toiltype: {3}", name, wheels, seats, oiltype + "\n**************\n");
        }
        public void getOiltype(string oiltype)
        {
            this.oiltype = oiltype;
        }

        
    }
    class Car : Vehicle
    {

        public void DisplayCar()
        {
            name = "Car";
            wheels = 4;
            seats = 5;
            Console.WriteLine("\nthis is Car: ");
            Console.WriteLine("and  values name: {0}\t wheels: {1}\tseats: {2}\toiltype: ", name, wheels, seats  +"\n*****************************");
            getOiltype("xyz");
        }
    }

    //*****has a****
    class Truck
    {
        Vehicle vehicle = new Vehicle();
        public void DisplayTruck()
        {
            Console.WriteLine("\nThis is truck class ");
            vehicle.name = "truck";
            vehicle.getOiltype("diesel");
            vehicle.seats = 2;
            vehicle.wheels = 8;
            Console.WriteLine(" values name: {0}\t wheels: {1}\tseats: {2}\toiltype: ", vehicle.name, vehicle.wheels, vehicle.seats );
            vehicle.getOiltype("asdasd");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
           
            c.DisplayCar();

            Truck t = new Truck();

            t.DisplayTruck();

            Console.ReadKey();
        }
    }
}
