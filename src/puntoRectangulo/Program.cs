using System;

namespace ProjectInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1, y1, x2, y2; // Puntos solicitados
            double xi, yi, xd, yd; // Puntos del algoritmo
            double x, y; // Punto a evaluar

            Console.WriteLine("*** Rentángulo ***");

            while (true)
            {
                Console.WriteLine("Punto A");

                Console.Write("x: ");
                x1 = double.Parse(Console.ReadLine());

                Console.Write("y: ");
                y1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Punto B");

                Console.Write("x: ");
                x2 = double.Parse(Console.ReadLine());

                Console.Write("y: ");
                y2 = double.Parse(Console.ReadLine());

                // Estan sobre un linea ?
                if (x1 == x2 || y1 == y2)
                {
                    Console.WriteLine("Los puntos estan sobre una linea.\nVuelva a ingresar los puntos");
                }
                else
                {
                    break;
                }
            }


            if (x1 < x2 && y1 < y2)
            {
                // Puntos correctos
                xi = x1;
                yi = y1;
                xd = x2;
                yd = y2;
            }
            else 
            {
                // Puntos corregidos
                xi = x1;
                yi = y2;
                xd = x2;
                yd = y1;
            }

            Console.WriteLine("*** Externo ***");

            while (true)
            {
                Console.WriteLine("Punto C");

                Console.Write("x: ");
                x = double.Parse(Console.ReadLine());

                Console.Write("y: ");
                y = double.Parse(Console.ReadLine());

                if (xi <= x && x <= xd && yi <= y && y <= yd)
                {
                    Console.WriteLine("El punto esta en el rectangulo");
                }
                else
                {
                    Console.WriteLine("El punto no esta en el rectangulo");
                }

                Console.Write("Deseas continuar (s/n): ");
                string rpta = Console.ReadLine();

                if (rpta == "n") { break; }

            }

        }

    }
}