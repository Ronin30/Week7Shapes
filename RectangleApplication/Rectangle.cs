using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RectangleApplication
{
   class Rectangle
    {
        //member variables
        internal double length;
        private double width;

        public void AcceptDetails()
        {
            length = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void display()
        {
            // Can also be written as->  WriteLine("Length : " + length.ToString());
            WriteLine("Length : {0}", length);
            WriteLine("Width : {0}", width);
            WriteLine("Area : {0}", GetArea());
            WriteLine("Square Root : {0}", Math.Sqrt(GetArea()));
            ReadKey();
        }
    }

   

    class Square
    {
        double length;
        double width;

        public void AcceptDetails()
        {
            length = 5.8;
            width = 5.8;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void display()
        {
            WriteLine("Length : {0}", length);
            WriteLine("Width : {0}", width);
            WriteLine("Area : {0}", GetArea());
            WriteLine("Square Root : {0}", Math.Sqrt(GetArea()));
        }
    }



    class Triangle
    {
        double side1;
        double side2;

        public void AcceptDetails()
        {
            side1 = 7.8;
            side2 = 6.5;
        }

        public double GetArea()
        {
            return (side1 * side2) / 2;
        }

        public void display()
        {
            WriteLine("Base : {0}", side1);
            WriteLine("Height : {0}", side2);
            WriteLine("Area : {0}", GetArea());
            WriteLine("Square Root : {0}", Math.Sqrt(GetArea()));
        }
    }


    /*class Octagon
   {
       double side;

       public void AcceptDetails()
       {
           side = 10.6;
       }

       public double GetArea()
       {
           return 2(1 + Math.Sqrt(2))(Math.Pow(10.6, 2)));
       }

       public void display()
       {
           WriteLine("Side : {0}", side);
           WriteLine("Area : {0}", GetArea());
           WriteLine("Square Root : {0}", Math.Sqrt(GetArea()));
       }
   }*/

    class ExecuteShapes
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Square s = new Square();
            Triangle t = new Triangle();
           // Octagon o = new Octagon();

    WriteLine("This application finds the area of different shapes.");
    WriteLine();
    r.AcceptDetails();
    r.display();
    WriteLine();

    s.AcceptDetails();
    s.display();
    WriteLine();

    t.AcceptDetails();
    t.display();
    WriteLine();

    //o.AcceptDetails();
    //o.Display();
    ReadLine();
            
        }
    }
}
