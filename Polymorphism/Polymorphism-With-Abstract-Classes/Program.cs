using System;

namespace Polymorphism_With_Abstract_Classes
{
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


    /* un ejemplo muy fácil de entender del porque usar clases abstractas es el caso del triángulo, a todos
     * podemos calcularle su area con el dato de su altura y base o con el dato de un lado y su hipotenusa,
     * entonces este calculo comosera general para todos estará en la clase base y el calculo del perímetro
     * lo implementarémos segun el triángulo,, entonces será este un metodo abstracto de la clase
    */

    public abstract class Triangulo
    {
        public abstract decimal Perimetro();

        public double CalcularAreaConHipotenusa(int lado, int hipotenusa)
        {
            double ladob = Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(lado, 2));
            return lado * ladob / 2;
        }
    }

    public class Escaleno : Triangulo
    {
        public override decimal Perimetro()
        {
            throw new NotImplementedException();
        }
    }
    public class Acutangulo : Triangulo
    {
        public override decimal Perimetro()
        {
            throw new NotImplementedException();
        }
    }





    abstract class Shape
    {
        private int _i { get; set; }

        //abstract keyword: This forces the derived class to provide an implementation.
        public abstract double area();

        //Una clase abstracta puede tener metodos no abstractos
        public void log(string str)
        {
            Console.Write("Base Shape Class Log:{0}", str);
        }
    }

    class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }

        public override double area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * length);
        }
    }

    class Circle : Shape
    {
        private double radio;

        public Circle(double r = 0.00)
        {
            radio = r;
        }

        public override double area()
        {
            Console.WriteLine("Circle class area :");
            return (radio * radio) * Math.PI;
        }
    }


    class Program
    {
        public static void callerShape(Shape shp)
        {
            double a = shp.area();
            Console.WriteLine("Caller area :{0}", a);
        }

        static void Main(string[] args)
        {

            /* Cuando usar clases Abstractas ?*/
            Escaleno escaleno = new Escaleno();
            Acutangulo acutangulo = new Acutangulo();

            /* hacemos uso de metodo no abstracto de la clase abstracta*/
            Console.WriteLine("Area Triangulo escaleno: {0}", escaleno.CalcularAreaConHipotenusa(1, 5));
            Console.WriteLine("Area Triangulo acutangulo: {0}", acutangulo.CalcularAreaConHipotenusa(1, 7));

            /* hacemos uso del polimorfismo*/
            escaleno.Perimetro();
            acutangulo.Perimetro();
            /* FIN Cuando usar clases Abstractas ?*/



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

            Program.callerShape(shp);

        }
    }
}

