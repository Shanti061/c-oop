using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInputAdd
{
    class Car
    {
        public string make;
        public string model;
        public int price;
        //public Boolean sold;
        public char response;

        // public static int numberOfCars;

        //public Car(string make, string model, int price)
        //{
        //    this.make = make;
        //    this.model = model;
        //    this.price = price;
        //    this.sold = false;
        //    Car.numberOfCars++;
        //}

        class Program
        {
            static void Main(string[] args)
            {


                Console.WriteLine("Enter a to add new car details or x to exit");
                response = Convert.ToChar(Console.ReadLine().ToUpper());

                do
                {
                    if (response == 'A')
                    {
                        
                            Console.WriteLine("Enter the details of this car are: ");
                            Console.WriteLine();

                            Console.WriteLine("Enter the make of the car");
                            make = Console.ReadLine();
                            Console.WriteLine();

                            Console.WriteLine("Enter the make of the car");
                            model = Console.ReadLine();
                            Console.WriteLine();

                            Console.WriteLine("Enter the make of the car");
                            price = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            Car myCar = new Car(make, model, price);

                            Car.ListAllCars(myCar);
                            foreach (Car item in allCars)
                            {
                            Console.WriteLine("The details of this car are: ");
                            Console.Write("Make and model: {0} {1}, price: £{2:N0}.", item.make, item.model, item.price); //:N0 formats the number

                            Console.WriteLine();
                            }

                        Console.WriteLine();
                    }
                }
                while (response != 'x');
               

            }



            //list all the cars
            public static void ListAllCars(List<Car> allCars)
            {

                Console.WriteLine("Enter a to add new car details or x to exit");
                response = Convert.ToChar(Console.ReadLine().ToUpper());
                
                do
                {
                    if (response == 'A')
                    {
                        foreach (Car item in allCars)
                        {
                            Console.WriteLine("The details of this car are: ");
                            Console.Write("Make and model: {0} {1}, price: £{2:N0}.", item.make, item.model, item.price); //:N0 formats the number

                            Console.WriteLine();
                        }

                        Console.WriteLine();
                    }
                }
                while (response != 'x');

            }
        }
    }

     

    }
    
            

            
      