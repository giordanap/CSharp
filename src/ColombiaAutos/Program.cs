using System;

namespace ColombiaAutos
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MF = 300;

            Console.WriteLine("Bienevenido a Colombiautos");

            Console.WriteLine("***Montos de Venta***");

            Console.Write("Monto Vehículos 2020 (1%):");
            double Veinte = double.Parse(Console.ReadLine());

            Console.Write("Monto Vehículos 2019 (2%):");
            double Diecinueve = double.Parse(Console.ReadLine());

            Console.Write("Monto Vehículos 2018 (3%):");
            double Dieciocho = double.Parse(Console.ReadLine());

            Console.Write("Monto Vehículos Prev (4%):");
            double Otros = double.Parse(Console.ReadLine());

            //Console.Write("Edad cliente:");
            //double edad = double.Parse(Console.ReadLine());

            Console.WriteLine("*** Cálculo de Sueldo ***");

            double MF_Veinte = Veinte * (1.0 / 100);
            double MF_Diecinueve = Diecinueve * (2.0 / 100);
            double MF_Dieciocho = Dieciocho * (3.0 / 100);
            double MF_Otros = Otros * (4.0 / 100);
            double MT = MF + MF_Veinte + MF_Diecinueve + MF_Dieciocho + MF_Otros;

            Console.WriteLine("Monto Fijo ($): " + MF);

            Console.WriteLine("Monto 2020 ($): " + MF_Veinte);

            Console.WriteLine("Monto 2019 ($): " + MF_Diecinueve);

            Console.WriteLine("Monto 2018 ($): " + MF_Dieciocho);

            Console.WriteLine("Monto Prev($): " + MF_Otros);

            Console.WriteLine("Monto Total ($): " + MT);
        }
    }
}
