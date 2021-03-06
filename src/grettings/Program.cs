using System;

namespace grettings
{
    class Program
    {
        // Los campos de clase o variables se pueden declarar a nivel de clase, para que sean accesibles a traves de los metodos.
        static void Main(string[] args)
        {
            const double IGV = 0.18;
            int age;

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            try
            {
                Console.WriteLine("How old are you?");
                age = int.Parse(Console.ReadLine());
            }
            catch (Exception e) when (e.GetType() != typeof(FormatException))
            {
                Console.WriteLine(e.Message);
                age = 0;
            }
            catch (FormatException)
            {
                Console.WriteLine("You have entered a text");
                age = 0;
            }

            // Console.WriteLine(variable++) Esto mostrara la variable original, pero realizara el incremento sin mostrarlo
            Console.WriteLine("The programmer's name is {0} and he is {1} years old", name, age);
            // {posicion} la posicion se cuenta desde cero, donde las variables empeizan despues de las comilla y serapdas por comas
            Console.WriteLine($"The value of IGV is {IGV}");

            Console.WriteLine(divideNumbers(4, 5));
            gretting();

        }

        // simplificamos un metodo cuando es unsa sola linea 
        static double divideNumbers(double a, int b) => a / b;

        static void gretting() => Console.WriteLine("Hi!");
    }
}
