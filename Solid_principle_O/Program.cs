using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_principle_O
{
    namespace Solic_princ_O
    {

        //abstrac class for Shape
        abstract class Shape
        {
            public abstract double Area(); // the feild in shape class its abstrac class 
        }

        //class for rectangle 
        class Rectangle : Shape
        {
            public double Widhth { get; set; }
            public double Height { get; set; }

            public override double Area()
            {
                return Widhth * Height;
            }


        }

        class Circle : Shape
        {
            public int add { get; set; }
            public int add1 { get; set; }

            public override double Area()
            {
                return add + add1;
            }



        }
        class Program
        {
            static void Main(string[] args)
            {
                Rectangle rect = new Rectangle { Height = 5, Widhth = 4 };
                Circle cir = new Circle { add = 2 , add1 = 4 };

                Console.WriteLine($" area of rectangle : {rect.Area()}"); //20
                Console.WriteLine($" area of Circle : {cir.Area()}"); //6

                Console.ReadLine();

                //Explanation: In this example, the Shape class is open for extension, as we can create new
                //shapes by inheriting from it (e.g., Rectangle, Circle). However, the Shape class itself is
                //closed for modification, ensuring that existing code remains unchanged.

            }
        }
    }
}
