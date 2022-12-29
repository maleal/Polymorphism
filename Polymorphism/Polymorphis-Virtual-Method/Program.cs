using System;

/* Con metodos Virtual tenemos que implementarlo en la clase base como en sus derivadas */
/*
        An abstract function cannot have functionality. You're basically saying, 
        any child class MUST give their own version of this method, 
        however it's too general to even try to implement in the parent class.

        A virtual function, is basically saying look, here's the functionality
        that may or may not be good enough for the child class. So if it is good
        enough, use this method, if not, then override me, and provide your own functionality.

        So, An abstract function has no implemention and it can only be declared on an abstract class. 
        This forces the derived class to provide an implementation.
        A virtual function provides a default implementation and it can exist on either an abstract class 
        or a non-abstract class.

    */

namespace Polymorphis_Virtual_Method
{
    class Shape
    {
        protected double _length;
        protected double _width;

        public Shape(double l = 0, double w = 0)
        {
            _length = l;
            _width = w;
        }

        public virtual double area()
        {
            return 0;
        }
    }

    class Rectangle : Shape
    {

        public Rectangle(double a = 0, double b = 0) : base(a, b) { }

        public override double area()
        {
            Console.WriteLine("Rectangle class area :");
            return (_width * _length);
        }
    }

    class Circle : Shape
    {
        private double radio;

        public Circle(double a, double b = 0) : base(a, b)
        {
            radio = a;
        }

        public override double area()
        {
            Console.WriteLine("Circle class area :");
            return (radio * radio) * Math.PI;
        }
    }




    class Tester
    {

        public static void caller(Shape shp)
        {
            double a = shp.area();
            Console.WriteLine("Caller area :{0}", a);
        }

        static void Main(string[] args)
        {

            Rectangle r = new Rectangle(10, 7);
            double a = r.area();
            Console.WriteLine("Area: {0}", a);
            Console.ReadKey();

            Shape shp;
            shp = r;
            a = shp.area();
            Console.WriteLine("Area: {0}", a);

            shp = new Circle(2);
            a = shp.area();
            Console.WriteLine("Area: {0}", a);

            caller(shp);

        }
    }
}
