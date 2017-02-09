using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphExample
{

    class Polygon
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a polygon. ");
        }
    }

    class Rectangle : Polygon
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle."); 
        }
    }

    class Triangle : Polygon
    {
        public new void Draw()
        {
            Console.WriteLine("Drawing a Triangle.");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            List<Polygon> polygons = new List<Polygon>();
            polygons.Add(new Polygon()); 

            //rectangle cast as a polygon
            polygons.Add(new Rectangle()); 

            //triangle cast as a polygon
            polygons.Add(new Triangle());

            foreach (Polygon p in polygons)
            {
                p.Draw();
            }

            Rectangle rectangle1 = new Rectangle();
            rectangle1.Draw();

            Triangle triangle1 = new Triangle();
            triangle1.Draw();
        }
    }
}
