using System;

namespace firstApplication
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, I'm a program!");
            Circle myCircle; // creacion de un objeto tipo circulo

            myCircle = new Circle(); // instanciamos la clase circulo

            Console.WriteLine( myCircle.Area(4) );

        }
    }
    class Circle
    {
        private const double pi = 3.14159;
        public double Area(int radius)
        {
            return Math.Pow(radius, 2) * pi;
        }
    }

}

