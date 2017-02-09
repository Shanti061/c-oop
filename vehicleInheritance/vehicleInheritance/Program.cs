using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleInheritance
{

    class Vehicle
    {
        public string type;
        public string make;
        public string model;
        public int price;
        public Boolean sold;

        //making a constructor

        public Vehicle(string type, string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
        }

        public void SoldVehicle(bool isSold, int price)
        {
            this.sold = isSold;
            this.price = price;


        }

        public static void DisplayAllVehicles(List<Vehicle> allVehicles)
        {
            int totalValueSold = 0;
            int totalValueInStock = 0;

            Console.WriteLine("List and Details of the vehicles: ");

            foreach (Vehicle item in allVehicles)
            {

                Console.WriteLine("make and model : {0}  {1}, price: £{2}", item.make, item.model, item.price);
                if (item.sold)
                {
                    Console.WriteLine("sold");
                    totalValueSold += item.price;
                }
                else
                {
                    Console.WriteLine("not sold");
                    totalValueInStock += item.price;
                }

                

            }
            Console.WriteLine("total sold value: " + totalValueSold);
            Console.WriteLine();
            Console.WriteLine("total value in stock: " + totalValueInStock);

        }

    }


    

    //Car class inheriting from the vehicle class

    class Car : Vehicle
    {
        public static int numberOfCars;

        public Car(string make, string model, int price, string type = "car") : base (type, make, model, price)
        {

           numberOfCars++;
        }

        public void SoldCar(bool isSold, int price)
        {
            if (isSold) {
                SoldVehicle(isSold,price);
                Car.numberOfCars--;
            }
        }

        
    }

    //Motorbike class inheriting from the vehicle class

    class Motorbikes : Vehicle
    {
        public static int numberOfBikes;

        public Motorbikes(string make, string model, int price, string type = "motorbike") : base (type, make, model, price)
        {
          numberOfBikes++;

        }

        public void SoldMotorbikes(bool isSold, int price)
        {
            if (isSold)
            {
                SoldVehicle(isSold, price);
                Motorbikes.numberOfBikes--;
            }
        }
    }


  

   

    class Program
    {
        static void Main(string[] args)
        {
            Car.numberOfCars = 0;
            Motorbikes.numberOfBikes = 0;

            List<Vehicle> allVehicles = new List<Vehicle>();

            Car car1 = new Car("RollsRoyce", "Silver Cloud", 35000);
            allVehicles.Add(car1);

            Car car2 = new Car("Aston Martin", "DB5", 750000);
            allVehicles.Add(car2);

          
            Car car3 = new Car("Reliant", "Robin", 550);
            allVehicles.Add(car3);
            car3.SoldCar(true, 500);

            //display cars data
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.WriteLine();


            
           Motorbikes Motorbike1 = new Motorbikes("VR1", "VR", 35000);
           allVehicles.Add(Motorbike1);

            Motorbikes Motorbike2 = new Motorbikes("VR2", "VR", 45000);
            allVehicles.Add(Motorbike2);

            //this car uses a different constructor because it needs a value for
            //number of wheels
            Motorbikes Motorbike3 = new Motorbikes("VR3", "VR", 25000);
            allVehicles.Add(Motorbike3);

            Motorbike3.SoldMotorbikes(true, 23500);

            Vehicle.DisplayAllVehicles(allVehicles);

            //display motorbikes data
            
            Console.WriteLine("Total number of motorbikes in stock is: {0}", Car.numberOfCars);
            Console.WriteLine("Total number of motorbikes in stock is: {0}", Motorbikes.numberOfBikes);
            Console.WriteLine();

            Vehicle.DisplayAllVehicles(allVehicles);
        }
    }
}

