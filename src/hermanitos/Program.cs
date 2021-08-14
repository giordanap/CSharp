using System;

namespace hermanitos
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            double numero;
            Console.WriteLine("*** Divisores ***");
            Console.Write("Cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("(" + (i + 1) + ")");
                Console.Write("Numero: "); // pregunta por ....
                numero = double.Parse(Console.ReadLine());
                Console.Write("Divisores: 1 ");
                bool efg = false;

                if (numero > 0)
                {
                    for (int d = 2; d < numero; d++)
                    {
                        double abc;

                        abc = numero % d;
                        if (numero % d == 0)
                        {
                            efg = true;

                        }

                        if (abc == 0)
                        {
                            Console.Write(d + "  ");
                        }
                    }

                    Console.Write(numero);

                    if (efg)
                    {
                        Console.WriteLine("\n Primo: No");
                    }
                    else
                    {
                        Console.WriteLine("\n Primo: Sí");
                    }
                }
                else
                {
                    Console.WriteLine("Error: El número debe ser positivo");
                }

            }

        }
    }
}
