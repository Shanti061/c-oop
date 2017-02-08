using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInputSecond
{
    class Car {
        public string make;
        public string model;
        public int price;

        public Car(string make, string model, int price) {
            this.make =make;
            this.model=model;
            this.price=price;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            string make, model;
            int price;
            char response;

            Console.WriteLine("Enter a to add new car details or x to exit");
            response = Convert.ToChar(Console.ReadLine().ToUpper());

            List<Car> allCarsList = new List<Car>();
           
            do
            {
                

                if (response == 'A')
                {

                    Console.WriteLine("Enter the details of this car are: ");
                    Console.WriteLine();

                    Console.WriteLine("Enter the make of the car");
                    make = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Enter the model of the car");
                    model = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Enter the price of the car");
                    price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Car myCar = new Car(make, model, price);
                    allCarsList.Add(myCar);


                    //Car.CarList(allCarsList);
                }

                foreach (Car item in allCarsList) {
                    Console.WriteLine("the list of cars ");
                    Console.WriteLine("{0} make" , item.make);
                    Console.WriteLine();

                    //Console.WriteLine("the list of cars ");
                    Console.WriteLine("{1} model ", item.model);
                    Console.WriteLine();

                    //Console.WriteLine("the list of cars ");

                    Console.WriteLine(" {2} price", item.price);
                    Console.WriteLine();
                }
                Console.WriteLine("Enter a to add new car details or x to exit");
                response = Convert.ToChar(Console.ReadLine().ToUpper());

            } while(response !='X');
        }
    }
}
