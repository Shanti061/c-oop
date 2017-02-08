using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carObject
{

    //class should be above/ outside the program

    class Car
    {
        public string make;
        public string model;
        public int price;
        public int seat;
        public string color;
        public Boolean sold;
        public static int carSold;
        //declaring static property which belongs to class as a whole
        public static int totalnumofCars;
        //public static int stockofCars;

        //using constructor 

        public Car(string make, string model, int price){
            this.make = make;
            this.model = model;
            this.price = price;

          //totalnumOfCars++;

        }

        //this is a second constructor, we need to copy the whole value of constructor to the second
        public Car(string make, string model, int price, int seat, string color)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.seat = seat;
            this.color = color;
            Car.totalnumofCars++;
        }
        

        public void AddCar(string make, string model, int price)
        {

            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = true;
           
            Car.carSold++;
        }

        public void SoldCar(bool isSold, int price) {

            this.sold = isSold;
            this.price = price;
            
           Car.totalnumofCars--;

        }

        //
        public static void CarList(List<Car> allCarsList)
        {
            int totalValueSold = 0;
            int totalValueInStock = 0;
           

            foreach (Car item in allCarsList)
            {
                Console.WriteLine("The make of car is {0} , the model is {1}, the price is £{2}, its {3} seated, {4} in color and is  ", item.make, item.model, item.price, item.seat, item.color);
                Console.WriteLine();
                if (item.sold )
                {
                    Console.WriteLine("this car is sold");
                    totalValueSold += item.price;
                }
                else
                {
                    Console.WriteLine("this car is not sold");
                    totalValueInStock += item.price;
                }
                Console.WriteLine();
                totalValueInStock += item.price;

            }
            Console.WriteLine("The number of car sold:  ", totalValueSold);
            Console.WriteLine("The value of  car still in stock:  ", totalValueInStock);
            Console.WriteLine();

        }


        class Program
        {
            static void Main(string[] args)
            {

                
                Car.totalnumofCars = 0;
                List<Car> allCarsList = new List<Car>();


                //adding the value in the car class
                //instantiating an object
                Car car1 = new Car("Rolls Royce", "Silver Cloud", 35000, 4, "red");
                //Car car1 = new Car(4, "red");
                car1.SoldCar(true, 32000);
                allCarsList.Add(car1);
                //totalnumofCars--;

                Car car2 = new Car("Honda", "Honda 1000", 25000, 4, "black");
                //car2.AddCar("Honda", "Honda 1000", 25000);
                //car2.SoldCar(false, 25000);
                allCarsList.Add(car2);

                Car car3 = new Car("Mercedes Benz", "Benz", 45000, 4, "white");
                //car3.AddCar("Mercedes Benz", "Benz", 45000);
                //car3.SoldCar(false, 45000);
                allCarsList.Add(car3);
                //increasing the number of cars

                //displaying the values of car

                Console.WriteLine("The total number of cars: " + Car.totalnumofCars);
                //Console.WriteLine();




                //Console.WriteLine("The make of car is {0} , the model is {1}, the price is £{2} and is  ", car1.make, car1.model, car1.price);
                //if (car1.sold == true)
                //{
                //    Console.WriteLine("this car is sold");
                //}
                //else
                //{
                //    Console.WriteLine("this car is not sold");
                //}
                //Console.WriteLine();

                //Console.WriteLine("The make of car is {0} , the model is {1} and the price is £{2} ", car2.make, car2.model, car2.price);
                
                //Console.WriteLine();

                //Console.WriteLine("The make of car is {0} , the model is {1} and the price is £{2} ", car3.make, car3.model, car3.price);
                //if (car3.sold == true)
                //{
                //    Console.WriteLine("this car is sold");
                //}
                //else
                //{
                //    Console.WriteLine("this car is not sold");
                //}

                Console.WriteLine();
                Car.CarList(allCarsList);
            }

        }
    }       
   
}
