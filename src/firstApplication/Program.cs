using System;
// using static System.Math; // con esto presindimos del prefijo "Math."

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

            ConvertDollarSoles obj = new ConvertDollarSoles();

            obj.ChangeValueDollar(-4.5);// dollar update

            Console.WriteLine(obj.Convert(20));

            Car car1 = new Car();

            Console.WriteLine(car1.getInfo());

            Car car2 = new Car(4500.25, 1200.35);

            Console.WriteLine(car2.getInfo());

            Car car3 = new Car();

            car3.setExtras(true, "cuero");

            Console.WriteLine(car3.getInfo());
            Console.WriteLine(car3.getExtras());

            doTask();

            // clase anonima
            var miVariable = new
            {
                Nombre = "Juan", // el compilador determina el tipo de dato
                Edad = 19
            };

            var miOtraVariable = new
            {
                Nombre = "Ana",
                Edad = 25
            };

            // El compilador reconoce que pertenecen a la misma clase por los campos
            miVariable = miOtraVariable;

            Console.WriteLine(miVariable.Nombre);
            Console.WriteLine(miVariable.Edad);

            int[] edades;

            edades = new int[4];

            Console.WriteLine(edades[2]);

        }

        static void doTask()
        {
            Point origen = new Point();
            Point destino = new Point(128,80);
            Point otherPoint = new Point();

            Console.WriteLine("La distancia es:" + destino.DistanceTo(origen));
            
            Console.WriteLine("Numero de objetos creados {0}",Point.ContadorDeObjetos());
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

    class ConvertDollarSoles
    {
        private double dollar = 4.1;
        public double Convert(double amount)
        {
            return amount * dollar;
        }

        public void ChangeValueDollar(double newValue)
        {
            if (newValue < 0 )
            {
                Console.WriteLine("The value of dollar can't be negative");
            } else {
                dollar = newValue;
            }
        }
    }

    // Propiedades, getter and setter
    partial class Car
    {
        private int wheels;
        private double length;
        private double width;
        private bool airConditioner;
        private string upholstery;

        public int getWheels() { return wheels; }
        public string getInfo() { return "wheels:" + wheels + ", length:" + length + ", width: " + width; }
        public void setExtras(bool airConditioner, string upholstery)
        {
            this.airConditioner = airConditioner;
            this.upholstery = upholstery;
        }
        public string getExtras() { return "Extras of car\n" + "airConditioner:" + airConditioner + ", upholstery:" + upholstery; }
    }
    // Constructores
    partial class Car 
    {
        public Car()
        {
            wheels = 4;
            length = 2300.5;
            width = 0.800;
            upholstery = "tela";

        }
        public Car(double length, double width)
        {
            wheels = 4;
            this.length = length; // Usamos el this para referenciarnos a la propiedad
            this.width = width;
            upholstery = "tela";
        }

    }
}

